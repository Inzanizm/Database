using Microsoft.Windows.Themes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Paneldesktop : Form
    {
        public Paneldesktop(string fullName)
        {
            InitializeComponent();
            openChildFormInPanel(new Form3(this));
            iconButton1.Text = fullName;
            
            if (fullName == "Joy S.G. Cruz")
            {
                picJoy.Visible = true;
            }
            else if (fullName == "Richelle E. Go")
            {
                picGo.Visible = true;
            }
            else if (fullName == "Baby Eunice M. Cabaltera")
            {
                picBaby.Visible = true;
            }
            iconDB.BackColor = Color.Blue;
            iconDB.ForeColor = Color.Yellow;
            iconDB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void iconminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {
            paneltitlebar.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            panelmenu.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void iconmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
                iconButton5.Size = new System.Drawing.Size(173, 91);
                iconButton5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                iconButton5.Size = new System.Drawing.Size(173, 63);
                iconButton5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            //string panelWidth = paneltitlebar.Width.ToString();
            //string panelHeight = paneltitlebar.Height.ToString();
        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Paneldesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ds = MyMessageBox.ShowMessage("Are you sure you want to close the form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Paneldesktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form2 frmLogin = new Form2();
            frmLogin.Show();
            this.Dispose();
        }

        private void paneltitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnldesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private Form? activeForm = null, musicForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (childForm is not Music)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                if (musicForm != null)
                {
                    musicForm.Hide();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnldesktop.Controls.Add(childForm);
                pnldesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                if (musicForm == null)
                {
                    musicForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    pnldesktop.Controls.Add(childForm);
                    pnldesktop.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
                else
                {
                    musicForm.Show();
                }
            }
        }

        private void iconDB_Click(object sender, EventArgs e)
        {
            if (lbldatabase.Text != "Database")
            {
                openChildFormInPanel(new Form3(this));
            }

            lbldatabase.Text = "Database";

            if (lbldatabase.Text == "Database")
            {
                iconDB.BackColor = Color.Blue;
                iconDB.ForeColor = Color.Yellow;
                iconDB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                
                iconMusic.BackColor = Color.Transparent;
                iconMusic.ForeColor = Color.White;
                iconMusic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

                iconCredits.BackColor = Color.Transparent;
                iconCredits.ForeColor = Color.White;
                iconCredits.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }

        private void iconMusic_Click(object sender, EventArgs e)
        {
            if (lbldatabase.Text != "Music")
            {
                openChildFormInPanel(new Music(this));
            }

            lbldatabase.Text = "Music";

            if (lbldatabase.Text == "Music")
            {
                iconMusic.BackColor = Color.Blue;
                iconMusic.ForeColor = Color.Yellow;
                iconMusic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                
                iconDB.BackColor = Color.Transparent;
                iconDB.ForeColor = Color.White;
                iconDB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

                iconCredits.BackColor = Color.Transparent;
                iconCredits.ForeColor = Color.White;
                iconCredits.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }

        private void iconCredits_Click(object sender, EventArgs e)
        {
            if (lbldatabase.Text != "Credits")
            {
                if (musicForm != null && musicForm is Music)
                {
                    Music music = (Music)musicForm;
                    WMPLib.WMPPlayState playState = music.PlayerPlayState;
                    openChildFormInPanel(new Credits(playState));
                    //if (playState == WMPLib.WMPPlayState.wmppsPlaying)
                    //{
                    //    iconButton5.Text = "Playing";
                    //}
                }
                else
                {
                    WMPLib.WMPPlayState playState = WMPLib.WMPPlayState.wmppsUndefined;
                    openChildFormInPanel(new Credits(playState));
                }
            }

            lbldatabase.Text = "Credits";

            if (lbldatabase.Text == "Credits")
            {
                iconCredits.BackColor = Color.Blue;
                iconCredits.ForeColor = Color.Yellow;
                iconCredits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

                iconDB.BackColor = Color.Transparent;
                iconDB.ForeColor = Color.White;
                iconDB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                
                iconMusic.BackColor = Color.Transparent;
                iconMusic.ForeColor = Color.White;
                iconMusic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
    }
}
