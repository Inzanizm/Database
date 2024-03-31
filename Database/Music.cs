using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Database
{
    public partial class Music : Form
    {
        private Paneldesktop paneldesktop;
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public WMPLib.WMPPlayState PlayerPlayState
        {
            get { return player?.playState ?? WMPLib.WMPPlayState.wmppsUndefined; }
        }

        public Music(Paneldesktop paneldesktop)
        {
            InitializeComponent();
            this.paneldesktop = paneldesktop;
            player.URL = "C:\\Users\\ACER\\Documents\\Code\\Database - Copy - Copy - Copy\\Database\\bin\\Debug\\abilijins.mp3";
            player.controls.stop();
        }

        private void iconplay_Click(object sender, EventArgs e)
        {
            if (player.playState != WMPPlayState.wmppsPlaying)
            {
                iconplay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                player.controls.play();
                player.settings.setMode("loop", true);
                timer1.Start();
            }
            else
            {
                iconplay.IconChar = FontAwesome.Sharp.IconChar.Play;
                player.controls.pause();
            }
        }

        private void Music_Resize(object sender, EventArgs e)
        {
            if (paneldesktop != null)
            {
                if (paneldesktop.WindowState == FormWindowState.Normal)
                {
                    iconplay.Location = new Point(540, 173);
                    iconplay.IconSize = 48;

                    guna2ProgressBar1.Size = new Size(350, 17);
                    guna2ProgressBar1.Location = new Point(12, 323);
                }
                else
                {
                    iconplay.Location = new Point(1350, 400);
                    iconplay.IconSize = 96;

                    guna2ProgressBar1.Size = new Size(847, 41);
                    guna2ProgressBar1.Location = new Point(25, 700);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                guna2ProgressBar1.Maximum = (int)player.controls.currentItem.duration;
                guna2ProgressBar1.Value = (int)player.controls.currentPosition;
            }
        }
    }
}
