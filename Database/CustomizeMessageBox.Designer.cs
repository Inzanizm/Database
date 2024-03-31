namespace Database
{
    partial class CustomizeMessageBox
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
            panelTitleBar = new Panel();
            btnClose = new Button();
            labelCaption = new Label();
            panelButtons = new Panel();
            btnOK = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelTitleBar.SuspendLayout();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.LightSeaGreen;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(503, 56);
            panelTitleBar.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(445, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 56);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(13, 19);
            labelCaption.Margin = new Padding(4, 0, 4, 0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(101, 20);
            labelCaption.TabIndex = 4;
            labelCaption.Text = "labelCaption";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(235, 235, 235);
            panelButtons.Controls.Add(btnOK);
            panelButtons.Location = new Point(4, 128);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(495, 67);
            panelButtons.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.SeaGreen;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.WhiteSmoke;
            btnOK.Location = new Point(188, 8);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(146, 46);
            btnOK.TabIndex = 0;
            btnOK.Text = "O&K";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Location = new Point(4, 56);
            panelBody.Margin = new Padding(4);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(495, 72);
            panelBody.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(83, 20);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.MaximumSize = new Size(550, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(7, 6, 13, 18);
            labelMessage.Size = new Size(132, 44);
            labelMessage.TabIndex = 6;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.ErrorImage = null;
            pictureBoxIcon.Image = Properties.Resources.about_11660131;
            pictureBoxIcon.Location = new Point(13, 5);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(62, 59);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // CustomizeMessageBox
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(503, 200);
            ControlBox = false;
            Controls.Add(panelBody);
            Controls.Add(panelButtons);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomizeMessageBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomizeMessageBox";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label labelCaption;
        private Button btnClose;
        private Panel panelButtons;
        private Button btnOK;
        private Panel panelBody;
        private PictureBox pictureBoxIcon;
        private Label labelMessage;
    }
}