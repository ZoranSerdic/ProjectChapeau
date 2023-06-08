using System.Windows.Forms;

namespace ChapeauUI
{
    partial class TableView
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
            whiteBackground = new PictureBox();
            pictureBoxChapeauLogo = new PictureBox();
            pictureBoxRedSeparator = new PictureBox();
            labelSelectTable = new Label();
            labelDateTime = new Label();
            btnLogOut = new Button();
            labelOccupied = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelFree = new Label();
            ((System.ComponentModel.ISupportInitialize)whiteBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // whiteBackground
            // 
            whiteBackground.BackColor = Color.White;
            whiteBackground.Location = new Point(12, 114);
            whiteBackground.Name = "whiteBackground";
            whiteBackground.Size = new Size(508, 916);
            whiteBackground.TabIndex = 0;
            whiteBackground.TabStop = false;
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.BackColor = Color.Transparent;
            pictureBoxChapeauLogo.Image = Properties.Resources.chapeauIcon;
            pictureBoxChapeauLogo.Location = new Point(209, 10);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(125, 62);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxChapeauLogo.TabIndex = 1;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // pictureBoxRedSeparator
            // 
            pictureBoxRedSeparator.BackColor = Color.FromArgb(204, 68, 75);
            pictureBoxRedSeparator.Location = new Point(12, 78);
            pictureBoxRedSeparator.Name = "pictureBoxRedSeparator";
            pictureBoxRedSeparator.Size = new Size(508, 39);
            pictureBoxRedSeparator.TabIndex = 2;
            pictureBoxRedSeparator.TabStop = false;
            // 
            // labelSelectTable
            // 
            labelSelectTable.AutoSize = true;
            labelSelectTable.BackColor = Color.FromArgb(204, 68, 75);
            labelSelectTable.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectTable.ForeColor = Color.White;
            labelSelectTable.Location = new Point(193, 79);
            labelSelectTable.Name = "labelSelectTable";
            labelSelectTable.Size = new Size(141, 32);
            labelSelectTable.TabIndex = 3;
            labelSelectTable.Text = "Select Table";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateTime.Location = new Point(12, 47);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(0, 25);
            labelDateTime.TabIndex = 4;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightCoral;
            btnLogOut.Location = new Point(386, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(134, 49);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // labelOccupied
            // 
            labelOccupied.AutoSize = true;
            labelOccupied.BackColor = Color.White;
            labelOccupied.Location = new Point(242, 129);
            labelOccupied.Name = "labelOccupied";
            labelOccupied.Size = new Size(72, 20);
            labelOccupied.TabIndex = 6;
            labelOccupied.Text = "Occupied";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(204, 68, 75);
            pictureBox1.Location = new Point(221, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 14);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(16, 115, 26);
            pictureBox2.Location = new Point(221, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 14);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // labelFree
            // 
            labelFree.AutoSize = true;
            labelFree.BackColor = Color.White;
            labelFree.Location = new Point(242, 149);
            labelFree.Name = "labelFree";
            labelFree.Size = new Size(37, 20);
            labelFree.TabIndex = 9;
            labelFree.Text = "Free";
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 250);
            ClientSize = new Size(538, 1055);
            Controls.Add(labelFree);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelOccupied);
            Controls.Add(btnLogOut);
            Controls.Add(labelDateTime);
            Controls.Add(labelSelectTable);
            Controls.Add(pictureBoxRedSeparator);
            Controls.Add(pictureBoxChapeauLogo);
            Controls.Add(whiteBackground);
            Name = "TableView";
            Text = "Table View";
            Load += TableView_Load;
            ((System.ComponentModel.ISupportInitialize)whiteBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox whiteBackground;
        private PictureBox pictureBoxChapeauLogo;
        private PictureBox pictureBoxRedSeparator;
        private Label labelSelectTable;
        private Label labelDateTime;
        private Button btnLogOut;
        private Label labelOccupied;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelFree;
    }
}