namespace PracaInzynierska.Controls
{
    partial class DataJoinControl
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAvarage = new System.Windows.Forms.Button();
            this.btnGenerateCsv = new System.Windows.Forms.Button();
            this.btnSetZeroes = new System.Windows.Forms.Button();
            this.btnAddWeather = new System.Windows.Forms.Button();
            this.flpLocation = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbTurbinNumber = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbParameters = new System.Windows.Forms.ListBox();
            this.flpRadioButtonsColumns = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParameters = new System.Windows.Forms.RadioButton();
            this.rbTurbins = new System.Windows.Forms.RadioButton();
            this.flpRadioButtonsPunctuation = new System.Windows.Forms.FlowLayoutPanel();
            this.rbComma = new System.Windows.Forms.RadioButton();
            this.rbDot = new System.Windows.Forms.RadioButton();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMeasurementResults = new System.Windows.Forms.DataGridView();
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
            this.flpLocation.SuspendLayout();
            this.flpVectors.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flpFilters.SuspendLayout();
            this.flpDates.SuspendLayout();
            this.flpListboxes.SuspendLayout();
            this.flpRadioButtonsColumns.SuspendLayout();
            this.flpRadioButtonsPunctuation.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementResults)).BeginInit();
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
            this.flpFilterButtons.Controls.Add(this.btnLoad);
            this.flpFilterButtons.Controls.Add(this.btnAvarage);
            this.flpFilterButtons.Controls.Add(this.btnGenerateCsv);
            this.flpFilterButtons.Controls.Add(this.btnSetZeroes);
            this.flpFilterButtons.Controls.Add(this.btnAddWeather);
            this.flpFilterButtons.Controls.Add(this.flpLocation);
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
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(159, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 50);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Załaduj plik";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAvarage
            // 
            this.btnAvarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvarage.Location = new System.Drawing.Point(315, 3);
            this.btnAvarage.Name = "btnAvarage";
            this.btnAvarage.Size = new System.Drawing.Size(150, 50);
            this.btnAvarage.TabIndex = 5;
            this.btnAvarage.Text = "Uśrednianie";
            this.btnAvarage.UseVisualStyleBackColor = true;
            this.btnAvarage.Visible = false;
            this.btnAvarage.Click += new System.EventHandler(this.btnAvarage_Click);
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
            // btnSetZeroes
            // 
            this.btnSetZeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetZeroes.Location = new System.Drawing.Point(159, 59);
            this.btnSetZeroes.Name = "btnSetZeroes";
            this.btnSetZeroes.Size = new System.Drawing.Size(150, 50);
            this.btnSetZeroes.TabIndex = 17;
            this.btnSetZeroes.Text = "Zeruj wartości ujemne";
            this.btnSetZeroes.UseVisualStyleBackColor = true;
            this.btnSetZeroes.Visible = false;
            this.btnSetZeroes.Click += new System.EventHandler(this.btnSetZeroes_Click);
            // 
            // btnAddWeather
            // 
            this.btnAddWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWeather.Location = new System.Drawing.Point(315, 59);
            this.btnAddWeather.Name = "btnAddWeather";
            this.btnAddWeather.Size = new System.Drawing.Size(150, 50);
            this.btnAddWeather.TabIndex = 18;
            this.btnAddWeather.Text = "Dodanie pogody";
            this.btnAddWeather.UseVisualStyleBackColor = true;
            this.btnAddWeather.Visible = false;
            this.btnAddWeather.Click += new System.EventHandler(this.btnAddWeather_Click);
            // 
            // flpLocation
            // 
            this.flpLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLocation.AutoSize = true;
            this.flpLocation.Controls.Add(this.label8);
            this.flpLocation.Controls.Add(this.lbPointsLocation);
            this.flpLocation.Controls.Add(this.label5);
            this.flpLocation.Controls.Add(this.flpVectors);
            this.flpLocation.Location = new System.Drawing.Point(3, 115);
            this.flpLocation.Name = "flpLocation";
            this.flpLocation.Size = new System.Drawing.Size(245, 53);
            this.flpLocation.TabIndex = 16;
            this.flpLocation.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 53);
            this.label8.TabIndex = 14;
            this.label8.Text = "Punkty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPointsLocation
            // 
            this.lbPointsLocation.ColumnWidth = 20;
            this.lbPointsLocation.FormattingEnabled = true;
            this.lbPointsLocation.Items.AddRange(new object[] {
            "  1",
            "  2",
            "  3",
            "  4"});
            this.lbPointsLocation.Location = new System.Drawing.Point(48, 2);
            this.lbPointsLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lbPointsLocation.MultiColumn = true;
            this.lbPointsLocation.Name = "lbPointsLocation";
            this.lbPointsLocation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPointsLocation.Size = new System.Drawing.Size(44, 43);
            this.lbPointsLocation.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(97, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 53);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wiatr";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpVectors
            // 
            this.flpVectors.Controls.Add(this.rbAzimuthVector);
            this.flpVectors.Controls.Add(this.rbMeteorologicalWindDirection);
            this.flpVectors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpVectors.Location = new System.Drawing.Point(135, 3);
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
            this.flpFilters.Controls.Add(this.flpListboxes);
            this.flpFilters.Controls.Add(this.flpRadioButtonsColumns);
            this.flpFilters.Controls.Add(this.flpRadioButtonsPunctuation);
            this.flpFilters.Controls.Add(this.btnFiltration);
            this.flpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFilters.Location = new System.Drawing.Point(0, 0);
            this.flpFilters.Name = "flpFilters";
            this.flpFilters.Size = new System.Drawing.Size(599, 116);
            this.flpFilters.TabIndex = 13;
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
            this.flpDates.Size = new System.Drawing.Size(420, 24);
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
            this.cbDateTimeFrom.Visible = false;
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
            this.dtpTimeFrom.CustomFormat = "HH:mm";
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
            this.cbDateTimeTo.Visible = false;
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
            this.dtpTimeTo.CustomFormat = "HH:mm";
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeTo.Location = new System.Drawing.Point(368, 2);
            this.dtpTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(50, 20);
            this.dtpTimeTo.TabIndex = 9;
            this.dtpTimeTo.Value = new System.DateTime(2018, 5, 28, 23, 50, 0, 0);
            // 
            // flpListboxes
            // 
            this.flpListboxes.AutoSize = true;
            this.flpListboxes.Controls.Add(this.label3);
            this.flpListboxes.Controls.Add(this.lbTurbinNumber);
            this.flpListboxes.Controls.Add(this.label4);
            this.flpListboxes.Controls.Add(this.lbParameters);
            this.flpListboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListboxes.Location = new System.Drawing.Point(0, 24);
            this.flpListboxes.Margin = new System.Windows.Forms.Padding(0);
            this.flpListboxes.Name = "flpListboxes";
            this.flpListboxes.Size = new System.Drawing.Size(420, 47);
            this.flpListboxes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "Turbiny";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTurbinNumber
            // 
            this.lbTurbinNumber.ColumnWidth = 20;
            this.lbTurbinNumber.FormattingEnabled = true;
            this.lbTurbinNumber.Items.AddRange(new object[] {
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
            this.lbTurbinNumber.Location = new System.Drawing.Point(50, 2);
            this.lbTurbinNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lbTurbinNumber.MultiColumn = true;
            this.lbTurbinNumber.Name = "lbTurbinNumber";
            this.lbTurbinNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTurbinNumber.Size = new System.Drawing.Size(174, 43);
            this.lbTurbinNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parametry";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbParameters
            // 
            this.lbParameters.ColumnWidth = 20;
            this.lbParameters.FormattingEnabled = true;
            this.lbParameters.Items.AddRange(new object[] {
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
            "  12"});
            this.lbParameters.Location = new System.Drawing.Point(288, 2);
            this.lbParameters.Margin = new System.Windows.Forms.Padding(2);
            this.lbParameters.MultiColumn = true;
            this.lbParameters.Name = "lbParameters";
            this.lbParameters.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbParameters.Size = new System.Drawing.Size(88, 43);
            this.lbParameters.TabIndex = 11;
            // 
            // flpRadioButtonsColumns
            // 
            this.flpRadioButtonsColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRadioButtonsColumns.Controls.Add(this.rbParameters);
            this.flpRadioButtonsColumns.Controls.Add(this.rbTurbins);
            this.flpRadioButtonsColumns.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRadioButtonsColumns.Location = new System.Drawing.Point(423, 3);
            this.flpRadioButtonsColumns.Name = "flpRadioButtonsColumns";
            this.flpRadioButtonsColumns.Size = new System.Drawing.Size(152, 50);
            this.flpRadioButtonsColumns.TabIndex = 15;
            this.flpRadioButtonsColumns.Visible = false;
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
            // rbTurbins
            // 
            this.rbTurbins.AutoSize = true;
            this.rbTurbins.Location = new System.Drawing.Point(3, 26);
            this.rbTurbins.Name = "rbTurbins";
            this.rbTurbins.Size = new System.Drawing.Size(85, 17);
            this.rbTurbins.TabIndex = 4;
            this.rbTurbins.Text = "Po turbinach";
            this.rbTurbins.UseVisualStyleBackColor = true;
            this.rbTurbins.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // flpRadioButtonsPunctuation
            // 
            this.flpRadioButtonsPunctuation.Controls.Add(this.rbComma);
            this.flpRadioButtonsPunctuation.Controls.Add(this.rbDot);
            this.flpRadioButtonsPunctuation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRadioButtonsPunctuation.Location = new System.Drawing.Point(423, 59);
            this.flpRadioButtonsPunctuation.Name = "flpRadioButtonsPunctuation";
            this.flpRadioButtonsPunctuation.Size = new System.Drawing.Size(152, 50);
            this.flpRadioButtonsPunctuation.TabIndex = 16;
            this.flpRadioButtonsPunctuation.Visible = false;
            // 
            // rbComma
            // 
            this.rbComma.AutoSize = true;
            this.rbComma.Checked = true;
            this.rbComma.Location = new System.Drawing.Point(3, 3);
            this.rbComma.Name = "rbComma";
            this.rbComma.Size = new System.Drawing.Size(72, 17);
            this.rbComma.TabIndex = 4;
            this.rbComma.TabStop = true;
            this.rbComma.Text = "Przecinek";
            this.rbComma.UseVisualStyleBackColor = true;
            // 
            // rbDot
            // 
            this.rbDot.AutoSize = true;
            this.rbDot.Location = new System.Drawing.Point(3, 26);
            this.rbDot.Name = "rbDot";
            this.rbDot.Size = new System.Drawing.Size(59, 17);
            this.rbDot.TabIndex = 5;
            this.rbDot.Text = "Kropka";
            this.rbDot.UseVisualStyleBackColor = true;
            // 
            // btnFiltration
            // 
            this.btnFiltration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltration.Location = new System.Drawing.Point(581, 3);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(150, 50);
            this.btnFiltration.TabIndex = 3;
            this.btnFiltration.Text = "Filtruj";
            this.btnFiltration.UseVisualStyleBackColor = true;
            this.btnFiltration.Visible = false;
            this.btnFiltration.Click += new System.EventHandler(this.btnFiltration_Click);
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
            this.panel2.Controls.Add(this.dgvMeasurementResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 642);
            this.panel2.TabIndex = 1;
            // 
            // dgvMeasurementResults
            // 
            this.dgvMeasurementResults.AllowUserToAddRows = false;
            this.dgvMeasurementResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMeasurementResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasurementResults.Location = new System.Drawing.Point(0, 0);
            this.dgvMeasurementResults.MinimumSize = new System.Drawing.Size(900, 680);
            this.dgvMeasurementResults.Name = "dgvMeasurementResults";
            this.dgvMeasurementResults.Size = new System.Drawing.Size(1205, 680);
            this.dgvMeasurementResults.TabIndex = 0;
            // 
            // DataJoinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLoadCsv);
            this.Name = "DataJoinControl";
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
            this.flpFilterButtons.PerformLayout();
            this.flpLocation.ResumeLayout(false);
            this.flpLocation.PerformLayout();
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
            this.flpRadioButtonsColumns.ResumeLayout(false);
            this.flpRadioButtonsColumns.PerformLayout();
            this.flpRadioButtonsPunctuation.ResumeLayout(false);
            this.flpRadioButtonsPunctuation.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementResults)).EndInit();
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
        private System.Windows.Forms.Button btnLoad;
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
        private System.Windows.Forms.ListBox lbTurbinNumber;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMeasurementResults;
        private System.Windows.Forms.Button btnAvarage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbParameters;
        private System.Windows.Forms.RadioButton rbTurbins;
        private System.Windows.Forms.RadioButton rbParameters;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.Button btnSetZeroes;
        private System.Windows.Forms.Button btnAddWeather;
        private System.Windows.Forms.FlowLayoutPanel flpRadioButtonsColumns;
        private System.Windows.Forms.FlowLayoutPanel flpLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbPointsLocation;
        private System.Windows.Forms.FlowLayoutPanel flpRadioButtonsPunctuation;
        private System.Windows.Forms.RadioButton rbComma;
        private System.Windows.Forms.RadioButton rbDot;
        private System.Windows.Forms.FlowLayoutPanel flpVectors;
        private System.Windows.Forms.RadioButton rbAzimuthVector;
        private System.Windows.Forms.RadioButton rbMeteorologicalWindDirection;
        private System.Windows.Forms.Label label5;
    }
}
