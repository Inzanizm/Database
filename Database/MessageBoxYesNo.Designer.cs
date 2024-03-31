namespace Database
{
    partial class MessageBoxYesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxYesNo));
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelTitleBar = new Panel();
            btnClose = new Button();
            labelCaption = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnRetry = new Button();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelTitleBar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panelBody.Size = new Size(444, 72);
            panelBody.TabIndex = 3;
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
            pictureBoxIcon.Image = (Image)resources.GetObject("pictureBoxIcon.Image");
            pictureBoxIcon.Location = new Point(13, 5);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(62, 59);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.IndianRed;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(451, 56);
            panelTitleBar.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.No;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(393, 0);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnRetry);
            panel2.Location = new Point(4, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 68);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.DialogResult = DialogResult.No;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(251, 13);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "No";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetry
            // 
            btnRetry.BackColor = Color.SeaGreen;
            btnRetry.DialogResult = DialogResult.Yes;
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetry.ForeColor = Color.WhiteSmoke;
            btnRetry.Location = new Point(70, 13);
            btnRetry.Margin = new Padding(4);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(146, 46);
            btnRetry.TabIndex = 0;
            btnRetry.Text = "Yes";
            btnRetry.UseVisualStyleBackColor = false;
            // 
            // MessageBoxYesNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(451, 200);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panelTitleBar);
            Controls.Add(panelBody);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessageBoxYesNo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxYesNo";
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBody;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Panel panelTitleBar;
        private Button btnClose;
        private Label labelCaption;
        private Panel panel2;
        private Button btnCancel;
        private Button btnRetry;
    }
}