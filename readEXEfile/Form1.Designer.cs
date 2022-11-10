namespace readEXEfile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonsAndDataTypePanel = new System.Windows.Forms.Panel();
            this.sizeButton = new System.Windows.Forms.Button();
            this.exeSaveButton = new System.Windows.Forms.Button();
            this.readComButton = new System.Windows.Forms.Button();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.clearScrinButton = new System.Windows.Forms.Button();
            this.dataTypePanel = new System.Windows.Forms.Panel();
            this.textDataTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.hexDataTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.serialPortCommunicationLabel = new System.Windows.Forms.Label();
            this.inputTypePanel = new System.Windows.Forms.Panel();
            this.saveTableButton = new System.Windows.Forms.Button();
            this.openFilForWriteButton = new System.Windows.Forms.Button();
            this.calibrationTableDataGridView = new System.Windows.Forms.DataGridView();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfTankPanel = new System.Windows.Forms.Panel();
            this.numberOfTankComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfTankLabel = new System.Windows.Forms.Label();
            this.writeTableInControllerButton = new System.Windows.Forms.Button();
            this.countOfStringsPanel = new System.Windows.Forms.Panel();
            this.counOfStringsLabel = new System.Windows.Forms.Label();
            this.countOfStringsTextBox = new System.Windows.Forms.TextBox();
            this.unitsOfLengthPanel = new System.Windows.Forms.Panel();
            this.smUnitsOfLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.unitsOfLengthLabel = new System.Windows.Forms.Label();
            this.mmUnitsOfLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.unitsOfVolumePanel = new System.Windows.Forms.Panel();
            this.m3UnitsOfVolumeRadioButton = new System.Windows.Forms.RadioButton();
            this.unitsOfVolumeLabel = new System.Windows.Forms.Label();
            this.lUnitsOfVolumeRadioButton = new System.Windows.Forms.RadioButton();
            this.tableFromFileButton = new System.Windows.Forms.Button();
            this.inputTableLabel = new System.Windows.Forms.Label();
            this.forWriteInControllerOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.forCreateTableOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTableFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.portLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.closeCom = new System.Windows.Forms.Button();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.openCom = new System.Windows.Forms.Button();
            this.numbComPortComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.readProgressBar = new System.Windows.Forms.ProgressBar();
            this.serialPortCommunicationAndOptionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonsAndDataTypePanel.SuspendLayout();
            this.dataTypePanel.SuspendLayout();
            this.inputTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationTableDataGridView)).BeginInit();
            this.numberOfTankPanel.SuspendLayout();
            this.countOfStringsPanel.SuspendLayout();
            this.unitsOfLengthPanel.SuspendLayout();
            this.unitsOfVolumePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialPortCommunicationAndOptionsSplitContainer)).BeginInit();
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.SuspendLayout();
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.SuspendLayout();
            this.serialPortCommunicationAndOptionsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsAndDataTypePanel
            // 
            this.buttonsAndDataTypePanel.BackColor = System.Drawing.Color.Silver;
            this.buttonsAndDataTypePanel.Controls.Add(this.sizeButton);
            this.buttonsAndDataTypePanel.Controls.Add(this.exeSaveButton);
            this.buttonsAndDataTypePanel.Controls.Add(this.readComButton);
            this.buttonsAndDataTypePanel.Controls.Add(this.dataTypeLabel);
            this.buttonsAndDataTypePanel.Controls.Add(this.clearScrinButton);
            this.buttonsAndDataTypePanel.Controls.Add(this.dataTypePanel);
            this.buttonsAndDataTypePanel.Location = new System.Drawing.Point(273, 12);
            this.buttonsAndDataTypePanel.Name = "buttonsAndDataTypePanel";
            this.buttonsAndDataTypePanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonsAndDataTypePanel.Size = new System.Drawing.Size(1033, 63);
            this.buttonsAndDataTypePanel.TabIndex = 2;
            this.buttonsAndDataTypePanel.Visible = false;
            // 
            // sizeButton
            // 
            this.sizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.sizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeButton.FlatAppearance.BorderSize = 0;
            this.sizeButton.Location = new System.Drawing.Point(256, 14);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(165, 38);
            this.sizeButton.TabIndex = 9;
            this.sizeButton.Text = "Узнать размер файла";
            this.sizeButton.UseVisualStyleBackColor = false;
            this.sizeButton.Visible = false;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // exeSaveButton
            // 
            this.exeSaveButton.BackColor = System.Drawing.Color.DarkGray;
            this.exeSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exeSaveButton.FlatAppearance.BorderSize = 0;
            this.exeSaveButton.Location = new System.Drawing.Point(598, 14);
            this.exeSaveButton.Name = "exeSaveButton";
            this.exeSaveButton.Size = new System.Drawing.Size(165, 38);
            this.exeSaveButton.TabIndex = 8;
            this.exeSaveButton.Text = "Сохранить скачанный файл";
            this.exeSaveButton.UseVisualStyleBackColor = false;
            this.exeSaveButton.Visible = false;
            this.exeSaveButton.Click += new System.EventHandler(this.exeSaveButton_Click);
            // 
            // readComButton
            // 
            this.readComButton.BackColor = System.Drawing.Color.DarkGray;
            this.readComButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readComButton.FlatAppearance.BorderSize = 0;
            this.readComButton.Location = new System.Drawing.Point(427, 14);
            this.readComButton.Name = "readComButton";
            this.readComButton.Size = new System.Drawing.Size(165, 38);
            this.readComButton.TabIndex = 6;
            this.readComButton.Text = "Скачать исполняемый файл";
            this.readComButton.UseVisualStyleBackColor = false;
            this.readComButton.Visible = false;
            this.readComButton.Click += new System.EventHandler(this.readComButton_Click);
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dataTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.dataTypeLabel.Location = new System.Drawing.Point(815, 3);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(95, 18);
            this.dataTypeLabel.TabIndex = 5;
            this.dataTypeLabel.Text = "Тип данных";
            // 
            // clearScrinButton
            // 
            this.clearScrinButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearScrinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearScrinButton.FlatAppearance.BorderSize = 0;
            this.clearScrinButton.Location = new System.Drawing.Point(16, 12);
            this.clearScrinButton.Name = "clearScrinButton";
            this.clearScrinButton.Size = new System.Drawing.Size(111, 38);
            this.clearScrinButton.TabIndex = 2;
            this.clearScrinButton.Text = "Очистить Экран";
            this.clearScrinButton.UseVisualStyleBackColor = false;
            this.clearScrinButton.Click += new System.EventHandler(this.ClearScrinButton_Click);
            // 
            // dataTypePanel
            // 
            this.dataTypePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.dataTypePanel.Controls.Add(this.textDataTypeRadioButton);
            this.dataTypePanel.Controls.Add(this.hexDataTypeRadioButton);
            this.dataTypePanel.Location = new System.Drawing.Point(802, 12);
            this.dataTypePanel.Name = "dataTypePanel";
            this.dataTypePanel.Size = new System.Drawing.Size(228, 38);
            this.dataTypePanel.TabIndex = 7;
            // 
            // textDataTypeRadioButton
            // 
            this.textDataTypeRadioButton.AutoSize = true;
            this.textDataTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDataTypeRadioButton.Location = new System.Drawing.Point(160, 11);
            this.textDataTypeRadioButton.Name = "textDataTypeRadioButton";
            this.textDataTypeRadioButton.Size = new System.Drawing.Size(64, 20);
            this.textDataTypeRadioButton.TabIndex = 7;
            this.textDataTypeRadioButton.TabStop = true;
            this.textDataTypeRadioButton.Text = "Текст";
            this.textDataTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexDataTypeRadioButton
            // 
            this.hexDataTypeRadioButton.AutoSize = true;
            this.hexDataTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexDataTypeRadioButton.Location = new System.Drawing.Point(104, 11);
            this.hexDataTypeRadioButton.Name = "hexDataTypeRadioButton";
            this.hexDataTypeRadioButton.Size = new System.Drawing.Size(50, 20);
            this.hexDataTypeRadioButton.TabIndex = 6;
            this.hexDataTypeRadioButton.TabStop = true;
            this.hexDataTypeRadioButton.Text = "Hex";
            this.hexDataTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsLabel.ForeColor = System.Drawing.Color.Black;
            this.optionsLabel.Location = new System.Drawing.Point(1089, 20);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(57, 18);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Опции";
            // 
            // serialPortCommunicationLabel
            // 
            this.serialPortCommunicationLabel.AutoSize = true;
            this.serialPortCommunicationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serialPortCommunicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialPortCommunicationLabel.ForeColor = System.Drawing.Color.Black;
            this.serialPortCommunicationLabel.Location = new System.Drawing.Point(300, 20);
            this.serialPortCommunicationLabel.Name = "serialPortCommunicationLabel";
            this.serialPortCommunicationLabel.Size = new System.Drawing.Size(288, 18);
            this.serialPortCommunicationLabel.TabIndex = 4;
            this.serialPortCommunicationLabel.Text = "Связь через последовательный порт";
            // 
            // inputTypePanel
            // 
            this.inputTypePanel.BackColor = System.Drawing.Color.Silver;
            this.inputTypePanel.Controls.Add(this.saveTableButton);
            this.inputTypePanel.Controls.Add(this.openFilForWriteButton);
            this.inputTypePanel.Controls.Add(this.calibrationTableDataGridView);
            this.inputTypePanel.Controls.Add(this.numberOfTankPanel);
            this.inputTypePanel.Controls.Add(this.writeTableInControllerButton);
            this.inputTypePanel.Controls.Add(this.countOfStringsPanel);
            this.inputTypePanel.Controls.Add(this.unitsOfLengthPanel);
            this.inputTypePanel.Controls.Add(this.unitsOfVolumePanel);
            this.inputTypePanel.Controls.Add(this.tableFromFileButton);
            this.inputTypePanel.Location = new System.Drawing.Point(2, 29);
            this.inputTypePanel.Name = "inputTypePanel";
            this.inputTypePanel.Size = new System.Drawing.Size(265, 515);
            this.inputTypePanel.TabIndex = 5;
            // 
            // saveTableButton
            // 
            this.saveTableButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTableButton.FlatAppearance.BorderSize = 0;
            this.saveTableButton.Location = new System.Drawing.Point(66, 419);
            this.saveTableButton.Name = "saveTableButton";
            this.saveTableButton.Size = new System.Drawing.Size(131, 38);
            this.saveTableButton.TabIndex = 28;
            this.saveTableButton.Text = "Сохранить файл *.tcb";
            this.saveTableButton.UseVisualStyleBackColor = false;
            this.saveTableButton.Click += new System.EventHandler(this.saveTableButton_Click);
            // 
            // openFilForWriteButton
            // 
            this.openFilForWriteButton.BackColor = System.Drawing.Color.DarkGray;
            this.openFilForWriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFilForWriteButton.FlatAppearance.BorderSize = 0;
            this.openFilForWriteButton.Location = new System.Drawing.Point(13, 463);
            this.openFilForWriteButton.Name = "openFilForWriteButton";
            this.openFilForWriteButton.Size = new System.Drawing.Size(119, 38);
            this.openFilForWriteButton.TabIndex = 27;
            this.openFilForWriteButton.Text = "Открыть файл *.tcb для записи";
            this.openFilForWriteButton.UseVisualStyleBackColor = false;
            this.openFilForWriteButton.Click += new System.EventHandler(this.openFilForWriteButton_Click);
            // 
            // calibrationTableDataGridView
            // 
            this.calibrationTableDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.calibrationTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calibrationTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.length,
            this.Volume});
            this.calibrationTableDataGridView.Location = new System.Drawing.Point(3, 228);
            this.calibrationTableDataGridView.Name = "calibrationTableDataGridView";
            this.calibrationTableDataGridView.Size = new System.Drawing.Size(259, 185);
            this.calibrationTableDataGridView.TabIndex = 26;
            this.calibrationTableDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.CalibrationTableDataGridView_EditControlShowing);
            this.calibrationTableDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.calibrationTableDataGridView_UserAddedRow);
            this.calibrationTableDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.calibrationTableDataGridView_UserDeletedRow);
            // 
            // length
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.length.DefaultCellStyle = dataGridViewCellStyle1;
            this.length.HeaderText = "Уровень";
            this.length.Name = "length";
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Объем";
            this.Volume.Name = "Volume";
            // 
            // numberOfTankPanel
            // 
            this.numberOfTankPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.numberOfTankPanel.Controls.Add(this.numberOfTankComboBox);
            this.numberOfTankPanel.Controls.Add(this.numberOfTankLabel);
            this.numberOfTankPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numberOfTankPanel.Location = new System.Drawing.Point(7, 61);
            this.numberOfTankPanel.Name = "numberOfTankPanel";
            this.numberOfTankPanel.Size = new System.Drawing.Size(246, 40);
            this.numberOfTankPanel.TabIndex = 25;
            // 
            // numberOfTankComboBox
            // 
            this.numberOfTankComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberOfTankComboBox.FormattingEnabled = true;
            this.numberOfTankComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.numberOfTankComboBox.Location = new System.Drawing.Point(143, 10);
            this.numberOfTankComboBox.Name = "numberOfTankComboBox";
            this.numberOfTankComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberOfTankComboBox.Size = new System.Drawing.Size(97, 21);
            this.numberOfTankComboBox.TabIndex = 10;
            // 
            // numberOfTankLabel
            // 
            this.numberOfTankLabel.AutoSize = true;
            this.numberOfTankLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfTankLabel.Location = new System.Drawing.Point(2, 10);
            this.numberOfTankLabel.Name = "numberOfTankLabel";
            this.numberOfTankLabel.Size = new System.Drawing.Size(106, 17);
            this.numberOfTankLabel.TabIndex = 15;
            this.numberOfTankLabel.Text = "№ резервуара:";
            // 
            // writeTableInControllerButton
            // 
            this.writeTableInControllerButton.BackColor = System.Drawing.Color.DarkGray;
            this.writeTableInControllerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeTableInControllerButton.FlatAppearance.BorderSize = 0;
            this.writeTableInControllerButton.Location = new System.Drawing.Point(132, 463);
            this.writeTableInControllerButton.Name = "writeTableInControllerButton";
            this.writeTableInControllerButton.Size = new System.Drawing.Size(121, 38);
            this.writeTableInControllerButton.TabIndex = 10;
            this.writeTableInControllerButton.Text = "Записать файл *.tcb в ВРФ";
            this.writeTableInControllerButton.UseVisualStyleBackColor = false;
            this.writeTableInControllerButton.Click += new System.EventHandler(this.writeTableInControllerButton_Click);
            // 
            // countOfStringsPanel
            // 
            this.countOfStringsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.countOfStringsPanel.Controls.Add(this.counOfStringsLabel);
            this.countOfStringsPanel.Controls.Add(this.countOfStringsTextBox);
            this.countOfStringsPanel.Location = new System.Drawing.Point(7, 107);
            this.countOfStringsPanel.Name = "countOfStringsPanel";
            this.countOfStringsPanel.Size = new System.Drawing.Size(246, 43);
            this.countOfStringsPanel.TabIndex = 24;
            // 
            // counOfStringsLabel
            // 
            this.counOfStringsLabel.AutoSize = true;
            this.counOfStringsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counOfStringsLabel.Location = new System.Drawing.Point(3, 9);
            this.counOfStringsLabel.Name = "counOfStringsLabel";
            this.counOfStringsLabel.Size = new System.Drawing.Size(134, 17);
            this.counOfStringsLabel.TabIndex = 12;
            this.counOfStringsLabel.Text = "Количество строк";
            // 
            // countOfStringsTextBox
            // 
            this.countOfStringsTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfStringsTextBox.Location = new System.Drawing.Point(146, 9);
            this.countOfStringsTextBox.Multiline = true;
            this.countOfStringsTextBox.Name = "countOfStringsTextBox";
            this.countOfStringsTextBox.Size = new System.Drawing.Size(94, 24);
            this.countOfStringsTextBox.TabIndex = 13;
            this.countOfStringsTextBox.Text = "0";
            this.countOfStringsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitsOfLengthPanel
            // 
            this.unitsOfLengthPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.unitsOfLengthPanel.Controls.Add(this.smUnitsOfLengthRadioButton);
            this.unitsOfLengthPanel.Controls.Add(this.unitsOfLengthLabel);
            this.unitsOfLengthPanel.Controls.Add(this.mmUnitsOfLengthRadioButton);
            this.unitsOfLengthPanel.Location = new System.Drawing.Point(7, 156);
            this.unitsOfLengthPanel.Name = "unitsOfLengthPanel";
            this.unitsOfLengthPanel.Size = new System.Drawing.Size(246, 30);
            this.unitsOfLengthPanel.TabIndex = 23;
            // 
            // smUnitsOfLengthRadioButton
            // 
            this.smUnitsOfLengthRadioButton.AutoSize = true;
            this.smUnitsOfLengthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smUnitsOfLengthRadioButton.Location = new System.Drawing.Point(196, 5);
            this.smUnitsOfLengthRadioButton.Name = "smUnitsOfLengthRadioButton";
            this.smUnitsOfLengthRadioButton.Size = new System.Drawing.Size(42, 20);
            this.smUnitsOfLengthRadioButton.TabIndex = 22;
            this.smUnitsOfLengthRadioButton.TabStop = true;
            this.smUnitsOfLengthRadioButton.Text = "см";
            this.smUnitsOfLengthRadioButton.UseVisualStyleBackColor = true;
            this.smUnitsOfLengthRadioButton.CheckedChanged += new System.EventHandler(this.smUnitsOfLengthRadioButton_CheckedChanged);
            // 
            // unitsOfLengthLabel
            // 
            this.unitsOfLengthLabel.AutoSize = true;
            this.unitsOfLengthLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitsOfLengthLabel.Location = new System.Drawing.Point(3, 6);
            this.unitsOfLengthLabel.Name = "unitsOfLengthLabel";
            this.unitsOfLengthLabel.Size = new System.Drawing.Size(129, 17);
            this.unitsOfLengthLabel.TabIndex = 18;
            this.unitsOfLengthLabel.Text = "Единицы длины:";
            // 
            // mmUnitsOfLengthRadioButton
            // 
            this.mmUnitsOfLengthRadioButton.AutoSize = true;
            this.mmUnitsOfLengthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmUnitsOfLengthRadioButton.Location = new System.Drawing.Point(146, 5);
            this.mmUnitsOfLengthRadioButton.Name = "mmUnitsOfLengthRadioButton";
            this.mmUnitsOfLengthRadioButton.Size = new System.Drawing.Size(44, 20);
            this.mmUnitsOfLengthRadioButton.TabIndex = 21;
            this.mmUnitsOfLengthRadioButton.TabStop = true;
            this.mmUnitsOfLengthRadioButton.Text = "мм";
            this.mmUnitsOfLengthRadioButton.UseVisualStyleBackColor = true;
            this.mmUnitsOfLengthRadioButton.CheckedChanged += new System.EventHandler(this.mmUnitsOfLengthRadioButton_CheckedChanged);
            // 
            // unitsOfVolumePanel
            // 
            this.unitsOfVolumePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.unitsOfVolumePanel.Controls.Add(this.m3UnitsOfVolumeRadioButton);
            this.unitsOfVolumePanel.Controls.Add(this.unitsOfVolumeLabel);
            this.unitsOfVolumePanel.Controls.Add(this.lUnitsOfVolumeRadioButton);
            this.unitsOfVolumePanel.Location = new System.Drawing.Point(7, 192);
            this.unitsOfVolumePanel.Name = "unitsOfVolumePanel";
            this.unitsOfVolumePanel.Size = new System.Drawing.Size(246, 30);
            this.unitsOfVolumePanel.TabIndex = 20;
            // 
            // m3UnitsOfVolumeRadioButton
            // 
            this.m3UnitsOfVolumeRadioButton.AutoSize = true;
            this.m3UnitsOfVolumeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m3UnitsOfVolumeRadioButton.Location = new System.Drawing.Point(196, 5);
            this.m3UnitsOfVolumeRadioButton.Name = "m3UnitsOfVolumeRadioButton";
            this.m3UnitsOfVolumeRadioButton.Size = new System.Drawing.Size(42, 20);
            this.m3UnitsOfVolumeRadioButton.TabIndex = 22;
            this.m3UnitsOfVolumeRadioButton.TabStop = true;
            this.m3UnitsOfVolumeRadioButton.Text = "м3";
            this.m3UnitsOfVolumeRadioButton.UseVisualStyleBackColor = true;
            this.m3UnitsOfVolumeRadioButton.CheckedChanged += new System.EventHandler(this.m3UnitsOfVolumeRadioButton_CheckedChanged);
            // 
            // unitsOfVolumeLabel
            // 
            this.unitsOfVolumeLabel.AutoSize = true;
            this.unitsOfVolumeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitsOfVolumeLabel.Location = new System.Drawing.Point(3, 6);
            this.unitsOfVolumeLabel.Name = "unitsOfVolumeLabel";
            this.unitsOfVolumeLabel.Size = new System.Drawing.Size(133, 17);
            this.unitsOfVolumeLabel.TabIndex = 18;
            this.unitsOfVolumeLabel.Text = "Единицы объема:";
            // 
            // lUnitsOfVolumeRadioButton
            // 
            this.lUnitsOfVolumeRadioButton.AutoSize = true;
            this.lUnitsOfVolumeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUnitsOfVolumeRadioButton.Location = new System.Drawing.Point(146, 5);
            this.lUnitsOfVolumeRadioButton.Name = "lUnitsOfVolumeRadioButton";
            this.lUnitsOfVolumeRadioButton.Size = new System.Drawing.Size(34, 20);
            this.lUnitsOfVolumeRadioButton.TabIndex = 21;
            this.lUnitsOfVolumeRadioButton.TabStop = true;
            this.lUnitsOfVolumeRadioButton.Text = "л";
            this.lUnitsOfVolumeRadioButton.UseVisualStyleBackColor = true;
            this.lUnitsOfVolumeRadioButton.CheckedChanged += new System.EventHandler(this.lUnitsOfVolumeRadioButton_CheckedChanged);
            // 
            // tableFromFileButton
            // 
            this.tableFromFileButton.BackColor = System.Drawing.Color.DarkGray;
            this.tableFromFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableFromFileButton.FlatAppearance.BorderSize = 0;
            this.tableFromFileButton.Location = new System.Drawing.Point(27, 17);
            this.tableFromFileButton.Name = "tableFromFileButton";
            this.tableFromFileButton.Size = new System.Drawing.Size(211, 38);
            this.tableFromFileButton.TabIndex = 10;
            this.tableFromFileButton.Text = "Сформировать таблицу из файла *.txt";
            this.tableFromFileButton.UseVisualStyleBackColor = false;
            this.tableFromFileButton.Click += new System.EventHandler(this.tableFromFileButton_Click);
            // 
            // inputTableLabel
            // 
            this.inputTableLabel.AutoSize = true;
            this.inputTableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTableLabel.ForeColor = System.Drawing.Color.Black;
            this.inputTableLabel.Location = new System.Drawing.Point(9, 20);
            this.inputTableLabel.Name = "inputTableLabel";
            this.inputTableLabel.Size = new System.Drawing.Size(231, 18);
            this.inputTableLabel.TabIndex = 6;
            this.inputTableLabel.Text = "Ввод градуировочных таблиц";
            // 
            // forWriteInControllerOpenFileDialog
            // 
            this.forWriteInControllerOpenFileDialog.FileName = "forWriteInControllerOpenFileDialog";
            // 
            // forCreateTableOpenFileDialog
            // 
            this.forCreateTableOpenFileDialog.FileName = "forCreateTableOpenFileDialog";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLabel.Location = new System.Drawing.Point(14, 20);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(41, 16);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Порт";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baudRateLabel.Location = new System.Drawing.Point(14, 63);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(69, 16);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Скорость";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parityLabel.Location = new System.Drawing.Point(14, 107);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(69, 16);
            this.parityLabel.TabIndex = 2;
            this.parityLabel.Text = "Четность";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBitsLabel.Location = new System.Drawing.Point(17, 150);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(67, 16);
            this.stopBitsLabel.TabIndex = 3;
            this.stopBitsLabel.Text = "Стоп Бит";
            // 
            // closeCom
            // 
            this.closeCom.BackColor = System.Drawing.Color.DarkGray;
            this.closeCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeCom.FlatAppearance.BorderSize = 0;
            this.closeCom.Location = new System.Drawing.Point(117, 283);
            this.closeCom.Name = "closeCom";
            this.closeCom.Size = new System.Drawing.Size(95, 38);
            this.closeCom.TabIndex = 1;
            this.closeCom.Text = "Закрыть Порт";
            this.closeCom.UseVisualStyleBackColor = false;
            this.closeCom.Click += new System.EventHandler(this.closeComButton_Click);
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBitsLabel.Location = new System.Drawing.Point(17, 193);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(82, 16);
            this.dataBitsLabel.TabIndex = 4;
            this.dataBitsLabel.Text = "Бит данных";
            // 
            // openCom
            // 
            this.openCom.BackColor = System.Drawing.Color.DarkGray;
            this.openCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCom.FlatAppearance.BorderSize = 0;
            this.openCom.Location = new System.Drawing.Point(17, 283);
            this.openCom.Name = "openCom";
            this.openCom.Size = new System.Drawing.Size(95, 38);
            this.openCom.TabIndex = 0;
            this.openCom.Text = "Открыть Порт";
            this.openCom.UseVisualStyleBackColor = false;
            this.openCom.Click += new System.EventHandler(this.openComButton_Click);
            // 
            // numbComPortComboBox
            // 
            this.numbComPortComboBox.FormattingEnabled = true;
            this.numbComPortComboBox.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7",
            "Com8",
            "Com9"});
            this.numbComPortComboBox.Location = new System.Drawing.Point(17, 39);
            this.numbComPortComboBox.Name = "numbComPortComboBox";
            this.numbComPortComboBox.Size = new System.Drawing.Size(195, 21);
            this.numbComPortComboBox.TabIndex = 5;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(17, 82);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(195, 21);
            this.baudRateComboBox.TabIndex = 6;
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parityComboBox.Location = new System.Drawing.Point(17, 126);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(195, 21);
            this.parityComboBox.TabIndex = 7;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(17, 169);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(195, 21);
            this.stopBitsComboBox.TabIndex = 8;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(17, 212);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(195, 21);
            this.dataBitsComboBox.TabIndex = 9;
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.DarkGray;
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.FlatAppearance.BorderSize = 0;
            this.applyButton.Location = new System.Drawing.Point(56, 239);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(114, 38);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // responseTextBox
            // 
            this.responseTextBox.AllowDrop = true;
            this.responseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.responseTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responseTextBox.Location = new System.Drawing.Point(16, 12);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseTextBox.Size = new System.Drawing.Size(748, 445);
            this.responseTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkGray;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.Location = new System.Drawing.Point(653, 463);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 38);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Отправить в Порт";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestTextBox.Location = new System.Drawing.Point(16, 463);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(614, 38);
            this.requestTextBox.TabIndex = 5;
            this.requestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.requestTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequestTextBox_KeyPress);
            // 
            // readProgressBar
            // 
            this.readProgressBar.Location = new System.Drawing.Point(143, 179);
            this.readProgressBar.Name = "readProgressBar";
            this.readProgressBar.Size = new System.Drawing.Size(487, 23);
            this.readProgressBar.TabIndex = 6;
            // 
            // serialPortCommunicationAndOptionsSplitContainer
            // 
            this.serialPortCommunicationAndOptionsSplitContainer.Location = new System.Drawing.Point(273, 29);
            this.serialPortCommunicationAndOptionsSplitContainer.Name = "serialPortCommunicationAndOptionsSplitContainer";
            // 
            // serialPortCommunicationAndOptionsSplitContainer.Panel1
            // 
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.BackColor = System.Drawing.Color.Silver;
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.Controls.Add(this.readProgressBar);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.Controls.Add(this.requestTextBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.Controls.Add(this.sendButton);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.Controls.Add(this.responseTextBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // serialPortCommunicationAndOptionsSplitContainer.Panel2
            // 
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.BackColor = System.Drawing.Color.Silver;
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.applyButton);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.dataBitsComboBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.stopBitsComboBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.parityComboBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.baudRateComboBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.numbComPortComboBox);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.openCom);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.dataBitsLabel);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.closeCom);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.stopBitsLabel);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.parityLabel);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.baudRateLabel);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Controls.Add(this.portLabel);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.ForeColor = System.Drawing.Color.Black;
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serialPortCommunicationAndOptionsSplitContainer.Size = new System.Drawing.Size(1033, 515);
            this.serialPortCommunicationAndOptionsSplitContainer.SplitterDistance = 794;
            this.serialPortCommunicationAndOptionsSplitContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1306, 557);
            this.Controls.Add(this.inputTableLabel);
            this.Controls.Add(this.inputTypePanel);
            this.Controls.Add(this.serialPortCommunicationLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.buttonsAndDataTypePanel);
            this.Controls.Add(this.serialPortCommunicationAndOptionsSplitContainer);
            this.DataBindings.Add(new System.Windows.Forms.Binding("StartPosition", global::readEXEfile.Properties.Settings.Default, "center", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "Form1";
            this.StartPosition = global::readEXEfile.Properties.Settings.Default.center;
            this.Text = "VRFHost (Факом технолоджиз)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_resizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.buttonsAndDataTypePanel.ResumeLayout(false);
            this.buttonsAndDataTypePanel.PerformLayout();
            this.dataTypePanel.ResumeLayout(false);
            this.dataTypePanel.PerformLayout();
            this.inputTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calibrationTableDataGridView)).EndInit();
            this.numberOfTankPanel.ResumeLayout(false);
            this.numberOfTankPanel.PerformLayout();
            this.countOfStringsPanel.ResumeLayout(false);
            this.countOfStringsPanel.PerformLayout();
            this.unitsOfLengthPanel.ResumeLayout(false);
            this.unitsOfLengthPanel.PerformLayout();
            this.unitsOfVolumePanel.ResumeLayout(false);
            this.unitsOfVolumePanel.PerformLayout();
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.ResumeLayout(false);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel1.PerformLayout();
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.ResumeLayout(false);
            this.serialPortCommunicationAndOptionsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialPortCommunicationAndOptionsSplitContainer)).EndInit();
            this.serialPortCommunicationAndOptionsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel buttonsAndDataTypePanel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label serialPortCommunicationLabel;
        private System.Windows.Forms.Button clearScrinButton;
        private System.Windows.Forms.Label dataTypeLabel;
        private System.Windows.Forms.Panel dataTypePanel;
        private System.Windows.Forms.RadioButton textDataTypeRadioButton;
        private System.Windows.Forms.RadioButton hexDataTypeRadioButton;
        private System.Windows.Forms.Button readComButton;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.Button exeSaveButton;
        private System.Windows.Forms.Panel inputTypePanel;
        private System.Windows.Forms.Label inputTableLabel;
        private System.Windows.Forms.Button tableFromFileButton;
        private System.Windows.Forms.TextBox countOfStringsTextBox;
        private System.Windows.Forms.Label counOfStringsLabel;
        private System.Windows.Forms.Label unitsOfVolumeLabel;
        private System.Windows.Forms.Panel unitsOfVolumePanel;
        private System.Windows.Forms.RadioButton m3UnitsOfVolumeRadioButton;
        private System.Windows.Forms.RadioButton lUnitsOfVolumeRadioButton;
        private System.Windows.Forms.Panel unitsOfLengthPanel;
        private System.Windows.Forms.RadioButton smUnitsOfLengthRadioButton;
        private System.Windows.Forms.Label unitsOfLengthLabel;
        private System.Windows.Forms.RadioButton mmUnitsOfLengthRadioButton;
        private System.Windows.Forms.Panel countOfStringsPanel;
        private System.Windows.Forms.Panel numberOfTankPanel;
        private System.Windows.Forms.Label numberOfTankLabel;
        private System.Windows.Forms.ComboBox numberOfTankComboBox;
        private System.Windows.Forms.DataGridView calibrationTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.Button writeTableInControllerButton;
        private System.Windows.Forms.Button openFilForWriteButton;
        private System.Windows.Forms.OpenFileDialog forWriteInControllerOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog forCreateTableOpenFileDialog;
        private System.Windows.Forms.Button saveTableButton;
        private System.Windows.Forms.SaveFileDialog saveTableFileDialog;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Button closeCom;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Button openCom;
        private System.Windows.Forms.ComboBox numbComPortComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.ProgressBar readProgressBar;
        private System.Windows.Forms.SplitContainer serialPortCommunicationAndOptionsSplitContainer;
    }
}

