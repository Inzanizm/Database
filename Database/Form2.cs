using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form2 : Form
    {
        private string username = "", password = "";
        private int limit = 3;
        public Form2()
        {
            InitializeComponent();
            label1.Location = new Point(480, 105);
            label2.Location = new Point(450, 211);
            label3.Location = new Point(450, 270);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Para magpunta sa next textbox after mag enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckCredentials();
            }
        }

        private void CheckCredentials()
        {
            username = textBox1.Text;
            password = textBox2.Text;

            string connString = "server=localhost;uid=root;pwd=C1nc0gr0up;database=ursb";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT * FROM ursbstaff_tbl";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool found = false;
                        string fullName = "", userType = "";

                        while (reader.Read())
                        {
                            if (username == reader["username"].ToString() && password == reader["password"].ToString())
                            {
                                found = true;
                                string? fullNameLocal = reader["FullName"].ToString();
                                if (fullNameLocal != null)
                                {
                                    fullName = fullNameLocal;
                                }
                                string? userTypeLocal = reader["UserType"].ToString();
                                if (userTypeLocal != null)
                                {
                                    userType = userTypeLocal;
                                }
                                break;
                            }
                        }
                        if (found)
                        {
                            MyMessageBox.ShowMessage($"Welcome! {fullName} {userType}", "LOGGED IN..!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (fullName !=null)
                            {
                                Paneldesktop panelDesktop = new Paneldesktop(fullName);
                                panelDesktop.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            limit--;

                            string tr = (limit == 1) ? "y" : "ies";

                            if (limit > 0)
                            {
                                DialogResult ds = MyMessageBox.ShowMessage($"Invalid / No Record Found! ({limit} tr{tr} left)\nYou can try again or cancel.", "LOG-IN ERROR.!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                                if (ds == DialogResult.Retry)
                                {
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox1.Focus();
                                }
                                else if (ds == DialogResult.Cancel)
                                {
                                    Form1 frmMain = new Form1();
                                    frmMain.Show();
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                MyMessageBox.ShowMessage("System Blocked", "NOT TODAY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                        }
                    }
                }
            }
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

        private void iconminimize_Click(object sender, EventArgs e)
        {
            iconminimize.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
                label1.Location = new Point(1180, 260);
                label1.Font = new Font("Agency FB", 55F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox1.Font = new Font("Consolas", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox1.Size = new Size(370,50 );
                textBox1.Location = new Point(1270, 450);
                textBox2.Font = new Font("Consolas", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox2.Size = new Size(370, 50);
                textBox2.Location = new Point(1270, 580);
                button1.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
                button1.Size = new Size(230, 100);
                button1.Location = new Point(1330, 680);
                label2.Location = new Point(1150, 460);
                label2.Font = new Font("Agency FB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
                label3.Location = new Point(1150, 590);
                label3.Font = new Font("Agency FB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
                pictureBox1.Size = new Size(1200, 1000);
                pictureBox1.Location = new Point(70, 65);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                label1.Location = new Point(473, 100);
                label1.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox1.Size = new Size(160, 31);
                textBox1.Location = new Point(510, 184);
                textBox2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                textBox2.Size = new Size(160, 31);
                textBox2.Location = new Point(510, 239);
                button1.Font = new Font("Consolas", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
                button1.Size = new Size(104, 41);
                button1.Location = new Point(528, 295);
                label2.Location = new Point(445, 190);
                label2.Font = new Font("Agency FB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                label3.Location = new Point(445, 245);               
                label3.Font = new Font("Agency FB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                pictureBox1.Size = new Size(485, 337);
                pictureBox1.Location = new Point(37, 61);
            }
        }
    }

}
