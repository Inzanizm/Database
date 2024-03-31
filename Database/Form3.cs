using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Form3 : Form
    {
        private Paneldesktop paneldesktop;
        private int originalRowHeight;
        public Form3(Paneldesktop paneldesktop)
        {
            InitializeComponent();
            this.paneldesktop = paneldesktop;

            string connString = "server=localhost;uid=root;pwd=C1nc0gr0up;database=ursb"; //Set your MySQL connection string here.
            string sql = "SELECT * FROM ursbstaff_tbl"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    //Paglalagyan ng mga data
                    DataSet ds = new DataSet();
                    //Pag fill ng dataset galing sa database
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            originalRowHeight = dataGridView1.Rows[0].Height;
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            string imagePath;
            if (paneldesktop != null)
            {
                if (paneldesktop.WindowState == FormWindowState.Normal)
                {
                    imagePath = @"C:\Users\ACER\Downloads\Untitled7_20240329145639.png";
                    this.BackgroundImage = Image.FromFile(imagePath);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Height = originalRowHeight;
                    }
                }
                else
                {
                    int totalRowHeight = dataGridView1.ColumnHeadersHeight; // Start with the header height
                    imagePath = @"C:\Users\ACER\Downloads\Untitled8_20240329163917.png";
                    this.BackgroundImage = Image.FromFile(imagePath);

                    // Calculate the total height of the rows
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        totalRowHeight += row.Height;
                    }

                    // Calculate the available space for each row
                    int availableHeight = dataGridView1.Height - totalRowHeight;

                    // Calculate the height for each row (distribute the available space evenly)
                    int rowHeight = availableHeight / dataGridView1.Rows.Count;

                    // Set the height for each row
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Height = rowHeight + 28;
                    }
                }
            }
        }
    }
}
