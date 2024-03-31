namespace Database
{
    partial class Paneldesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paneldesktop));
            paneltitlebar = new Panel();
            panel1 = new Panel();
            iconmaximize = new FontAwesome.Sharp.IconButton();
            iconexit = new FontAwesome.Sharp.IconButton();
            iconminimize = new FontAwesome.Sharp.IconButton();
            lbldatabase = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelmenu = new Panel();
            iconDB = new FontAwesome.Sharp.IconButton();
            iconMusic = new FontAwesome.Sharp.IconButton();
            picJoy = new PictureBox();
            picGo = new PictureBox();
            picBaby = new PictureBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconCredits = new FontAwesome.Sharp.IconButton();
            pnlnglahat = new Panel();
            pnldesktop = new Panel();
            paneltitlebar.SuspendLayout();
            panel1.SuspendLayout();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picJoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBaby).BeginInit();
            pnlnglahat.SuspendLayout();
            pnldesktop.SuspendLayout();
            SuspendLayout();
            // 
            // paneltitlebar
            // 
            paneltitlebar.BackColor = Color.DarkBlue;
            paneltitlebar.Controls.Add(panel1);
            paneltitlebar.Dock = DockStyle.Top;
            paneltitlebar.ForeColor = Color.Black;
            paneltitlebar.Location = new Point(173, 0);
            paneltitlebar.Name = "paneltitlebar";
            paneltitlebar.Size = new Size(728, 39);
            paneltitlebar.TabIndex = 0;
            paneltitlebar.Paint += paneltitlebar_Paint;
            paneltitlebar.MouseDown += paneltitlebar_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(iconmaximize);
            panel1.Controls.Add(iconexit);
            panel1.Controls.Add(iconminimize);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(608, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 39);
            panel1.TabIndex = 4;
            // 
            // iconmaximize
            // 
            iconmaximize.BackColor = Color.Transparent;
            iconmaximize.Dock = DockStyle.Fill;
            iconmaximize.FlatAppearance.BorderColor = Color.White;
            iconmaximize.FlatStyle = FlatStyle.Flat;
            iconmaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconmaximize.IconColor = Color.White;
            iconmaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconmaximize.IconSize = 30;
            iconmaximize.Location = new Point(41, 0);
            iconmaximize.Name = "iconmaximize";
            iconmaximize.Size = new Size(44, 39);
            iconmaximize.TabIndex = 1;
            iconmaximize.UseMnemonic = false;
            iconmaximize.UseVisualStyleBackColor = false;
            iconmaximize.Click += iconmaximize_Click;
            // 
            // iconexit
            // 
            iconexit.BackColor = Color.Transparent;
            iconexit.Dock = DockStyle.Right;
            iconexit.FlatAppearance.BorderColor = Color.White;
            iconexit.FlatStyle = FlatStyle.Flat;
            iconexit.IconChar = FontAwesome.Sharp.IconChar.X;
            iconexit.IconColor = Color.White;
            iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconexit.IconSize = 30;
            iconexit.Location = new Point(85, 0);
            iconexit.Name = "iconexit";
            iconexit.Size = new Size(35, 39);
            iconexit.TabIndex = 2;
            iconexit.UseMnemonic = false;
            iconexit.UseVisualStyleBackColor = false;
            iconexit.Click += iconexit_Click;
            // 
            // iconminimize
            // 
            iconminimize.BackColor = Color.Transparent;
            iconminimize.Dock = DockStyle.Left;
            iconminimize.FlatStyle = FlatStyle.Flat;
            iconminimize.ForeColor = Color.Transparent;
            iconminimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconminimize.IconColor = Color.White;
            iconminimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconminimize.IconSize = 30;
            iconminimize.Location = new Point(0, 0);
            iconminimize.Name = "iconminimize";
            iconminimize.Size = new Size(41, 39);
            iconminimize.TabIndex = 3;
            iconminimize.UseMnemonic = false;
            iconminimize.UseVisualStyleBackColor = false;
            iconminimize.Click += iconminimize_Click;
            // 
            // lbldatabase
            // 
            lbldatabase.AutoSize = true;
            lbldatabase.BackColor = Color.Transparent;
            lbldatabase.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldatabase.ForeColor = Color.Transparent;
            lbldatabase.Location = new Point(26, 3);
            lbldatabase.Name = "lbldatabase";
            lbldatabase.Size = new Size(119, 27);
            lbldatabase.TabIndex = 0;
            lbldatabase.Text = "Database";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.BackgroundImageLayout = ImageLayout.Zoom;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.TopLeft;
            iconButton1.ImageKey = "(none)";
            iconButton1.Location = new Point(3, 39);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(170, 64);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconusername";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.DimGray;
            panelmenu.Controls.Add(iconDB);
            panelmenu.Controls.Add(iconMusic);
            panelmenu.Controls.Add(picJoy);
            panelmenu.Controls.Add(picGo);
            panelmenu.Controls.Add(picBaby);
            panelmenu.Controls.Add(lbldatabase);
            panelmenu.Controls.Add(iconButton5);
            panelmenu.Controls.Add(iconCredits);
            panelmenu.Controls.Add(iconButton1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.ForeColor = Color.Black;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(173, 450);
            panelmenu.TabIndex = 1;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // iconDB
            // 
            iconDB.BackColor = Color.Transparent;
            iconDB.BackgroundImageLayout = ImageLayout.Zoom;
            iconDB.FlatAppearance.BorderSize = 0;
            iconDB.FlatStyle = FlatStyle.Flat;
            iconDB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconDB.ForeColor = Color.Transparent;
            iconDB.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconDB.IconColor = Color.White;
            iconDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDB.Location = new Point(-2, 128);
            iconDB.Name = "iconDB";
            iconDB.Size = new Size(175, 51);
            iconDB.TabIndex = 8;
            iconDB.Text = "DATABASE";
            iconDB.TextAlign = ContentAlignment.MiddleRight;
            iconDB.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconDB.UseVisualStyleBackColor = false;
            iconDB.Click += iconDB_Click;
            // 
            // iconMusic
            // 
            iconMusic.BackColor = Color.Transparent;
            iconMusic.BackgroundImageLayout = ImageLayout.Zoom;
            iconMusic.FlatAppearance.BorderSize = 0;
            iconMusic.FlatStyle = FlatStyle.Flat;
            iconMusic.ForeColor = Color.Transparent;
            iconMusic.IconChar = FontAwesome.Sharp.IconChar.Music;
            iconMusic.IconColor = Color.White;
            iconMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMusic.Location = new Point(-9, 185);
            iconMusic.Name = "iconMusic";
            iconMusic.Size = new Size(182, 51);
            iconMusic.TabIndex = 1;
            iconMusic.Text = "MUSIC      ";
            iconMusic.TextAlign = ContentAlignment.MiddleRight;
            iconMusic.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconMusic.UseVisualStyleBackColor = false;
            iconMusic.Click += iconMusic_Click;
            // 
            // picJoy
            // 
            picJoy.BackColor = Color.Transparent;
            picJoy.BackgroundImage = (Image)resources.GetObject("picJoy.BackgroundImage");
            picJoy.BackgroundImageLayout = ImageLayout.Stretch;
            picJoy.Location = new Point(21, 47);
            picJoy.Name = "picJoy";
            picJoy.Size = new Size(42, 44);
            picJoy.TabIndex = 7;
            picJoy.TabStop = false;
            picJoy.Visible = false;
            // 
            // picGo
            // 
            picGo.BackColor = Color.Transparent;
            picGo.BackgroundImage = (Image)resources.GetObject("picGo.BackgroundImage");
            picGo.BackgroundImageLayout = ImageLayout.Stretch;
            picGo.Location = new Point(21, 47);
            picGo.Name = "picGo";
            picGo.Size = new Size(42, 44);
            picGo.TabIndex = 6;
            picGo.TabStop = false;
            picGo.Visible = false;
            // 
            // picBaby
            // 
            picBaby.BackColor = Color.Transparent;
            picBaby.BackgroundImage = (Image)resources.GetObject("picBaby.BackgroundImage");
            picBaby.BackgroundImageLayout = ImageLayout.Stretch;
            picBaby.Location = new Point(21, 47);
            picBaby.Name = "picBaby";
            picBaby.Size = new Size(42, 44);
            picBaby.TabIndex = 6;
            picBaby.TabStop = false;
            picBaby.Visible = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Transparent;
            iconButton5.Dock = DockStyle.Bottom;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Transparent;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.Location = new Point(0, 387);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(173, 63);
            iconButton5.TabIndex = 3;
            iconButton5.Text = "Sign out";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconCredits
            // 
            iconCredits.BackColor = Color.Transparent;
            iconCredits.BackgroundImageLayout = ImageLayout.Zoom;
            iconCredits.FlatAppearance.BorderSize = 0;
            iconCredits.FlatStyle = FlatStyle.Flat;
            iconCredits.ForeColor = Color.Transparent;
            iconCredits.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconCredits.IconColor = Color.White;
            iconCredits.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCredits.Location = new Point(-2, 242);
            iconCredits.Name = "iconCredits";
            iconCredits.Size = new Size(222, 51);
            iconCredits.TabIndex = 2;
            iconCredits.Text = "CREDITS      ";
            iconCredits.TextAlign = ContentAlignment.MiddleLeft;
            iconCredits.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconCredits.UseVisualStyleBackColor = false;
            iconCredits.Click += iconCredits_Click;
            // 
            // pnlnglahat
            // 
            pnlnglahat.Controls.Add(pnldesktop);
            pnlnglahat.Dock = DockStyle.Fill;
            pnlnglahat.Location = new Point(0, 0);
            pnlnglahat.Name = "pnlnglahat";
            pnlnglahat.Size = new Size(901, 450);
            pnlnglahat.TabIndex = 2;
            // 
            // pnldesktop
            // 
            pnldesktop.BackColor = SystemColors.ControlDarkDark;
            pnldesktop.BackgroundImage = (Image)resources.GetObject("pnldesktop.BackgroundImage");
            pnldesktop.BackgroundImageLayout = ImageLayout.Stretch;
            pnldesktop.Controls.Add(paneltitlebar);
            pnldesktop.Controls.Add(panelmenu);
            pnldesktop.Dock = DockStyle.Fill;
            pnldesktop.Location = new Point(0, 0);
            pnldesktop.Name = "pnldesktop";
            pnldesktop.Size = new Size(901, 450);
            pnldesktop.TabIndex = 0;
            pnldesktop.MouseDown += pnldesktop_MouseDown;
            // 
            // Paneldesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            ControlBox = false;
            Controls.Add(pnlnglahat);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Paneldesktop";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paneldesktop";
            FormClosing += Paneldesktop_FormClosing;
            FormClosed += Paneldesktop_FormClosed;
            paneltitlebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picJoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBaby).EndInit();
            pnlnglahat.ResumeLayout(false);
            pnldesktop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltitlebar;
        private Panel panelmenu;
        private Panel pnlnglahat;
        private FontAwesome.Sharp.IconButton iconmaximize;
        private Label lbldatabase;
        private FontAwesome.Sharp.IconButton iconMusic;
        private Panel pnldesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconminimize;
        private FontAwesome.Sharp.IconButton iconexit;
        private FontAwesome.Sharp.IconButton iconCredits;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel1;
        private PictureBox picBaby;
        private PictureBox picGo;
        private PictureBox picJoy;
        private FontAwesome.Sharp.IconButton iconDB;
    }
}