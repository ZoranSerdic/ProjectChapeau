namespace ChapeauUI
{
    partial class ManagerConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerConfirmation));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            lblPleaseConfirm = new Label();
            lblChangingInfo = new Label();
            lblAreYouSure = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(494, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "Confirmation needed";
            // 
            // lblPleaseConfirm
            // 
            lblPleaseConfirm.AutoSize = true;
            lblPleaseConfirm.Location = new Point(355, 229);
            lblPleaseConfirm.Name = "lblPleaseConfirm";
            lblPleaseConfirm.Size = new Size(109, 20);
            lblPleaseConfirm.TabIndex = 15;
            lblPleaseConfirm.Text = "Please confirm:";
            // 
            // lblChangingInfo
            // 
            lblChangingInfo.AutoSize = true;
            lblChangingInfo.Location = new Point(296, 476);
            lblChangingInfo.Name = "lblChangingInfo";
            lblChangingInfo.Size = new Size(231, 20);
            lblChangingInfo.TabIndex = 16;
            lblChangingInfo.Text = "Meyer, Xavier from the database?";
            // 
            // lblAreYouSure
            // 
            lblAreYouSure.AutoSize = true;
            lblAreYouSure.Location = new Point(296, 380);
            lblAreYouSure.Name = "lblAreYouSure";
            lblAreYouSure.Size = new Size(230, 20);
            lblAreYouSure.TabIndex = 17;
            lblAreYouSure.Text = "Are you sure you want to remove:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(118, 831);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(556, 831);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // ManagerConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblAreYouSure);
            Controls.Add(lblChangingInfo);
            Controls.Add(lblPleaseConfirm);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "ManagerConfirmation";
            Text = "ManagerConfirmation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblPleaseConfirm;
        private Label lblChangingInfo;
        private Label lblAreYouSure;
        private Button btnCancel;
        private Button btnConfirm;
    }
}