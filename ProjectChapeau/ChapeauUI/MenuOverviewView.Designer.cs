namespace ChapeauUI
{
    partial class MenuOverviewView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOverviewView));
            btnReturn = new Button();
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            btmMainDishes = new Button();
            btnNewMenuItem = new Button();
            btnViewAllItems = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.LightCoral;
            btnReturn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.Location = new Point(70, 903);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(199, 81);
            btnReturn.TabIndex = 13;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(259, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(373, 67);
            lblHeading.TabIndex = 11;
            lblHeading.Text = "Menu Overview";
            // 
            // btmMainDishes
            // 
            btmMainDishes.BackColor = Color.FromArgb(237, 122, 122);
            btmMainDishes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmMainDishes.Location = new Point(237, 655);
            btmMainDishes.Name = "btmMainDishes";
            btmMainDishes.Size = new Size(395, 147);
            btmMainDishes.TabIndex = 10;
            btmMainDishes.Text = "Remove menu item";
            btmMainDishes.UseVisualStyleBackColor = false;
            btmMainDishes.Click += btmMainDishes_Click;
            // 
            // btnNewMenuItem
            // 
            btnNewMenuItem.BackColor = Color.FromArgb(135, 227, 78);
            btnNewMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewMenuItem.Location = new Point(237, 463);
            btnNewMenuItem.Name = "btnNewMenuItem";
            btnNewMenuItem.Size = new Size(395, 147);
            btnNewMenuItem.TabIndex = 9;
            btnNewMenuItem.Text = "Add menu item";
            btnNewMenuItem.UseVisualStyleBackColor = false;
            btnNewMenuItem.Click += btnNewMenuItem_Click;
            // 
            // btnViewAllItems
            // 
            btnViewAllItems.BackColor = Color.FromArgb(229, 234, 250);
            btnViewAllItems.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewAllItems.Location = new Point(237, 271);
            btnViewAllItems.Name = "btnViewAllItems";
            btnViewAllItems.Size = new Size(395, 147);
            btnViewAllItems.TabIndex = 8;
            btnViewAllItems.Text = "View all items";
            btnViewAllItems.UseVisualStyleBackColor = false;
            btnViewAllItems.Click += btnViewAllItems_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(1, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 10);
            panel1.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(1, 1018);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(1, 118);
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
            // MenuOverviewView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(836, 1055);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Controls.Add(btmMainDishes);
            Controls.Add(btnNewMenuItem);
            Controls.Add(btnViewAllItems);
            Name = "MenuOverviewView";
            Text = "MenuOverviewView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private PictureBox pictureBox1;
        private Label lblHeading;
        private Button btmMainDishes;
        private Button btnNewMenuItem;
        private Button btnViewAllItems;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
    }
}