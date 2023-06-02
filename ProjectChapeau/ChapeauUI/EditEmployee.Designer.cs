﻿namespace ChapeauUI
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            txtBoxPin2 = new TextBox();
            txtBoxPin1 = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            radBtnBartender = new RadioButton();
            radBtnChef = new RadioButton();
            radBtnWaiter = new RadioButton();
            lblConfirmPinCode = new Label();
            lblPinCode = new Label();
            lblOccupation = new Label();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxPin2
            // 
            txtBoxPin2.Location = new Point(340, 600);
            txtBoxPin2.Name = "txtBoxPin2";
            txtBoxPin2.Size = new Size(125, 27);
            txtBoxPin2.TabIndex = 48;
            txtBoxPin2.UseSystemPasswordChar = true;
            txtBoxPin2.TextChanged += txtBoxPin2_TextChanged;
            // 
            // txtBoxPin1
            // 
            txtBoxPin1.Location = new Point(76, 600);
            txtBoxPin1.Name = "txtBoxPin1";
            txtBoxPin1.Size = new Size(125, 27);
            txtBoxPin1.TabIndex = 47;
            txtBoxPin1.UseSystemPasswordChar = true;
            txtBoxPin1.TextChanged += txtBoxPin1_TextChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(543, 728);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 46;
            btnConfirm.Text = "confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(132, 728);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // radBtnBartender
            // 
            radBtnBartender.AutoSize = true;
            radBtnBartender.Location = new Point(567, 433);
            radBtnBartender.Name = "radBtnBartender";
            radBtnBartender.Size = new Size(95, 24);
            radBtnBartender.TabIndex = 44;
            radBtnBartender.TabStop = true;
            radBtnBartender.Text = "Bartender";
            radBtnBartender.UseVisualStyleBackColor = true;
            // 
            // radBtnChef
            // 
            radBtnChef.AutoSize = true;
            radBtnChef.Location = new Point(339, 433);
            radBtnChef.Name = "radBtnChef";
            radBtnChef.Size = new Size(60, 24);
            radBtnChef.TabIndex = 43;
            radBtnChef.TabStop = true;
            radBtnChef.Text = "Chef";
            radBtnChef.UseVisualStyleBackColor = true;
            // 
            // radBtnWaiter
            // 
            radBtnWaiter.AutoSize = true;
            radBtnWaiter.Location = new Point(76, 433);
            radBtnWaiter.Name = "radBtnWaiter";
            radBtnWaiter.Size = new Size(73, 24);
            radBtnWaiter.TabIndex = 42;
            radBtnWaiter.TabStop = true;
            radBtnWaiter.Text = "Waiter";
            radBtnWaiter.UseVisualStyleBackColor = true;
            // 
            // lblConfirmPinCode
            // 
            lblConfirmPinCode.AutoSize = true;
            lblConfirmPinCode.Location = new Point(339, 560);
            lblConfirmPinCode.Name = "lblConfirmPinCode";
            lblConfirmPinCode.Size = new Size(126, 20);
            lblConfirmPinCode.TabIndex = 41;
            lblConfirmPinCode.Text = "Confirm Pin code:";
            // 
            // lblPinCode
            // 
            lblPinCode.AutoSize = true;
            lblPinCode.Location = new Point(76, 560);
            lblPinCode.Name = "lblPinCode";
            lblPinCode.Size = new Size(139, 20);
            lblPinCode.TabIndex = 40;
            lblPinCode.Text = "Four digit Pin Code:";
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(76, 372);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(88, 20);
            lblOccupation.TabIndex = 39;
            lblOccupation.Text = "Occupation:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(339, 254);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 38;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(76, 254);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 37;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(339, 199);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 36;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(76, 199);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 35;
            lblFirstName.Text = "First Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(229, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(341, 67);
            lblHeading.TabIndex = 33;
            lblHeading.Text = "Edit employee";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(txtBoxPin2);
            Controls.Add(txtBoxPin1);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(radBtnBartender);
            Controls.Add(radBtnChef);
            Controls.Add(radBtnWaiter);
            Controls.Add(lblConfirmPinCode);
            Controls.Add(lblPinCode);
            Controls.Add(lblOccupation);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPin2;
        private TextBox txtBoxPin1;
        private Button btnConfirm;
        private Button btnCancel;
        private RadioButton radBtnBartender;
        private RadioButton radBtnChef;
        private RadioButton radBtnWaiter;
        private Label lblConfirmPinCode;
        private Label lblPinCode;
        private Label lblOccupation;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private PictureBox pictureBox1;
        private Label lblHeading;
    }
}