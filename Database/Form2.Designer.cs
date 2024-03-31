namespace Database
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            iconmaximize = new FontAwesome.Sharp.IconButton();
            iconexit = new FontAwesome.Sharp.IconButton();
            iconminimize = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(441, 193);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(473, 98);
            label1.Name = "label1";
            label1.Size = new Size(197, 50);
            label1.TabIndex = 0;
            label1.Text = "USER LOG IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(441, 248);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(510, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 31);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(528, 295);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(510, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 31);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(iconmaximize);
            panel1.Controls.Add(iconexit);
            panel1.Controls.Add(iconminimize);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(685, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 39);
            panel1.TabIndex = 5;
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
            iconmaximize.Location = new Point(37, 0);
            iconmaximize.Name = "iconmaximize";
            iconmaximize.Size = new Size(36, 39);
            iconmaximize.TabIndex = 4;
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
            iconexit.Location = new Point(73, 0);
            iconexit.Name = "iconexit";
            iconexit.Size = new Size(42, 39);
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
            iconminimize.Size = new Size(37, 39);
            iconminimize.TabIndex = 3;
            iconminimize.UseMnemonic = false;
            iconminimize.UseVisualStyleBackColor = false;
            iconminimize.Click += iconminimize_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 39);
            panel2.TabIndex = 6;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconexit;
        private FontAwesome.Sharp.IconButton iconminimize;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconmaximize;
    }
}