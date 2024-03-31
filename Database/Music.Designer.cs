namespace Database
{
    partial class Music
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
            if (disposing)
            {
                player.controls.stop();
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            iconplay = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            SuspendLayout();
            // 
            // iconplay
            // 
            iconplay.Anchor = AnchorStyles.None;
            iconplay.AutoSize = true;
            iconplay.BackColor = Color.Transparent;
            iconplay.FlatAppearance.BorderSize = 0;
            iconplay.FlatStyle = FlatStyle.Flat;
            iconplay.ForeColor = Color.White;
            iconplay.IconChar = FontAwesome.Sharp.IconChar.Play;
            iconplay.IconColor = Color.White;
            iconplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconplay.Location = new Point(540, 173);
            iconplay.Name = "iconplay";
            iconplay.Size = new Size(72, 56);
            iconplay.TabIndex = 0;
            iconplay.UseVisualStyleBackColor = false;
            iconplay.Click += iconplay_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.Anchor = AnchorStyles.None;
            guna2ProgressBar1.AutoRoundedCorners = true;
            guna2ProgressBar1.BackColor = Color.Transparent;
            guna2ProgressBar1.BorderRadius = 7;
            guna2ProgressBar1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2ProgressBar1.BorderThickness = 1;
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.FillColor = Color.Transparent;
            guna2ProgressBar1.Location = new Point(12, 323);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            guna2ProgressBar1.ProgressColor = Color.Black;
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(350, 17);
            guna2ProgressBar1.Style = ProgressBarStyle.Continuous;
            guna2ProgressBar1.TabIndex = 1;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Music
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(iconplay);
            DoubleBuffered = true;
            Name = "Music";
            Text = "Music";
            Resize += Music_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconplay;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}