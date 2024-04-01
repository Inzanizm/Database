//Para ma access yung sql
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Location of Database
                string connString = "server=localhost;uid=root;pwd=C1nc0gr0up;database=ursb";
                MySqlConnection conn = new MySqlConnection();
                //Conn connected sa Connstring
                conn.ConnectionString = connString;
                conn.Open();
                //string ng table
                string sql = "select * from ursbstaff_tbl";
                //sql = table na kukunin, conn = connection sa database
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MyMessageBox.ShowMessage("MYSQL CONNECTED..!!", "DATABASE CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 frmLogin = new Form2();
                    frmLogin.Show();
                    this.Hide();
                }
                reader.Close();
                conn.Close();
            }
            //Pag may error
            catch (MySqlException ex)
            {
                MyMessageBox.ShowMessage(ex.ToString(), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void iconmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
                button1.Location = new Point(400, 699);
                button1.Size = new Size(290, 140);
                panel1.Size = new Size(300, 50);
                panel1.Location = new Point(557, 0);

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button1.Location = new Point(172, 330);
                button1.Size = new Size(120, 65);
                panel1.Size = new Size(146, 41);

            }
        }
    }
}
