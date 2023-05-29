namespace ChapeauUI
{
    partial class NewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployee));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            lblOccupation = new Label();
            lblPinCode = new Label();
            lblConfirmPinCode = new Label();
            radBtnWaiter = new RadioButton();
            radBtnChef = new RadioButton();
            radBtnBartender = new RadioButton();
            numPin1 = new NumericUpDown();
            numPin2 = new NumericUpDown();
            btnCancel = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPin2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(229, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(491, 67);
            lblHeading.TabIndex = 15;
            lblHeading.Text = "Add a new employee";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(76, 199);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(339, 199);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last Name";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(76, 254);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(125, 27);
            txtBoxFirstName.TabIndex = 19;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(339, 254);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(125, 27);
            txtBoxLastName.TabIndex = 20;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(76, 372);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(88, 20);
            lblOccupation.TabIndex = 21;
            lblOccupation.Text = "Occupation:";
            // 
            // lblPinCode
            // 
            lblPinCode.AutoSize = true;
            lblPinCode.Location = new Point(76, 549);
            lblPinCode.Name = "lblPinCode";
            lblPinCode.Size = new Size(71, 20);
            lblPinCode.TabIndex = 22;
            lblPinCode.Text = "Pin Code:";
            // 
            // lblConfirmPinCode
            // 
            lblConfirmPinCode.AutoSize = true;
            lblConfirmPinCode.Location = new Point(339, 549);
            lblConfirmPinCode.Name = "lblConfirmPinCode";
            lblConfirmPinCode.Size = new Size(126, 20);
            lblConfirmPinCode.TabIndex = 23;
            lblConfirmPinCode.Text = "Confirm Pin code:";
            // 
            // radBtnWaiter
            // 
            radBtnWaiter.AutoSize = true;
            radBtnWaiter.Location = new Point(76, 433);
            radBtnWaiter.Name = "radBtnWaiter";
            radBtnWaiter.Size = new Size(73, 24);
            radBtnWaiter.TabIndex = 24;
            radBtnWaiter.TabStop = true;
            radBtnWaiter.Text = "Waiter";
            radBtnWaiter.UseVisualStyleBackColor = true;
            // 
            // radBtnChef
            // 
            radBtnChef.AutoSize = true;
            radBtnChef.Location = new Point(339, 433);
            radBtnChef.Name = "radBtnChef";
            radBtnChef.Size = new Size(60, 24);
            radBtnChef.TabIndex = 25;
            radBtnChef.TabStop = true;
            radBtnChef.Text = "Chef";
            radBtnChef.UseVisualStyleBackColor = true;
            // 
            // radBtnBartender
            // 
            radBtnBartender.AutoSize = true;
            radBtnBartender.Location = new Point(567, 433);
            radBtnBartender.Name = "radBtnBartender";
            radBtnBartender.Size = new Size(95, 24);
            radBtnBartender.TabIndex = 26;
            radBtnBartender.TabStop = true;
            radBtnBartender.Text = "Bartender";
            radBtnBartender.UseVisualStyleBackColor = true;
            // 
            // numPin1
            // 
            numPin1.Location = new Point(76, 600);
            numPin1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numPin1.Name = "numPin1";
            numPin1.Size = new Size(150, 27);
            numPin1.TabIndex = 27;
            // 
            // numPin2
            // 
            numPin2.Location = new Point(339, 600);
            numPin2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numPin2.Name = "numPin2";
            numPin2.Size = new Size(150, 27);
            numPin2.TabIndex = 28;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(132, 728);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(543, 728);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 30;
            btnConfirm.Text = "confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // NewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(numPin2);
            Controls.Add(numPin1);
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
            Name = "NewEmployee";
            Text = "NewEmployee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private Label lblOccupation;
        private Label lblPinCode;
        private Label lblConfirmPinCode;
        private RadioButton radBtnWaiter;
        private RadioButton radBtnChef;
        private RadioButton radBtnBartender;
        private NumericUpDown numPin1;
        private NumericUpDown numPin2;
        private Button btnCancel;
        private Button btnConfirm;
    }
}