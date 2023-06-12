namespace ChapeauUI
{
    partial class Login
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
            pictureBoxChapeauLogo = new PictureBox();
            label_welcome = new Label();
            pictureBoxRedSeparator = new PictureBox();
            pictureBoxBlueBackground = new PictureBox();
            label_login = new Label();
            textBox_login_name = new TextBox();
            button_login = new Button();
            label_login_name = new Label();
            textBox_login_pincode = new TextBox();
            label_login_pincode = new Label();
            label_login_forgotPincode = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlueBackground).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.BackColor = Color.Transparent;
            pictureBoxChapeauLogo.Image = Properties.Resources.chapeauIcon;
            pictureBoxChapeauLogo.Location = new Point(0, 31);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(192, 119);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxChapeauLogo.TabIndex = 2;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcome.Location = new Point(107, 192);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(321, 50);
            label_welcome.TabIndex = 3;
            label_welcome.Text = "WELCOME BACK!";
            // 
            // pictureBoxRedSeparator
            // 
            pictureBoxRedSeparator.BackColor = Color.FromArgb(204, 68, 75);
            pictureBoxRedSeparator.Location = new Point(-9, 0);
            pictureBoxRedSeparator.Name = "pictureBoxRedSeparator";
            pictureBoxRedSeparator.Size = new Size(556, 25);
            pictureBoxRedSeparator.TabIndex = 4;
            pictureBoxRedSeparator.TabStop = false;
            // 
            // pictureBoxBlueBackground
            // 
            pictureBoxBlueBackground.BackColor = Color.FromArgb(229, 234, 250);
            pictureBoxBlueBackground.Location = new Point(71, 272);
            pictureBoxBlueBackground.Name = "pictureBoxBlueBackground";
            pictureBoxBlueBackground.Size = new Size(402, 451);
            pictureBoxBlueBackground.TabIndex = 5;
            pictureBoxBlueBackground.TabStop = false;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = Color.FromArgb(229, 234, 250);
            label_login.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_login.Location = new Point(211, 298);
            label_login.Name = "label_login";
            label_login.Size = new Size(118, 46);
            label_login.TabIndex = 6;
            label_login.Text = "LOGIN";
            // 
            // textBox_login_name
            // 
            textBox_login_name.Location = new Point(128, 428);
            textBox_login_name.Name = "textBox_login_name";
            textBox_login_name.Size = new Size(201, 27);
            textBox_login_name.TabIndex = 7;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(16, 115, 26);
            button_login.Location = new Point(139, 618);
            button_login.Name = "button_login";
            button_login.Size = new Size(268, 47);
            button_login.TabIndex = 8;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            // 
            // label_login_name
            // 
            label_login_name.AutoSize = true;
            label_login_name.BackColor = Color.FromArgb(229, 234, 250);
            label_login_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_login_name.Location = new Point(128, 386);
            label_login_name.Name = "label_login_name";
            label_login_name.Size = new Size(64, 28);
            label_login_name.TabIndex = 9;
            label_login_name.Text = "Name";
            // 
            // textBox_login_pincode
            // 
            textBox_login_pincode.Location = new Point(128, 527);
            textBox_login_pincode.Name = "textBox_login_pincode";
            textBox_login_pincode.Size = new Size(201, 27);
            textBox_login_pincode.TabIndex = 10;
            // 
            // label_login_pincode
            // 
            label_login_pincode.AutoSize = true;
            label_login_pincode.BackColor = Color.FromArgb(229, 234, 250);
            label_login_pincode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_login_pincode.Location = new Point(128, 485);
            label_login_pincode.Name = "label_login_pincode";
            label_login_pincode.Size = new Size(82, 28);
            label_login_pincode.TabIndex = 11;
            label_login_pincode.Text = "Pincode";
            // 
            // label_login_forgotPincode
            // 
            label_login_forgotPincode.AutoSize = true;
            label_login_forgotPincode.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label_login_forgotPincode.Location = new Point(171, 871);
            label_login_forgotPincode.Name = "label_login_forgotPincode";
            label_login_forgotPincode.Size = new Size(191, 31);
            label_login_forgotPincode.TabIndex = 12;
            label_login_forgotPincode.Text = "Forgot pin code?";
            label_login_forgotPincode.Click += label_login_forgotPincode_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 1055);
            Controls.Add(label_login_forgotPincode);
            Controls.Add(label_login_pincode);
            Controls.Add(textBox_login_pincode);
            Controls.Add(label_login_name);
            Controls.Add(button_login);
            Controls.Add(textBox_login_name);
            Controls.Add(label_login);
            Controls.Add(pictureBoxBlueBackground);
            Controls.Add(pictureBoxRedSeparator);
            Controls.Add(label_welcome);
            Controls.Add(pictureBoxChapeauLogo);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlueBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxChapeauLogo;
        private Label label_welcome;
        private PictureBox pictureBoxRedSeparator;
        private PictureBox pictureBoxBlueBackground;
        private Label label_login;
        private TextBox textBox_login_name;
        private Button button_login;
        private Label label_login_name;
        private TextBox textBox_login_pincode;
        private Label label_login_pincode;
        private Label label_login_forgotPincode;
    }
}