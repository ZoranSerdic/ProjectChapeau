namespace ChapeauUI
{
    partial class RemoveMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveMenuItem));
            listViewItemsList = new ListView();
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            btnReturn = new Button();
            btnRemove = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listViewItemsList
            // 
            listViewItemsList.FullRowSelect = true;
            listViewItemsList.Location = new Point(21, 192);
            listViewItemsList.Name = "listViewItemsList";
            listViewItemsList.Size = new Size(794, 497);
            listViewItemsList.TabIndex = 19;
            listViewItemsList.UseCompatibleStateImageBehavior = false;
            listViewItemsList.View = View.Details;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(229, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(460, 67);
            lblHeading.TabIndex = 17;
            lblHeading.Text = "Remove Menu Item";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(48, 827);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(192, 84);
            btnReturn.TabIndex = 21;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(566, 827);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(170, 84);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove selected Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 10);
            panel1.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(0, 1017);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 46);
            panel3.TabIndex = 55;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 10);
            panel5.TabIndex = 50;
            // 
            // RemoveMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnRemove);
            Controls.Add(btnReturn);
            Controls.Add(listViewItemsList);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "RemoveMenuItem";
            Text = "RemoveMenuItem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewItemsList;
        private PictureBox pictureBox1;
        private Label lblHeading;
        private Button btnReturn;
        private Button btnRemove;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
    }
}