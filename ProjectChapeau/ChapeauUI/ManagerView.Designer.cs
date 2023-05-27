namespace ChapeauUI
{
    partial class ManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerView));
            btnStock = new Button();
            btnMenu = new Button();
            btnEmployees = new Button();
            btnTableOverview = new Button();
            btnLogOut = new Button();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.ActiveCaption;
            btnStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(189, 254);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(448, 133);
            btnStock.TabIndex = 0;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(189, 410);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(448, 133);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = SystemColors.ActiveCaption;
            btnEmployees.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.Location = new Point(189, 568);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(448, 133);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnTableOverview
            // 
            btnTableOverview.BackColor = SystemColors.ActiveCaption;
            btnTableOverview.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableOverview.Location = new Point(189, 731);
            btnTableOverview.Name = "btnTableOverview";
            btnTableOverview.Size = new Size(448, 133);
            btnTableOverview.TabIndex = 3;
            btnTableOverview.Text = "Table Overview";
            btnTableOverview.UseVisualStyleBackColor = false;
            btnTableOverview.Click += btnTableOverview_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightCoral;
            btnLogOut.Location = new Point(688, 53);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(338, 36);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(173, 67);
            lblHeading.TabIndex = 5;
            lblHeading.Text = "HOME";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 105);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ManagerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(836, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Controls.Add(btnLogOut);
            Controls.Add(btnTableOverview);
            Controls.Add(btnEmployees);
            Controls.Add(btnMenu);
            Controls.Add(btnStock);
            Name = "ManagerView";
            Text = "ManagerView";
            Load += ManagerView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStock;
        private Button btnMenu;
        private Button btnEmployees;
        private Button btnTableOverview;
        private Button btnLogOut;
        private Label lblHeading;
        private PictureBox pictureBox1;
    }
}