using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace readEXEfile
{
    public partial class Form1 : Form
    {

        SerialPort _serialComport = new SerialPort();
        private int prohibitionCycleRead = DISABLE;
        private const int OK = 1;
        private const int ERROR = 0;
        private const int ENABLE = 1;
        private const int DISABLE = 0;
        private byte[] nm_buff = new byte[1];
        private int kkk = 0;
        Thread threadForCycleRead;
        object locker = new object();

        struct TCT
        {
            public float level;
            public float volume;
        };

        private ushort countRecords = 0;

        // для доступа из разных потоков
        delegate void StringArgReturningVoidDelegate(string str);

        private string fileForWriteInController = "";

        enum Com
        {
            CycleResponse,
            RequestResponse,
            SizeResponse,
            ExeResponse,
        }

        public Form1()
        {
            InitializeComponent();
            numbComPortComboBox.SelectedIndex = 0;
            baudRateComboBox.SelectedIndex = 2;
            parityComboBox.SelectedIndex = 0;
            stopBitsComboBox.SelectedIndex = 0;
            dataBitsComboBox.SelectedIndex = 1;
            numberOfTankComboBox.SelectedIndex = 0;
            smUnitsOfLengthRadioButton.Select();
            m3UnitsOfVolumeRadioButton.Select();
            textDataTypeRadioButton.Select();
            _serialComport.PortName = numbComPortComboBox.Text;
            _serialComport.BaudRate = int.Parse(baudRateComboBox.Text);
            _serialComport.Parity = (Parity)Enum.Parse(typeof(Parity), parityComboBox.Text);
            _serialComport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsComboBox.Text);
            _serialComport.DataBits = int.Parse(dataBitsComboBox.Text);
            _serialComport.Handshake = Handshake.None;
            _serialComport.ReadTimeout = 2000;
            _serialComport.WriteTimeout = 2000;
            forWriteInControllerOpenFileDialog.Filter = "Text files(*.tcb)|*.tcb";
            readProgressBar.Hide();
            forCreateTableOpenFileDialog.Filter = "Text files(*.txt)|*.txt";
            countOfStringsTextBox.ReadOnly = true;
            saveTableFileDialog.Filter = "Text files(*.tcb)|*.tcb";
        }

        private void openComButton_Click(object sender, EventArgs e)
        {
            if (!_serialComport.IsOpen)
            {

                try
                {
                    _serialComport.Open();
                    sendTextToResponseTextBox("Порт открыт:  "
                        + (_serialComport.PortName, _serialComport.BaudRate, _serialComport.DataBits, _serialComport.Parity, _serialComport.StopBits));
                    threadForCycleRead = new Thread(taskForCycleRead);
                    threadForCycleRead.IsBackground = true; // закроет поток при выходе из программы
                    threadForCycleRead.Start();
                }
                catch
                {
                    sendTextToResponseTextBox("Порт уже открыт или недоступен");
                }
            }
            else
            {
                sendTextToResponseTextBox("Порт уже открыт или недоступен!");
            }

        }

        private void closeComButton_Click(object sender, EventArgs e)
        {
            if (_serialComport.IsOpen)
            {
                threadForCycleRead.Abort();
                Thread.Sleep(100);
                try
                {
                    sendComText("/r");
                    Thread.Sleep(100);
                    _serialComport.Close();
                }
                catch
                {
                    sendTextToResponseTextBox("Проверте физическое наличие порта");
                }
            }
            sendTextToResponseTextBox("Порт закрыт:  " + (_serialComport.PortName));
            //this.Close(); //закрывает программу
        }



        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serialComport.PortName = numbComPortComboBox.Text;
                _serialComport.BaudRate = int.Parse(baudRateComboBox.Text);
                _serialComport.Parity = (Parity)Enum.Parse(typeof(Parity), parityComboBox.Text);
                _serialComport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsComboBox.Text);
                _serialComport.DataBits = int.Parse(dataBitsComboBox.Text);
                _serialComport.Handshake = Handshake.None;
                _serialComport.ReadTimeout = 2000;
                _serialComport.WriteTimeout = 2000;
                sendTextToResponseTextBox("Настрорйки Последовательного порта: "
                    + (_serialComport.PortName, _serialComport.BaudRate, _serialComport.DataBits, _serialComport.Parity, _serialComport.StopBits));

            }
            catch
            {
                sendTextToResponseTextBox("Для настройки последовательного порта необходимо ЗАКРЫТЬ его!");
            }
        }

        private void ClearScrinButton_Click(object sender, EventArgs e)
        {
            responseTextBox.Text = "";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            responseTextBox.Select(responseTextBox.Text.Length, 0);
            try
            {
                if (textDataTypeRadioButton.Checked == true)
                {
                    prohibitionCycleRead = ENABLE;
                    if (sendComText(requestTextBox.Text + "\r") == OK) readCom(Com.RequestResponse);
                    prohibitionCycleRead = DISABLE;
                }
                else
                {
                    sendTextToResponseTextBox("Hex");
                }
            }
            catch
            {
                sendTextToResponseTextBox("Ошибка чтения");
                prohibitionCycleRead = DISABLE;
            }
        }

        private void readComButton_Click(object sender, EventArgs e)
        {
            if (!_serialComport.IsOpen)
            {
                sendTextToResponseTextBox("Откройте последовательный порт!");
            }
            else
            {
                if (nm_buff.Length == 1)
                {
                    sendTextToResponseTextBox("Размер буфера не определен! Нажмите 'Узнать размер'");
                }
                else
                {
                    sendTextToResponseTextBox("Идет процесс скачивание файла! Ожидайте!");
                    readProgressBar.Maximum = 300;
                    readProgressBar.Show();
                    for (long ii = 0; ii < 300; ii += 1)
                    {
                        readProgressBar.Value = (int)ii;
                        _serialComport.Write("MDS " + ii + "\r");
                        Thread.Sleep(140);
                        int buf_bytes = _serialComport.BytesToRead;
                        byte[] nm_buffer = new byte[buf_bytes];
                        _serialComport.Read(nm_buffer, 0, buf_bytes);
                        //responseTextBox.Text += (" !!! " + nm_buffer.Length + "   ");
                        //sendTextToResponseTextBox (BitConverter.ToString(nm_buffer));
                        if (buf_bytes > 1003)
                        {
                            int j = (buf_bytes - 1003);
                            for (int i = 0; i < 1000; i++)
                            {
                                nm_buff[kkk] = nm_buffer[i + j];
                                kkk++;
                            }
                        }
                        else
                        {
                            int j = (buf_bytes - (buf_bytes - 7));
                            for (int i = 0; i < (buf_bytes - 10); i++)
                            {
                                nm_buff[kkk] = nm_buffer[i + j];
                                kkk++;
                            }
                            kkk = 0;
                            break;
                        }
                    }
                    readProgressBar.Hide();
                    //File.WriteAllBytes(@"d:\!\2\nfp.exe", nm_buff);
                    //sendTextToResponseTextBox("Файл из буфера записан на D:-!-2  с названием nfp.exe");
                    sendTextToResponseTextBox("Загрузка завершена");
                    sendTextToResponseTextBox("Размер файла: " + nm_buff.Length);
                    //sendTextToResponseTextBox(BitConverter.ToString(nm_buff));
                }
            }
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            prohibitionCycleRead = ENABLE;
            if (sendComText("SIZE\r") == OK) readCom(Com.SizeResponse);
            prohibitionCycleRead = DISABLE;
        }

        private void exeSaveButton_Click(object sender, EventArgs e)
        {
            if (nm_buff.Length == 1)
            {
                sendTextToResponseTextBox("Размер буфера не определен! Нажмите 'Узнать размер'");
            }
            else
            {
                if (nm_buff[0] == 0x00 && nm_buff[1] == 0x00 && nm_buff[1] == 0x00)
                {
                    sendTextToResponseTextBox("Размер буфера определен но буфер пуст! Нажмите 'Скачать EXE файл'");
                }
                else
                {
                    if (requestTextBox.Text == "")
                    {
                        try
                        {
                            string put = requestTextBox.Text;
                            File.WriteAllBytes(@"d:\!\2\nfp.exe", nm_buff);
                            sendTextToResponseTextBox("Файл из буфера записан на d:\\!\\2\\nfp.exe");
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Создайте папки d:\\!\\2, либо в строке выше укажите путь для сожранения и " +
                                "название файла с расширением .ЕХЕ и нажмите 'Сханить файл'");
                        }
                    }
                    else
                    {
                        try
                        {
                            string put = requestTextBox.Text;
                            File.WriteAllBytes(put, nm_buff);
                            sendTextToResponseTextBox("Файл записан на " + put);
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Не верно указан путь для сохранения файла!");
                        }
                    }
                }
            }
        }

        private void writeTableInControllerButton_Click(object sender, EventArgs e)
        {
            //string path = @"T66_1.tcb";
            string path = @fileForWriteInController;

            try
            {
                byte[] readBytes = File.ReadAllBytes(path);

                if (System.Text.Encoding.ASCII.GetString(readBytes, 0, 2) == "TC")
                {
                    int i = (readBytes[4] & 0xff) | ((readBytes[5] << 8) & 0xff00);
                    if (sendComText(System.Text.Encoding.ASCII.GetString(readBytes, 0, 4)) == OK)
                    {
                        sendComByte(readBytes, 4, 1);
                        sendComByte(readBytes, 5, 1);
                        readProgressBar.Maximum = i + 6;
                        readProgressBar.Show();
                        for (int j = 6; j < (i + 6); j++)
                        {
                            readProgressBar.Value = j;
                            sendComByte(readBytes, j, 1);
                        }
                        readProgressBar.Hide();
                    }
                }
            }
            catch
            {
                sendTextToResponseTextBox("Файл поврежден или отсутствует. Откройте подходящий файл *.tcb ");
            }
        }

        private void openFilForWriteButton_Click(object sender, EventArgs e)
        {
            forWriteInControllerOpenFileDialog.FileName = "Таблица";
            forWriteInControllerOpenFileDialog.Title = "Открыть файл *.tcb для записи в контроллер";
            if (forWriteInControllerOpenFileDialog.ShowDialog() == DialogResult.Cancel) return;
            fileForWriteInController = forWriteInControllerOpenFileDialog.FileName;
            sendTextToResponseTextBox(fileForWriteInController + "   открыт для записи таблицы в контроллер.");
        }

        private void saveTableButton_Click(object sender, EventArgs e)
        {
            saveTableFileDialog.FileName = "Таблица для резервуара №" + numberOfTankComboBox.Text;
            saveTableFileDialog.Title = "Сохранить таблицу *.tcb";
            if (saveTableFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string fileName = saveTableFileDialog.FileName;

            if (saveTableInFile(fileName) == OK)
            {
                sendTextToResponseTextBox("Файл " + fileName + " сохранен.");
            }
            else    //error
            {
                sendTextToResponseTextBox("Не верные данные в таблице!");
            }
        }


        private void tableFromFileButton_Click(object sender, EventArgs e)
        {
            string fileName;
            ushort count = 0;
            forCreateTableOpenFileDialog.FileName = "Таблица";
            forCreateTableOpenFileDialog.Title = "Открыть файл *.txt для формирования таблицы";
            if (forCreateTableOpenFileDialog.ShowDialog() == DialogResult.Cancel) return;
            fileName = forCreateTableOpenFileDialog.FileName;
            sendTextToResponseTextBox("Файл " + fileName + " открыт.");
            try
            {
                clearCalibrationTable();
                foreach (string line in System.IO.File.ReadLines(fileName))
                {
                    if(line != "")
                    {
                        calibrationTableDataGridView.Rows.Add();
                        string[] str = line.Split();
                        calibrationTableDataGridView.Rows[count].Cells[0].Value = float.Parse(str[0].Replace(".", ","));
                        calibrationTableDataGridView.Rows[count].Cells[1].Value = float.Parse(str[1].Replace(".", ","));
                        count++;
                    }
                }
                countRecords = count;
                sendTextToCountOfStringsTextBox(countRecords.ToString());
            }
            catch
            {
                sendTextToResponseTextBox("Файл поврежден или неправильно сформирован.");
                sendTextToCountOfStringsTextBox("Ошибка");
            }
        }

        private void RequestTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                sendButton_Click(this, EventArgs.Empty);
                clearRequestTextBox();
            }
        }

        private void smUnitsOfLengthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smUnitsOfLengthRadioButton.Checked == true)
            {
                if (countRecords != 0)
                {
                    for (ushort i = 0; i < countRecords; i++)
                    {
                        try
                        {
                            calibrationTableDataGridView.Rows[i].Cells[0].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[0].Value.ToString()) / 10;
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Не верные данные в строке номер " + (i + 1));
                        }

                    }
                }
            }
        }

        private void mmUnitsOfLengthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mmUnitsOfLengthRadioButton.Checked == true)
            {
                if (countRecords != 0)
                {
                    for (ushort i = 0; i < countRecords; i++)
                    {
                        try
                        {
                            calibrationTableDataGridView.Rows[i].Cells[0].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[0].Value.ToString()) * 10;
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Не верные данные в строке номер " + (i + 1));
                        }
                    }
                }
            }
        }

        private void m3UnitsOfVolumeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m3UnitsOfVolumeRadioButton.Checked == true)
            {
                if (countRecords != 0)
                {
                    for (ushort i = 0; i < countRecords; i++)
                    {
                        try
                        {
                            calibrationTableDataGridView.Rows[i].Cells[1].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[1].Value.ToString()) / 1000;
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Не верные данные в строке номер " + (i + 1));
                        }
                    }
                }
            }
        }

        private void lUnitsOfVolumeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lUnitsOfVolumeRadioButton.Checked == true)
            {
                if (countRecords != 0)
                {
                    for (ushort i = 0; i < countRecords; i++)
                    {
                        try
                        {
                            calibrationTableDataGridView.Rows[i].Cells[1].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[1].Value.ToString()) * 1000;
                        }
                        catch
                        {
                            sendTextToResponseTextBox("Не верные данные в строке номер " + (i + 1));
                        }
                    }
                }
            }
        }

        private void CalibrationTableDataGridView_EditControlShowing(object Sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (calibrationTableDataGridView.CurrentCell.ColumnIndex == 0 |
                    calibrationTableDataGridView.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(Tb_KeyPress);
            }
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                if (e.KeyChar != (char)Keys.Back)
                { 
                    e.Handled = true;     
                }
            }
        }

        private void calibrationTableDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            countRecords = (ushort)(calibrationTableDataGridView.Rows.Count - 1);
            sendTextToCountOfStringsTextBox(countRecords.ToString());
        }

        private void calibrationTableDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            countRecords = (ushort)(calibrationTableDataGridView.Rows.Count - 1);
            sendTextToCountOfStringsTextBox(countRecords.ToString());
        }

        private void clearRequestTextBox()
        {
            requestTextBox.Text = "";
        }

        private void sendTextToResponseTextBox(string str)
        {
            if (responseTextBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(sendTextToResponseTextBox);
                Invoke(d, new object[] { str });
            }
            else
            {
                responseTextBox.AppendText(str);
                responseTextBox.AppendText(Environment.NewLine);
            }
        }

        private void sendTextToCountOfStringsTextBox(string str)
        {
            if (countOfStringsTextBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(sendTextToCountOfStringsTextBox);
                Invoke(d, new object[] { str });
            }
            else
            {
                countOfStringsTextBox.Text = str;
            }
        }

        private void sendComByte(byte[] bytes, int offset, int count)
        {
            if (!_serialComport.IsOpen)
            {
                sendTextToResponseTextBox("Откройте последовательный порт!");
            }
            else
            {
                _serialComport.Write(bytes, offset, count);
            }
        }

        private int sendComText(string str)
        {
            if (!_serialComport.IsOpen)
            {
                sendTextToResponseTextBox("Откройте последовательный порт!");
                return ERROR;
            }
            else
            {
                _serialComport.Write(str);
                Thread.Sleep(100);
                return OK;
            }
        }

        private void readCom(Enum com)
        {
            lock (locker)
            {
                if (_serialComport.BytesToRead != 0)
                {
                    switch (com)
                    {
                        case Com.CycleResponse:
                            readComCycleResponse();
                            break;
                        case Com.ExeResponse:
                            readComExeResponse();
                            break;
                        case Com.RequestResponse:
                            readComResponse();
                            break;
                        case Com.SizeResponse:
                            readComSizeResponse();
                            break;
                    }
                }
                else
                {
                    if (prohibitionCycleRead != DISABLE)
                    {
                        sendTextToResponseTextBox("Ответа нет! Проверте связь");
                    }
                }
            }
        }

        private void readComResponse()
        {
            string response;
            if (_serialComport.BytesToRead > 30)
            {
                for (int i = 0; i < 5000; i++)
                {
                    if (_serialComport.BytesToRead > 0)
                    {
                        if (_serialComport.BytesToRead < 3)
                        {
                            response = _serialComport.ReadExisting();
                            sendTextToResponseTextBox(response);
                        }
                        else
                        {
                            response = _serialComport.ReadLine();
                            sendTextToResponseTextBox(response);
                        }
                    }
                }
            }
            else
            {
                response = _serialComport.ReadExisting();
                sendTextToResponseTextBox(response);
            }
        }

        private void readComSizeResponse()
        {
            string response;
            string str = "";
            response = _serialComport.ReadExisting();

            sendTextToResponseTextBox(response);
            foreach (char ch in response)
            {
                if (char.IsDigit(ch))
                {
                    str += ch;
                }
            }
            try
            {
                int size = Convert.ToInt32(str);
                nm_buff = new byte[size];
                sendTextToResponseTextBox("Размер буфера для записи = " + nm_buff.Length);
            }
            catch
            {
                sendTextToResponseTextBox("Размер буфера для записи не определен");
            }
        }

        private void readComExeResponse()
        {
        }

        private void readComCycleResponse()
        {
            if (_serialComport.IsOpen)
            {
                if (prohibitionCycleRead == DISABLE)
                {
                    string str = _serialComport.ReadExisting();
                    sendTextToResponseTextBox(str);
                }
            }
        }

        private void taskForCycleRead()
        {
            while (true)
            {
                readCom(Com.CycleResponse);
                Thread.Sleep(500);
            }
        }

        private int saveTableInFile(string fileName)
        {
            TCT tct;
            uint crc16 = 0;
            byte[] bytesLevel;
            byte[] bytesVolume;
            if (checkTheTable() == ERROR) return ERROR;
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));
            try
            {
                binaryWriter.Write('T');
                binaryWriter.Write('C');
                binaryWriter.Write(numberOfTankComboBox.Text[0]);
                binaryWriter.Write((char)0xd);
                binaryWriter.Write((ushort)((countRecords * (ushort)8) + (ushort)4));
                for (ushort i = 0; i < countRecords; i++)
                {

                    tct.level = float.Parse(calibrationTableDataGridView.Rows[i].Cells[0].Value.ToString());
                    binaryWriter.Write(tct.level);
                    bytesLevel = BitConverter.GetBytes(tct.level);
                    tct.volume = float.Parse(calibrationTableDataGridView.Rows[i].Cells[1].Value.ToString());
                    binaryWriter.Write(tct.volume);
                    bytesVolume = BitConverter.GetBytes(tct.volume);
                    for (int ii = 0; ii < 4; ii++)
                    {
                        crc16 += ((uint)bytesLevel[ii] & 0xff);
                    }
                    for (int ii = 0; ii < 4; ii++)
                    {
                        crc16 += ((uint)bytesVolume[ii] & 0xff);
                    }
                }
                binaryWriter.Write(crc16);
                return OK;
            }
            catch
            {
                return ERROR;
            }
            finally
            {
                binaryWriter.Close();
            }
        }

        private int checkTheTable()
        {
            for (ushort i = 0; i < countRecords; i++)
            {
                try
                {
                    if (smUnitsOfLengthRadioButton.Checked)
                    {
                        calibrationTableDataGridView.Rows[i].Cells[0].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[0].Value.ToString()) * 10;
                        mmUnitsOfLengthRadioButton.Select();
                    }
                    else
                    {
                        float.Parse(calibrationTableDataGridView.Rows[i].Cells[0].Value.ToString());
                    }
                    if (m3UnitsOfVolumeRadioButton.Checked)
                    {
                        calibrationTableDataGridView.Rows[i].Cells[1].Value = float.Parse(calibrationTableDataGridView.Rows[i].Cells[1].Value.ToString()) / 1000;
                        lUnitsOfVolumeRadioButton.Select();
                    }
                    else
                    {
                        float.Parse(calibrationTableDataGridView.Rows[i].Cells[1].Value.ToString());
                    }
                }
                catch
                {
                    sendTextToResponseTextBox("Не верные данные в строке номер " + (i + 1));
                    return ERROR;
                }
            }
            return OK;
        }
        
        private void clearCalibrationTable()
        {
            calibrationTableDataGridView.Rows.Clear();
        }
    }
}
