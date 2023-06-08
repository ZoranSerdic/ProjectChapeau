namespace ChapeauUI
{
    partial class MenuViewAllItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuViewAllItems));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            btnReturn = new Button();
            listViewMenuItems = new ListView();
            btnEditMenuItem = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnAdd = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
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
            lblHeading.Location = new Point(229, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(577, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "All Menu Items Overview";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(37, 918);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(153, 78);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // listViewMenuItems
            // 
            listViewMenuItems.FullRowSelect = true;
            listViewMenuItems.Location = new Point(12, 195);
            listViewMenuItems.Name = "listViewMenuItems";
            listViewMenuItems.Size = new Size(794, 497);
            listViewMenuItems.TabIndex = 16;
            listViewMenuItems.UseCompatibleStateImageBehavior = false;
            listViewMenuItems.View = View.Details;
            // 
            // btnEditMenuItem
            // 
            btnEditMenuItem.Location = new Point(346, 747);
            btnEditMenuItem.Name = "btnEditMenuItem";
            btnEditMenuItem.Size = new Size(180, 97);
            btnEditMenuItem.TabIndex = 17;
            btnEditMenuItem.Text = "Edit selected menu item";
            btnEditMenuItem.UseVisualStyleBackColor = true;
            btnEditMenuItem.Click += btnEditMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(2, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 10);
            panel1.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(2, 1018);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(2, 118);
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
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 755);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 89);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Add new item ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(633, 751);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(174, 97);
            btnRemove.TabIndex = 58;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // MenuViewAllItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnEditMenuItem);
            Controls.Add(btnReturn);
            Controls.Add(listViewMenuItems);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "MenuViewAllItems";
            Text = "MenuViewAllItems";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Button btnReturn;
        private ListView listViewMenuItems;
        private Button btnEditMenuItem;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Button btnAdd;
        private Button btnRemove;
    }
}