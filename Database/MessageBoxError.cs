using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class MessageBoxError : Form
    {
        public MessageBoxError()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBoxIcon.Image; }
            set { pictureBoxIcon.Image = value; }
        }

        public string Message
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }

        public string Title
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
