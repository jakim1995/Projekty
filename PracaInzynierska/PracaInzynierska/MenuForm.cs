using PracaInzynierska.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaInzynierska
{
    public partial class MenuForm : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        private Point MouseDownLocation;
        private int LastFormWidth = 0;
        private int LastFormHeight = 0;

        public MenuForm()
        {
            InitializeComponent();
            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            TurbinsCsvGeneratorControl loadCsvControl = new TurbinsCsvGeneratorControl();
            loadCsvControl.Dock = DockStyle.Fill;
            pnForms.Controls.Add(loadCsvControl);
            this.cbDataJoinControl.Height = this.pnMenu.Height / 3 - 15;
            this.cbTurbinsCsvGeneratorControl.Height = this.pnMenu.Height / 3 - 15;
            this.cbWeatherControl.Height = this.pnMenu.Height / 3 - 15;
            this.btnCsvContoller.Focus();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if(this.Location.Y >= 0 || this.Location.X >= 0)
                {
                    if(btnMinWindow.Visible)
                    {
                        this.Width = 1200;
                        this.Height = 1000;
                    }
                    else
                    {
                        this.Width = LastFormWidth;
                        this.Height = LastFormHeight;
                    } 
                    btnMinWindow.Visible = false;
                    btnMaxWindow.Visible = true;
                    
                }
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCsvContoller_Click(object sender, EventArgs e)
        {
            TurbinsCsvGeneratorControl loadCsvControl = new TurbinsCsvGeneratorControl();
            loadCsvControl.Dock = DockStyle.Fill;
            pnForms.Controls.Clear();
            pnForms.Controls.Add(loadCsvControl);
        }

        private void btmMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var screenLocation = Screen.GetWorkingArea(this.Location).Location;
            this.Location = screenLocation;
            btnMinWindow.Visible = true;
            btnMaxWindow.Visible = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pnTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && this.Location.Y <= 0)
            {
                var screenLocation = Screen.GetWorkingArea(this.Location).Location;
                this.Location = screenLocation;
                btnMinWindow.Visible = true;
                btnMaxWindow.Visible = false;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
        }

        private void btnModificationsControl_Click(object sender, EventArgs e)
        {
            DataJoinControl modificationsControl = new DataJoinControl();
            modificationsControl.Dock = DockStyle.Fill;
            pnForms.Controls.Clear();
            pnForms.Controls.Add(modificationsControl);
        }

        private void btnMinWindow_Click(object sender, EventArgs e)
        {
            btnMinWindow.Visible = false;
            btnMaxWindow.Visible = true;
            this.Width = 1200;
            this.Height = 1000;
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void btnMaxWindow_Click(object sender, EventArgs e)
        {
            btnMinWindow.Visible = true;
            btnMaxWindow.Visible = false;
            var screenLocation = Screen.GetWorkingArea(this.Location).Location;
            this.Location = screenLocation;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84 && btnMaxWindow.Visible)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void MenuForm_SizeChanged(object sender, EventArgs e)
        {
            this.cbDataJoinControl.Height = this.pnMenu.Height / 3 - 15;
            this.cbTurbinsCsvGeneratorControl.Height = this.pnMenu.Height / 3 - 15;
            this.cbWeatherControl.Height = this.pnMenu.Height / 3 - 15;
            LastFormHeight = this.Height;
            LastFormWidth = this.Width;
        }

        private void cbDataJoinControl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataJoinControl.Checked)
            {
                DataJoinControl dataJoinControl = new DataJoinControl();
                dataJoinControl.Dock = DockStyle.Fill;
                pnForms.Controls.Clear();
                pnForms.Controls.Add(dataJoinControl);
                cbDataJoinControl.Enabled = false;
                cbTurbinsCsvGeneratorControl.Enabled = true;
                cbTurbinsCsvGeneratorControl.Checked = false;
                cbWeatherControl.Enabled = true;
                cbWeatherControl.Checked = false;
            }
        }

        private void cbTurbinsCsvGeneratorControl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTurbinsCsvGeneratorControl.Checked)
            {
                TurbinsCsvGeneratorControl turbinsCsvGeneratorControl = new TurbinsCsvGeneratorControl();
                turbinsCsvGeneratorControl.Dock = DockStyle.Fill;
                pnForms.Controls.Clear();
                pnForms.Controls.Add(turbinsCsvGeneratorControl);
                cbTurbinsCsvGeneratorControl.Enabled = false;
                cbDataJoinControl.Enabled = true;
                cbDataJoinControl.Checked = false;
                cbWeatherControl.Enabled = true;
                cbWeatherControl.Checked = false;
            }
        }

        private void cbWeatherControl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWeatherControl.Checked)
            {
                WeatherControl weatherControl = new WeatherControl();
                weatherControl.Dock = DockStyle.Fill;
                pnForms.Controls.Clear();
                pnForms.Controls.Add(weatherControl);
                cbWeatherControl.Enabled = false;
                cbDataJoinControl.Enabled = true;
                cbDataJoinControl.Checked = false;
                cbTurbinsCsvGeneratorControl.Enabled = true;
                cbTurbinsCsvGeneratorControl.Checked = false;
            }
        }
    }
}
