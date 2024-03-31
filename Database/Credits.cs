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
    public partial class Credits : Form
    {

        public Credits(WMPLib.WMPPlayState playState)
        {
            InitializeComponent();
            string imagePath;
            if (playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                imagePath = "C:\\Users\\ACER\\Downloads\\1711808286401.jpg";
                this.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                imagePath = "C:\\Users\\ACER\\Downloads\\1711810016513.jpg";
                this.BackgroundImage = Image.FromFile(imagePath);
            }
        }
    }
}