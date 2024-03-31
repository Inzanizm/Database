namespace Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            iconmaximize = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(iconmaximize);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconButton2);
            panel2.Dock = DockStyle.Right;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(664, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 39);
            panel2.TabIndex = 7;
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
            iconmaximize.Location = new Point(40, 0);
            iconmaximize.Name = "iconmaximize";
            iconmaximize.Size = new Size(49, 39);
            iconmaximize.TabIndex = 4;
            iconmaximize.UseMnemonic = false;
            iconmaximize.UseVisualStyleBackColor = false;
            iconmaximize.Click += iconmaximize_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderColor = Color.White;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(89, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(47, 39);
            iconButton1.TabIndex = 2;
            iconButton1.UseMnemonic = false;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Transparent;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(40, 39);
            iconButton2.TabIndex = 3;
            iconButton2.UseMnemonic = false;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(167, 318);
            button1.Name = "button1";
            button1.Size = new Size(115, 51);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            MouseDown += Form1_MouseDown;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconmaximize;
    }
}
