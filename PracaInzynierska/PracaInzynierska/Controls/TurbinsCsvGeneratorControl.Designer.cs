namespace PracaInzynierska.Controls
{
    partial class TurbinsCsvGeneratorControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnLoadCsv = new System.Windows.Forms.Panel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFilterButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nmTrubin = new System.Windows.Forms.NumericUpDown();
            this.btnSearchMissingRows = new System.Windows.Forms.Button();
            this.btnSearchEmptyRows = new System.Windows.Forms.Button();
            this.btnSearchTheSameValues = new System.Windows.Forms.Button();
            this.pnFolderPath = new System.Windows.Forms.Panel();
            this.tbTempFolderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateCsv = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMeasurementResults = new System.Windows.Forms.DataGridView();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();
            this.fbdCsv = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pustyWierszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTrubin)).BeginInit();
            this.pnFolderPath.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLoadCsv
            // 
            this.pnLoadCsv.AutoSize = true;
            this.pnLoadCsv.Controls.Add(this.scMain);
            this.pnLoadCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoadCsv.Location = new System.Drawing.Point(0, 0);
            this.pnLoadCsv.Name = "pnLoadCsv";
            this.pnLoadCsv.Size = new System.Drawing.Size(1205, 793);
            this.pnLoadCsv.TabIndex = 0;
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
            this.flpFilterButtons.Controls.Add(this.btnLoadFile);
            this.flpFilterButtons.Controls.Add(this.panel6);
            this.flpFilterButtons.Controls.Add(this.btnSearchMissingRows);
            this.flpFilterButtons.Controls.Add(this.btnSearchEmptyRows);
            this.flpFilterButtons.Controls.Add(this.btnSearchTheSameValues);
            this.flpFilterButtons.Controls.Add(this.pnFolderPath);
            this.flpFilterButtons.Controls.Add(this.btnGenerateCsv);
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
            this.btnLoadFolder.TabIndex = 2;
            this.btnLoadFolder.Text = "Załaduj folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Location = new System.Drawing.Point(159, 3);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(150, 50);
            this.btnLoadFile.TabIndex = 15;
            this.btnLoadFile.Text = "Załaduj plik";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.nmTrubin);
            this.panel6.Location = new System.Drawing.Point(315, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(56, 50);
            this.panel6.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Turbina";
            // 
            // nmTrubin
            // 
            this.nmTrubin.Location = new System.Drawing.Point(6, 21);
            this.nmTrubin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTrubin.Name = "nmTrubin";
            this.nmTrubin.Size = new System.Drawing.Size(44, 20);
            this.nmTrubin.TabIndex = 17;
            this.nmTrubin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSearchMissingRows
            // 
            this.btnSearchMissingRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMissingRows.Location = new System.Drawing.Point(377, 3);
            this.btnSearchMissingRows.Name = "btnSearchMissingRows";
            this.btnSearchMissingRows.Size = new System.Drawing.Size(150, 50);
            this.btnSearchMissingRows.TabIndex = 10;
            this.btnSearchMissingRows.Text = "Szukaj brakujących wierszy";
            this.btnSearchMissingRows.UseVisualStyleBackColor = true;
            this.btnSearchMissingRows.Visible = false;
            this.btnSearchMissingRows.Click += new System.EventHandler(this.btnSearchMissingRows_Click);
            // 
            // btnSearchEmptyRows
            // 
            this.btnSearchEmptyRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmptyRows.Location = new System.Drawing.Point(3, 59);
            this.btnSearchEmptyRows.Name = "btnSearchEmptyRows";
            this.btnSearchEmptyRows.Size = new System.Drawing.Size(150, 50);
            this.btnSearchEmptyRows.TabIndex = 3;
            this.btnSearchEmptyRows.Text = "Szukaj pustych wierszy";
            this.btnSearchEmptyRows.UseVisualStyleBackColor = true;
            this.btnSearchEmptyRows.Visible = false;
            this.btnSearchEmptyRows.Click += new System.EventHandler(this.btnSearchEmptyRows_Click);
            // 
            // btnSearchTheSameValues
            // 
            this.btnSearchTheSameValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTheSameValues.Location = new System.Drawing.Point(159, 59);
            this.btnSearchTheSameValues.Name = "btnSearchTheSameValues";
            this.btnSearchTheSameValues.Size = new System.Drawing.Size(150, 50);
            this.btnSearchTheSameValues.TabIndex = 13;
            this.btnSearchTheSameValues.Text = "Szukaj wierszy z takimi samymi wartościami";
            this.btnSearchTheSameValues.UseVisualStyleBackColor = true;
            this.btnSearchTheSameValues.Visible = false;
            this.btnSearchTheSameValues.Click += new System.EventHandler(this.btnSearchTheSameValues_Click);
            // 
            // pnFolderPath
            // 
            this.pnFolderPath.Controls.Add(this.tbTempFolderPath);
            this.pnFolderPath.Controls.Add(this.label3);
            this.pnFolderPath.Location = new System.Drawing.Point(315, 59);
            this.pnFolderPath.Name = "pnFolderPath";
            this.pnFolderPath.Size = new System.Drawing.Size(150, 50);
            this.pnFolderPath.TabIndex = 20;
            this.pnFolderPath.Visible = false;
            // 
            // tbTempFolderPath
            // 
            this.tbTempFolderPath.Location = new System.Drawing.Point(9, 21);
            this.tbTempFolderPath.Name = "tbTempFolderPath";
            this.tbTempFolderPath.Size = new System.Drawing.Size(128, 20);
            this.tbTempFolderPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ścieżka do zapisu";
            // 
            // btnGenerateCsv
            // 
            this.btnGenerateCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCsv.Location = new System.Drawing.Point(3, 115);
            this.btnGenerateCsv.Name = "btnGenerateCsv";
            this.btnGenerateCsv.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateCsv.TabIndex = 4;
            this.btnGenerateCsv.Text = "Generuj CSV";
            this.btnGenerateCsv.UseVisualStyleBackColor = true;
            this.btnGenerateCsv.Visible = false;
            this.btnGenerateCsv.Click += new System.EventHandler(this.btnGenerateCsv_Click);
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
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel3);
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
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.btnGoTo);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(599, 116);
            this.flowLayoutPanel3.TabIndex = 13;
            this.flowLayoutPanel3.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.cbDate);
            this.flowLayoutPanel1.Controls.Add(this.dtpDate);
            this.flowLayoutPanel1.Controls.Add(this.dtpTime);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbDate
            // 
            this.cbDate.Location = new System.Drawing.Point(2, 2);
            this.cbDate.Margin = new System.Windows.Forms.Padding(2);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(64, 17);
            this.cbDate.TabIndex = 0;
            this.cbDate.Text = "Data";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(70, 2);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(84, 20);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2012, 3, 17, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(158, 2);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(50, 20);
            this.dtpTime.TabIndex = 7;
            this.dtpTime.Value = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // btnGoTo
            // 
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Location = new System.Drawing.Point(3, 27);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(150, 50);
            this.btnGoTo.TabIndex = 4;
            this.btnGoTo.Text = "Znajdź";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasurementResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeasurementResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasurementResults.Location = new System.Drawing.Point(0, 0);
            this.dgvMeasurementResults.MinimumSize = new System.Drawing.Size(900, 680);
            this.dgvMeasurementResults.Name = "dgvMeasurementResults";
            this.dgvMeasurementResults.Size = new System.Drawing.Size(1205, 680);
            this.dgvMeasurementResults.TabIndex = 0;
            this.dgvMeasurementResults.DataSourceChanged += new System.EventHandler(this.dgvMeasurementResults_DataSourceChanged);
            this.dgvMeasurementResults.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMeasurementResults_CellMouseUp);
            this.dgvMeasurementResults.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeasurementResults_CellValueChanged);
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "Plik csv";
            this.ofdCsv.Filter = "Xlsx|*.xlsx|Csv|*.csv";
            // 
            // sfdCsv
            // 
            this.sfdCsv.Filter = "Plik csv|*.csv";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pustyWierszToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // pustyWierszToolStripMenuItem
            // 
            this.pustyWierszToolStripMenuItem.Name = "pustyWierszToolStripMenuItem";
            this.pustyWierszToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pustyWierszToolStripMenuItem.Text = "Pusty wiersz";
            this.pustyWierszToolStripMenuItem.Click += new System.EventHandler(this.pustyWierszToolStripMenuItem_Click);
            // 
            // TurbinsCsvGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLoadCsv);
            this.Name = "TurbinsCsvGeneratorControl";
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTrubin)).EndInit();
            this.pnFolderPath.ResumeLayout(false);
            this.pnFolderPath.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLoadCsv;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMeasurementResults;
        private System.Windows.Forms.FlowLayoutPanel flpFilterButtons;
        private System.Windows.Forms.Button btnSearchEmptyRows;
        private System.Windows.Forms.Button btnGenerateCsv;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
        private System.Windows.Forms.FolderBrowserDialog fbdCsv;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSearchMissingRows;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Button btnSearchTheSameValues;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pustyWierszToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmTrubin;
        private System.Windows.Forms.Panel pnFolderPath;
        private System.Windows.Forms.TextBox tbTempFolderPath;
        private System.Windows.Forms.Label label3;
    }
}
