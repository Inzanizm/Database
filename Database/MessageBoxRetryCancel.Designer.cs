namespace Database
{
    partial class MessageBoxRetryCancel
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
            panel1 = new Panel();
            btnClose = new Button();
            labelCaption = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnRetry = new Button();
            panel3 = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(labelCaption);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 56);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(420, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 56);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
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
            labelCaption.TabIndex = 5;
            labelCaption.Text = "labelCaption";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnRetry);
            panel2.Location = new Point(3, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 68);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(259, 13);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRetry
            // 
            btnRetry.BackColor = Color.SeaGreen;
            btnRetry.DialogResult = DialogResult.Retry;
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetry.ForeColor = Color.WhiteSmoke;
            btnRetry.Location = new Point(87, 13);
            btnRetry.Margin = new Padding(4);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(146, 46);
            btnRetry.TabIndex = 0;
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelMessage);
            panel3.Controls.Add(pictureBoxIcon);
            panel3.Location = new Point(3, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 78);
            panel3.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(87, 19);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(112, 20);
            labelMessage.TabIndex = 7;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.ErrorImage = null;
            pictureBoxIcon.Image = Properties.Resources.error_icon_41;
            pictureBoxIcon.Location = new Point(13, 7);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(66, 57);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // MessageBoxRetryCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(478, 200);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxRetryCancel";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxRetryCancel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelCaption;
        private Button btnClose;
        private Panel panel2;
        private Button btnRetry;
        private Button btnCancel;
        private Panel panel3;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
    }
}