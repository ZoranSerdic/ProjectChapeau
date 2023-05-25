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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.Location = new Point(30, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(285, 64);
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
            // 
            // MenuOverviewView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(836, 1055);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Controls.Add(btmMainDishes);
            Controls.Add(btnNewMenuItem);
            Controls.Add(btnViewAllItems);
            Name = "MenuOverviewView";
            Text = "MenuOverviewView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}