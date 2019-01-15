namespace PracaInzynierska.Controls
{
    partial class WeatherControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();
            this.fbdCsv = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.pnLoadCsv = new System.Windows.Forms.Panel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFilterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.pnFolderPath = new System.Windows.Forms.Panel();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadWeather = new System.Windows.Forms.Button();
            this.btnGenerateCsv = new System.Windows.Forms.Button();
            this.pnLoadButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPointsLocation = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flpVectors = new System.Windows.Forms.FlowLayoutPanel();
            this.rbAzimuthVector = new System.Windows.Forms.RadioButton();
            this.rbMeteorologicalWindDirection = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDates = new System.Windows.Forms.FlowLayoutPanel();
            this.cbDateTimeFrom = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.cbDateTimeTo = new System.Windows.Forms.CheckBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.flpListboxes = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLocation = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flpTime = new System.Windows.Forms.FlowLayoutPanel();
            this.rbUtcTime = new System.Windows.Forms.RadioButton();
            this.rbLocalTime = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label8 = new System.Windows.Forms.Label();
            this.flpRadioButtonsColumns = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParameters = new System.Windows.Forms.RadioButton();
            this.rbLocalization = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nudVco = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudVr = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudVci = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudPr = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudHx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbSpeedAndPower = new System.Windows.Forms.CheckBox();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvWeatherResults = new System.Windows.Forms.DataGridView();
            this.pnLoadCsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpFilterButtons.SuspendLayout();
            this.pnFolderPath.SuspendLayout();
            this.pnLoadButtons.SuspendLayout();
            this.flpVectors.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flpFilters.SuspendLayout();
            this.flpDates.SuspendLayout();
            this.flpListboxes.SuspendLayout();
            this.flpLocation.SuspendLayout();
            this.flpTime.SuspendLayout();
            this.flpRadioButtonsColumns.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHx)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherResults)).BeginInit();
            this.SuspendLayout();
            // 
            // sfdCsv
            // 
            this.sfdCsv.Filter = "Plik csv|*.csv";
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "Plik csv";
            this.ofdCsv.Filter = "Xlsx|*.xlsx|Csv|*.csv";
            // 
            // pnLoadCsv
            // 
            this.pnLoadCsv.AutoSize = true;
            this.pnLoadCsv.Controls.Add(this.scMain);
            this.pnLoadCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoadCsv.Location = new System.Drawing.Point(0, 0);
            this.pnLoadCsv.Name = "pnLoadCsv";
            this.pnLoadCsv.Size = new System.Drawing.Size(1205, 793);
            this.pnLoadCsv.TabIndex = 1;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.panel1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.panel2);
            this.scMain.Size = new System.Drawing.Size(1205, 793);
            this.scMain.SplitterDistance = 150;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 150);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MaximumSize = new System.Drawing.Size(0, 200);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 150);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 144);
            this.panel3.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpFilterButtons);
            this.splitContainer2.Size = new System.Drawing.Size(595, 142);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przyciski";
            // 
            // flpFilterButtons
            // 
            this.flpFilterButtons.AutoSize = true;
            this.flpFilterButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpFilterButtons.Controls.Add(this.btnLoadFolder);
            this.flpFilterButtons.Controls.Add(this.pnFolderPath);
            this.flpFilterButtons.Controls.Add(this.btnLoadWeather);
            this.flpFilterButtons.Controls.Add(this.btnGenerateCsv);
            this.flpFilterButtons.Controls.Add(this.pnLoadButtons);
            this.flpFilterButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilterButtons.Location = new System.Drawing.Point(0, 0);
            this.flpFilterButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpFilterButtons.Name = "flpFilterButtons";
            this.flpFilterButtons.Size = new System.Drawing.Size(595, 116);
            this.flpFilterButtons.TabIndex = 0;
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFolder.Location = new System.Drawing.Point(3, 3);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(150, 50);
            this.btnLoadFolder.TabIndex = 3;
            this.btnLoadFolder.Text = "Załaduj folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // pnFolderPath
            // 
            this.pnFolderPath.Controls.Add(this.tbFolderPath);
            this.pnFolderPath.Controls.Add(this.label6);
            this.pnFolderPath.Location = new System.Drawing.Point(159, 3);
            this.pnFolderPath.Name = "pnFolderPath";
            this.pnFolderPath.Size = new System.Drawing.Size(150, 50);
            this.pnFolderPath.TabIndex = 21;
            this.pnFolderPath.Visible = false;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(9, 21);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(128, 20);
            this.tbFolderPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ścieżka do folderu";
            // 
            // btnLoadWeather
            // 
            this.btnLoadWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadWeather.Location = new System.Drawing.Point(315, 3);
            this.btnLoadWeather.Name = "btnLoadWeather";
            this.btnLoadWeather.Size = new System.Drawing.Size(150, 50);
            this.btnLoadWeather.TabIndex = 2;
            this.btnLoadWeather.Text = "Załaduj pogodę";
            this.btnLoadWeather.UseVisualStyleBackColor = true;
            this.btnLoadWeather.Visible = false;
            this.btnLoadWeather.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGenerateCsv
            // 
            this.btnGenerateCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCsv.Location = new System.Drawing.Point(3, 59);
            this.btnGenerateCsv.Name = "btnGenerateCsv";
            this.btnGenerateCsv.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateCsv.TabIndex = 4;
            this.btnGenerateCsv.Text = "Generuj CSV";
            this.btnGenerateCsv.UseVisualStyleBackColor = true;
            this.btnGenerateCsv.Visible = false;
            this.btnGenerateCsv.Click += new System.EventHandler(this.btnGenerateCsv_Click);
            // 
            // pnLoadButtons
            // 
            this.pnLoadButtons.Controls.Add(this.label3);
            this.pnLoadButtons.Controls.Add(this.lbPointsLocation);
            this.pnLoadButtons.Controls.Add(this.label5);
            this.pnLoadButtons.Controls.Add(this.flpVectors);
            this.pnLoadButtons.Location = new System.Drawing.Point(159, 59);
            this.pnLoadButtons.Name = "pnLoadButtons";
            this.pnLoadButtons.Size = new System.Drawing.Size(396, 50);
            this.pnLoadButtons.TabIndex = 22;
            this.pnLoadButtons.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lokalizacje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPointsLocation
            // 
            this.lbPointsLocation.ColumnWidth = 20;
            this.lbPointsLocation.FormattingEnabled = true;
            this.lbPointsLocation.Items.AddRange(new object[] {
            "  1",
            "  2",
            "  3",
            "  4",
            "  5",
            "  6",
            "  7",
            "  8",
            "  9",
            "  10",
            "  11",
            "  12",
            "  13",
            "  14",
            "  15",
            "  16",
            "  17",
            "  18",
            "  19",
            "  20",
            "  21",
            "  22",
            "  23",
            "  24"});
            this.lbPointsLocation.Location = new System.Drawing.Point(71, 5);
            this.lbPointsLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lbPointsLocation.MultiColumn = true;
            this.lbPointsLocation.Name = "lbPointsLocation";
            this.lbPointsLocation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPointsLocation.Size = new System.Drawing.Size(174, 43);
            this.lbPointsLocation.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wiatr";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpVectors
            // 
            this.flpVectors.Controls.Add(this.rbAzimuthVector);
            this.flpVectors.Controls.Add(this.rbMeteorologicalWindDirection);
            this.flpVectors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpVectors.Location = new System.Drawing.Point(283, 1);
            this.flpVectors.Name = "flpVectors";
            this.flpVectors.Size = new System.Drawing.Size(107, 47);
            this.flpVectors.TabIndex = 16;
            // 
            // rbAzimuthVector
            // 
            this.rbAzimuthVector.AutoSize = true;
            this.rbAzimuthVector.Checked = true;
            this.rbAzimuthVector.Location = new System.Drawing.Point(3, 3);
            this.rbAzimuthVector.Name = "rbAzimuthVector";
            this.rbAzimuthVector.Size = new System.Drawing.Size(78, 17);
            this.rbAzimuthVector.TabIndex = 5;
            this.rbAzimuthVector.TabStop = true;
            this.rbAzimuthVector.Text = "Azymutowy";
            this.rbAzimuthVector.UseVisualStyleBackColor = true;
            // 
            // rbMeteorologicalWindDirection
            // 
            this.rbMeteorologicalWindDirection.AutoSize = true;
            this.rbMeteorologicalWindDirection.Location = new System.Drawing.Point(3, 26);
            this.rbMeteorologicalWindDirection.Name = "rbMeteorologicalWindDirection";
            this.rbMeteorologicalWindDirection.Size = new System.Drawing.Size(102, 17);
            this.rbMeteorologicalWindDirection.TabIndex = 4;
            this.rbMeteorologicalWindDirection.Text = "Meteorologiczny";
            this.rbMeteorologicalWindDirection.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.splitContainer3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 144);
            this.panel5.TabIndex = 15;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flpFilters);
            this.splitContainer3.Size = new System.Drawing.Size(599, 142);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtry";
            // 
            // flpFilters
            // 
            this.flpFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpFilters.Controls.Add(this.flpDates);
            this.flpFilters.Controls.Add(this.panel6);
            this.flpFilters.Controls.Add(this.flpListboxes);
            this.flpFilters.Controls.Add(this.btnFiltration);
            this.flpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFilters.Location = new System.Drawing.Point(0, 0);
            this.flpFilters.Name = "flpFilters";
            this.flpFilters.Size = new System.Drawing.Size(599, 116);
            this.flpFilters.TabIndex = 13;
            this.flpFilters.Visible = false;
            // 
            // flpDates
            // 
            this.flpDates.AutoSize = true;
            this.flpDates.Controls.Add(this.cbDateTimeFrom);
            this.flpDates.Controls.Add(this.dtpDateFrom);
            this.flpDates.Controls.Add(this.dtpTimeFrom);
            this.flpDates.Controls.Add(this.cbDateTimeTo);
            this.flpDates.Controls.Add(this.dtpDateTo);
            this.flpDates.Controls.Add(this.dtpTimeTo);
            this.flpDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDates.Location = new System.Drawing.Point(0, 0);
            this.flpDates.Margin = new System.Windows.Forms.Padding(0);
            this.flpDates.Name = "flpDates";
            this.flpDates.Size = new System.Drawing.Size(524, 24);
            this.flpDates.TabIndex = 0;
            // 
            // cbDateTimeFrom
            // 
            this.cbDateTimeFrom.Location = new System.Drawing.Point(2, 2);
            this.cbDateTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cbDateTimeFrom.Name = "cbDateTimeFrom";
            this.cbDateTimeFrom.Size = new System.Drawing.Size(64, 17);
            this.cbDateTimeFrom.TabIndex = 0;
            this.cbDateTimeFrom.Text = "Data od";
            this.cbDateTimeFrom.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(70, 2);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(84, 20);
            this.dtpDateFrom.TabIndex = 6;
            this.dtpDateFrom.Value = new System.DateTime(2012, 3, 17, 0, 10, 0, 0);
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.CustomFormat = "HH";
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeFrom.Location = new System.Drawing.Point(158, 2);
            this.dtpTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(50, 20);
            this.dtpTimeFrom.TabIndex = 7;
            this.dtpTimeFrom.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // cbDateTimeTo
            // 
            this.cbDateTimeTo.Location = new System.Drawing.Point(212, 2);
            this.cbDateTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.cbDateTimeTo.Name = "cbDateTimeTo";
            this.cbDateTimeTo.Size = new System.Drawing.Size(64, 17);
            this.cbDateTimeTo.TabIndex = 12;
            this.cbDateTimeTo.Text = "Data do";
            this.cbDateTimeTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(280, 2);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(84, 20);
            this.dtpDateTo.TabIndex = 8;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.CustomFormat = "HH";
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeTo.Location = new System.Drawing.Point(368, 2);
            this.dtpTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(50, 20);
            this.dtpTimeTo.TabIndex = 9;
            this.dtpTimeTo.Value = new System.DateTime(2018, 5, 28, 23, 0, 0, 0);
            // 
            // flpListboxes
            // 
            this.flpListboxes.AutoSize = true;
            this.flpListboxes.Controls.Add(this.flpLocation);
            this.flpListboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListboxes.Location = new System.Drawing.Point(524, 0);
            this.flpListboxes.Margin = new System.Windows.Forms.Padding(0);
            this.flpListboxes.Name = "flpListboxes";
            this.flpListboxes.Size = new System.Drawing.Size(119, 81);
            this.flpListboxes.TabIndex = 1;
            // 
            // flpLocation
            // 
            this.flpLocation.AutoSize = true;
            this.flpLocation.Controls.Add(this.label4);
            this.flpLocation.Controls.Add(this.flpTime);
            this.flpLocation.Controls.Add(this.splitter1);
            this.flpLocation.Controls.Add(this.label8);
            this.flpLocation.Controls.Add(this.flpRadioButtonsColumns);
            this.flpLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLocation.Location = new System.Drawing.Point(3, 3);
            this.flpLocation.Name = "flpLocation";
            this.flpLocation.Size = new System.Drawing.Size(113, 75);
            this.flpLocation.TabIndex = 16;
            this.flpLocation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 56);
            this.label4.TabIndex = 18;
            this.label4.Text = "Czas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpTime
            // 
            this.flpTime.Controls.Add(this.rbUtcTime);
            this.flpTime.Controls.Add(this.rbLocalTime);
            this.flpTime.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTime.Location = new System.Drawing.Point(39, 3);
            this.flpTime.Name = "flpTime";
            this.flpTime.Size = new System.Drawing.Size(67, 50);
            this.flpTime.TabIndex = 19;
            // 
            // rbUtcTime
            // 
            this.rbUtcTime.AutoSize = true;
            this.rbUtcTime.Checked = true;
            this.rbUtcTime.Location = new System.Drawing.Point(3, 3);
            this.rbUtcTime.Name = "rbUtcTime";
            this.rbUtcTime.Size = new System.Drawing.Size(42, 17);
            this.rbUtcTime.TabIndex = 5;
            this.rbUtcTime.TabStop = true;
            this.rbUtcTime.Text = "Utc";
            this.rbUtcTime.UseVisualStyleBackColor = true;
            this.rbUtcTime.CheckedChanged += new System.EventHandler(this.rbUtcTime_CheckedChanged);
            // 
            // rbLocalTime
            // 
            this.rbLocalTime.AutoSize = true;
            this.rbLocalTime.Location = new System.Drawing.Point(3, 26);
            this.rbLocalTime.Name = "rbLocalTime";
            this.rbLocalTime.Size = new System.Drawing.Size(62, 17);
            this.rbLocalTime.TabIndex = 4;
            this.rbLocalTime.Text = "Lokalny";
            this.rbLocalTime.UseVisualStyleBackColor = true;
            this.rbLocalTime.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.CausesValidation = false;
            this.splitter1.Location = new System.Drawing.Point(3, 59);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 7);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(10, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Układ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpRadioButtonsColumns
            // 
            this.flpRadioButtonsColumns.Controls.Add(this.rbParameters);
            this.flpRadioButtonsColumns.Controls.Add(this.rbLocalization);
            this.flpRadioButtonsColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRadioButtonsColumns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRadioButtonsColumns.Location = new System.Drawing.Point(3, 72);
            this.flpRadioButtonsColumns.Name = "flpRadioButtonsColumns";
            this.flpRadioButtonsColumns.Size = new System.Drawing.Size(107, 0);
            this.flpRadioButtonsColumns.TabIndex = 15;
            // 
            // rbParameters
            // 
            this.rbParameters.AutoSize = true;
            this.rbParameters.Checked = true;
            this.rbParameters.Location = new System.Drawing.Point(3, 3);
            this.rbParameters.Name = "rbParameters";
            this.rbParameters.Size = new System.Drawing.Size(100, 17);
            this.rbParameters.TabIndex = 5;
            this.rbParameters.TabStop = true;
            this.rbParameters.Text = "Po parametrach";
            this.rbParameters.UseVisualStyleBackColor = true;
            this.rbParameters.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbLocalization
            // 
            this.rbLocalization.AutoSize = true;
            this.rbLocalization.Location = new System.Drawing.Point(109, 3);
            this.rbLocalization.Name = "rbLocalization";
            this.rbLocalization.Size = new System.Drawing.Size(102, 17);
            this.rbLocalization.TabIndex = 4;
            this.rbLocalization.Text = "Po lokalizacjach";
            this.rbLocalization.UseVisualStyleBackColor = true;
            this.rbLocalization.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nudVco);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.nudVr);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.nudVci);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.nudPr);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.nudAlpha);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.nudHx);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(518, 52);
            this.panel6.TabIndex = 23;
            // 
            // nudVco
            // 
            this.nudVco.Location = new System.Drawing.Point(461, 21);
            this.nudVco.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVco.Name = "nudVco";
            this.nudVco.Size = new System.Drawing.Size(54, 20);
            this.nudVco.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Vco";
            // 
            // nudVr
            // 
            this.nudVr.Location = new System.Drawing.Point(402, 21);
            this.nudVr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVr.Name = "nudVr";
            this.nudVr.Size = new System.Drawing.Size(54, 20);
            this.nudVr.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Vr";
            // 
            // nudVci
            // 
            this.nudVci.Location = new System.Drawing.Point(342, 21);
            this.nudVci.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVci.Name = "nudVci";
            this.nudVci.Size = new System.Drawing.Size(54, 20);
            this.nudVci.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Vci";
            // 
            // nudPr
            // 
            this.nudPr.Location = new System.Drawing.Point(283, 21);
            this.nudPr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPr.Name = "nudPr";
            this.nudPr.Size = new System.Drawing.Size(54, 20);
            this.nudPr.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Pr";
            // 
            // nudAlpha
            // 
            this.nudAlpha.Location = new System.Drawing.Point(225, 21);
            this.nudAlpha.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(54, 20);
            this.nudAlpha.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Alpha";
            // 
            // nudHx
            // 
            this.nudHx.Location = new System.Drawing.Point(165, 21);
            this.nudHx.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudHx.Name = "nudHx";
            this.nudHx.Size = new System.Drawing.Size(54, 20);
            this.nudHx.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hx";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbSpeedAndPower);
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 45);
            this.panel7.TabIndex = 2;
            // 
            // cbSpeedAndPower
            // 
            this.cbSpeedAndPower.AutoSize = true;
            this.cbSpeedAndPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpeedAndPower.Location = new System.Drawing.Point(0, 0);
            this.cbSpeedAndPower.Name = "cbSpeedAndPower";
            this.cbSpeedAndPower.Size = new System.Drawing.Size(146, 45);
            this.cbSpeedAndPower.TabIndex = 1;
            this.cbSpeedAndPower.Text = "Prędkość oraz moc w zależności od wysokości";
            this.cbSpeedAndPower.UseVisualStyleBackColor = true;
            // 
            // btnFiltration
            // 
            this.btnFiltration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltration.Location = new System.Drawing.Point(646, 3);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(150, 50);
            this.btnFiltration.TabIndex = 3;
            this.btnFiltration.Text = "Filtruj";
            this.btnFiltration.UseVisualStyleBackColor = true;
            this.btnFiltration.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.MaximumSize = new System.Drawing.Size(2, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 144);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dgvWeatherResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 642);
            this.panel2.TabIndex = 1;
            // 
            // dgvWeatherResults
            // 
            this.dgvWeatherResults.AllowUserToAddRows = false;
            this.dgvWeatherResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWeatherResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeatherResults.Location = new System.Drawing.Point(0, 0);
            this.dgvWeatherResults.MinimumSize = new System.Drawing.Size(900, 680);
            this.dgvWeatherResults.Name = "dgvWeatherResults";
            this.dgvWeatherResults.Size = new System.Drawing.Size(1205, 680);
            this.dgvWeatherResults.TabIndex = 0;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLoadCsv);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(1205, 793);
            this.pnLoadCsv.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpFilterButtons.ResumeLayout(false);
            this.pnFolderPath.ResumeLayout(false);
            this.pnFolderPath.PerformLayout();
            this.pnLoadButtons.ResumeLayout(false);
            this.pnLoadButtons.PerformLayout();
            this.flpVectors.ResumeLayout(false);
            this.flpVectors.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flpFilters.ResumeLayout(false);
            this.flpFilters.PerformLayout();
            this.flpDates.ResumeLayout(false);
            this.flpListboxes.ResumeLayout(false);
            this.flpListboxes.PerformLayout();
            this.flpLocation.ResumeLayout(false);
            this.flpLocation.PerformLayout();
            this.flpTime.ResumeLayout(false);
            this.flpTime.PerformLayout();
            this.flpRadioButtonsColumns.ResumeLayout(false);
            this.flpRadioButtonsColumns.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHx)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sfdCsv;
        private System.Windows.Forms.FolderBrowserDialog fbdCsv;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.Panel pnLoadCsv;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFilterButtons;
        private System.Windows.Forms.Button btnLoadWeather;
        private System.Windows.Forms.Button btnGenerateCsv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpFilters;
        private System.Windows.Forms.FlowLayoutPanel flpDates;
        private System.Windows.Forms.CheckBox cbDateTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.CheckBox cbDateTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.FlowLayoutPanel flpListboxes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPointsLocation;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvWeatherResults;
        private System.Windows.Forms.RadioButton rbLocalization;
        private System.Windows.Forms.RadioButton rbParameters;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.FlowLayoutPanel flpRadioButtonsColumns;
        private System.Windows.Forms.FlowLayoutPanel flpLocation;
        private System.Windows.Forms.FlowLayoutPanel flpVectors;
        private System.Windows.Forms.RadioButton rbAzimuthVector;
        private System.Windows.Forms.RadioButton rbMeteorologicalWindDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnFolderPath;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpTime;
        private System.Windows.Forms.RadioButton rbUtcTime;
        private System.Windows.Forms.RadioButton rbLocalTime;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnLoadButtons;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbSpeedAndPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudHx;
        private System.Windows.Forms.NumericUpDown nudVco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudVr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudVci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudPr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.Label label9;
    }
}
