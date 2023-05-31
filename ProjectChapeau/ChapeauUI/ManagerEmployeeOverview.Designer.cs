namespace ChapeauUI
{
    partial class ManagerEmployeeOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerEmployeeOverview));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            btnReturn = new Button();
            btnAddNewEmployee = new Button();
            BtnEditEmployee = new Button();
            BtnRemoveEmployee = new Button();
            listViewEmployees = new ListView();
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
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(460, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "Employee Overview";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(204, 68, 75);
            btnReturn.Location = new Point(56, 886);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(183, 132);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Return Home";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddNewEmployee
            // 
            btnAddNewEmployee.BackColor = Color.FromArgb(135, 227, 78);
            btnAddNewEmployee.Location = new Point(56, 683);
            btnAddNewEmployee.Name = "btnAddNewEmployee";
            btnAddNewEmployee.Size = new Size(154, 84);
            btnAddNewEmployee.TabIndex = 16;
            btnAddNewEmployee.Text = "Add new staff member";
            btnAddNewEmployee.UseVisualStyleBackColor = false;
            btnAddNewEmployee.Click += btnAddNewEmployee_Click;
            // 
            // BtnEditEmployee
            // 
            BtnEditEmployee.Location = new Point(353, 683);
            BtnEditEmployee.Name = "BtnEditEmployee";
            BtnEditEmployee.Size = new Size(136, 84);
            BtnEditEmployee.TabIndex = 17;
            BtnEditEmployee.Text = "Edit selected employee";
            BtnEditEmployee.UseVisualStyleBackColor = true;
            BtnEditEmployee.Click += BtnEditEmployee_Click;
            // 
            // BtnRemoveEmployee
            // 
            BtnRemoveEmployee.BackColor = Color.FromArgb(237, 122, 122);
            BtnRemoveEmployee.Location = new Point(633, 683);
            BtnRemoveEmployee.Name = "BtnRemoveEmployee";
            BtnRemoveEmployee.Size = new Size(141, 84);
            BtnRemoveEmployee.TabIndex = 19;
            BtnRemoveEmployee.Text = "Remove selected employee";
            BtnRemoveEmployee.UseVisualStyleBackColor = false;
            BtnRemoveEmployee.Click += BtnRemoveEmployee_Click;
            // 
            // listViewEmployees
            // 
            listViewEmployees.FullRowSelect = true;
            listViewEmployees.Location = new Point(56, 186);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(718, 421);
            listViewEmployees.TabIndex = 20;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            // 
            // ManagerEmployeeOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(listViewEmployees);
            Controls.Add(BtnRemoveEmployee);
            Controls.Add(BtnEditEmployee);
            Controls.Add(btnAddNewEmployee);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "ManagerEmployeeOverview";
            Text = "ManagerEmployeeOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Button btnReturn;
        private Button btnAddNewEmployee;
        private Button BtnEditEmployee;
        private Button BtnRemoveEmployee;
        private ListView listViewEmployees;
    }
}