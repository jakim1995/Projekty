namespace PracaInzynierska
{
    partial class MenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnForms = new System.Windows.Forms.Panel();
            this.pnMenuLeft = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.cbDataJoinControl = new System.Windows.Forms.CheckBox();
            this.cbTurbinsCsvGeneratorControl = new System.Windows.Forms.CheckBox();
            this.cbWeatherControl = new System.Windows.Forms.CheckBox();
            this.btnCsvContoller = new System.Windows.Forms.Button();
            this.btnModificationsControl = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btmMinimalize = new System.Windows.Forms.Button();
            this.btnMaxWindow = new System.Windows.Forms.Button();
            this.btnMinWindow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.pnMenuLeft.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoSize = true;
            this.pnMenu.Controls.Add(this.pnForms);
            this.pnMenu.Controls.Add(this.pnMenuLeft);
            this.pnMenu.Controls.Add(this.pnTop);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1200, 798);
            this.pnMenu.TabIndex = 0;
            // 
            // pnForms
            // 
            this.pnForms.AutoSize = true;
            this.pnForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForms.Location = new System.Drawing.Point(106, 20);
            this.pnForms.Margin = new System.Windows.Forms.Padding(0);
            this.pnForms.Name = "pnForms";
            this.pnForms.Size = new System.Drawing.Size(1094, 778);
            this.pnForms.TabIndex = 2;
            // 
            // pnMenuLeft
            // 
            this.pnMenuLeft.AutoSize = true;
            this.pnMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.pnMenuLeft.Controls.Add(this.flpButtons);
            this.pnMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLeft.Location = new System.Drawing.Point(0, 20);
            this.pnMenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuLeft.Name = "pnMenuLeft";
            this.pnMenuLeft.Size = new System.Drawing.Size(106, 778);
            this.pnMenuLeft.TabIndex = 0;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoSize = true;
            this.flpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.flpButtons.Controls.Add(this.cbTurbinsCsvGeneratorControl);
            this.flpButtons.Controls.Add(this.cbDataJoinControl);
            this.flpButtons.Controls.Add(this.cbWeatherControl);
            this.flpButtons.Controls.Add(this.btnCsvContoller);
            this.flpButtons.Controls.Add(this.btnModificationsControl);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpButtons.ForeColor = System.Drawing.Color.White;
            this.flpButtons.Location = new System.Drawing.Point(0, 0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(106, 778);
            this.flpButtons.TabIndex = 0;
            // 
            // cbDataJoinControl
            // 
            this.cbDataJoinControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDataJoinControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDataJoinControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataJoinControl.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbDataJoinControl.Location = new System.Drawing.Point(3, 309);
            this.cbDataJoinControl.Name = "cbDataJoinControl";
            this.cbDataJoinControl.Size = new System.Drawing.Size(100, 300);
            this.cbDataJoinControl.TabIndex = 5;
            this.cbDataJoinControl.Text = "Etap 2";
            this.cbDataJoinControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDataJoinControl.UseVisualStyleBackColor = true;
            this.cbDataJoinControl.CheckedChanged += new System.EventHandler(this.cbDataJoinControl_CheckedChanged);
            // 
            // cbTurbinsCsvGeneratorControl
            // 
            this.cbTurbinsCsvGeneratorControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTurbinsCsvGeneratorControl.Checked = true;
            this.cbTurbinsCsvGeneratorControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTurbinsCsvGeneratorControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbTurbinsCsvGeneratorControl.Enabled = false;
            this.cbTurbinsCsvGeneratorControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTurbinsCsvGeneratorControl.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbTurbinsCsvGeneratorControl.Location = new System.Drawing.Point(3, 3);
            this.cbTurbinsCsvGeneratorControl.Name = "cbTurbinsCsvGeneratorControl";
            this.cbTurbinsCsvGeneratorControl.Size = new System.Drawing.Size(100, 300);
            this.cbTurbinsCsvGeneratorControl.TabIndex = 6;
            this.cbTurbinsCsvGeneratorControl.Text = "Etap 1";
            this.cbTurbinsCsvGeneratorControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTurbinsCsvGeneratorControl.UseVisualStyleBackColor = true;
            this.cbTurbinsCsvGeneratorControl.CheckedChanged += new System.EventHandler(this.cbTurbinsCsvGeneratorControl_CheckedChanged);
            // 
            // cbWeatherControl
            // 
            this.cbWeatherControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbWeatherControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbWeatherControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWeatherControl.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbWeatherControl.Location = new System.Drawing.Point(109, 3);
            this.cbWeatherControl.Name = "cbWeatherControl";
            this.cbWeatherControl.Size = new System.Drawing.Size(100, 300);
            this.cbWeatherControl.TabIndex = 7;
            this.cbWeatherControl.Text = "Etap 3";
            this.cbWeatherControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWeatherControl.UseVisualStyleBackColor = true;
            this.cbWeatherControl.CheckedChanged += new System.EventHandler(this.cbWeatherControl_CheckedChanged);
            // 
            // btnCsvContoller
            // 
            this.btnCsvContoller.AutoSize = true;
            this.btnCsvContoller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.btnCsvContoller.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCsvContoller.FlatAppearance.BorderSize = 0;
            this.btnCsvContoller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsvContoller.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCsvContoller.ForeColor = System.Drawing.Color.White;
            this.btnCsvContoller.Location = new System.Drawing.Point(106, 306);
            this.btnCsvContoller.Margin = new System.Windows.Forms.Padding(0);
            this.btnCsvContoller.Name = "btnCsvContoller";
            this.btnCsvContoller.Size = new System.Drawing.Size(100, 400);
            this.btnCsvContoller.TabIndex = 0;
            this.btnCsvContoller.Text = "Etap 1";
            this.btnCsvContoller.UseVisualStyleBackColor = false;
            this.btnCsvContoller.Click += new System.EventHandler(this.btnCsvContoller_Click);
            // 
            // btnModificationsControl
            // 
            this.btnModificationsControl.AutoSize = true;
            this.btnModificationsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.btnModificationsControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificationsControl.FlatAppearance.BorderSize = 0;
            this.btnModificationsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificationsControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModificationsControl.ForeColor = System.Drawing.Color.White;
            this.btnModificationsControl.Location = new System.Drawing.Point(212, 0);
            this.btnModificationsControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnModificationsControl.Name = "btnModificationsControl";
            this.btnModificationsControl.Size = new System.Drawing.Size(100, 400);
            this.btnModificationsControl.TabIndex = 4;
            this.btnModificationsControl.Text = "Etap 2";
            this.btnModificationsControl.UseVisualStyleBackColor = false;
            this.btnModificationsControl.Click += new System.EventHandler(this.btnModificationsControl_Click);
            // 
            // pnTop
            // 
            this.pnTop.AutoSize = true;
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.pnTop.Controls.Add(this.btmMinimalize);
            this.pnTop.Controls.Add(this.btnMaxWindow);
            this.pnTop.Controls.Add(this.btnMinWindow);
            this.pnTop.Controls.Add(this.btnExit);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.MinimumSize = new System.Drawing.Size(0, 20);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1200, 20);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDoubleClick);
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            this.pnTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseUp);
            // 
            // btmMinimalize
            // 
            this.btmMinimalize.BackColor = System.Drawing.Color.Transparent;
            this.btmMinimalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btmMinimalize.FlatAppearance.BorderSize = 0;
            this.btmMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmMinimalize.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btmMinimalize.ForeColor = System.Drawing.Color.Transparent;
            this.btmMinimalize.Image = global::PracaInzynierska.Properties.Resources.line;
            this.btmMinimalize.Location = new System.Drawing.Point(1112, 0);
            this.btmMinimalize.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btmMinimalize.Name = "btmMinimalize";
            this.btmMinimalize.Size = new System.Drawing.Size(22, 20);
            this.btmMinimalize.TabIndex = 19;
            this.btmMinimalize.UseVisualStyleBackColor = false;
            this.btmMinimalize.Click += new System.EventHandler(this.btmMinimalize_Click);
            // 
            // btnMaxWindow
            // 
            this.btnMaxWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxWindow.FlatAppearance.BorderSize = 0;
            this.btnMaxWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxWindow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaxWindow.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaxWindow.Image = global::PracaInzynierska.Properties.Resources.max_window;
            this.btnMaxWindow.Location = new System.Drawing.Point(1134, 0);
            this.btnMaxWindow.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnMaxWindow.Name = "btnMaxWindow";
            this.btnMaxWindow.Size = new System.Drawing.Size(22, 20);
            this.btnMaxWindow.TabIndex = 21;
            this.btnMaxWindow.UseVisualStyleBackColor = false;
            this.btnMaxWindow.Visible = false;
            this.btnMaxWindow.Click += new System.EventHandler(this.btnMaxWindow_Click);
            // 
            // btnMinWindow
            // 
            this.btnMinWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnMinWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinWindow.FlatAppearance.BorderSize = 0;
            this.btnMinWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinWindow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinWindow.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinWindow.Image = global::PracaInzynierska.Properties.Resources.min_window;
            this.btnMinWindow.Location = new System.Drawing.Point(1156, 0);
            this.btnMinWindow.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnMinWindow.Name = "btnMinWindow";
            this.btnMinWindow.Size = new System.Drawing.Size(22, 20);
            this.btnMinWindow.TabIndex = 20;
            this.btnMinWindow.UseVisualStyleBackColor = false;
            this.btnMinWindow.Click += new System.EventHandler(this.btnMinWindow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::PracaInzynierska.Properties.Resources.cross;
            this.btnExit.Location = new System.Drawing.Point(1178, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 20);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindDataIntegrator";
            this.SizeChanged += new System.EventHandler(this.MenuForm_SizeChanged);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnMenuLeft.ResumeLayout(false);
            this.pnMenuLeft.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpButtons.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnForms;
        private System.Windows.Forms.Panel pnMenuLeft;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnCsvContoller;
        private System.Windows.Forms.Button btnModificationsControl;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btmMinimalize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinWindow;
        private System.Windows.Forms.Button btnMaxWindow;
        private System.Windows.Forms.CheckBox cbDataJoinControl;
        private System.Windows.Forms.CheckBox cbTurbinsCsvGeneratorControl;
        private System.Windows.Forms.CheckBox cbWeatherControl;
    }
}

