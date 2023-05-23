namespace ChapeauUI
{
    partial class MenuItemSelectionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemSelectionView));
            btnViewAllItems = new Button();
            btnNewMenuItem = new Button();
            btmMainDishes = new Button();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewAllItems
            // 
            btnViewAllItems.BackColor = SystemColors.ActiveCaption;
            btnViewAllItems.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewAllItems.Location = new Point(219, 240);
            btnViewAllItems.Name = "btnViewAllItems";
            btnViewAllItems.Size = new Size(395, 147);
            btnViewAllItems.TabIndex = 0;
            btnViewAllItems.Text = "View all items";
            btnViewAllItems.UseVisualStyleBackColor = false;
            // 
            // btnNewMenuItem
            // 
            btnNewMenuItem.BackColor = Color.LawnGreen;
            btnNewMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewMenuItem.Location = new Point(219, 432);
            btnNewMenuItem.Name = "btnNewMenuItem";
            btnNewMenuItem.Size = new Size(395, 147);
            btnNewMenuItem.TabIndex = 1;
            btnNewMenuItem.Text = "Add menu item";
            btnNewMenuItem.UseVisualStyleBackColor = false;
            // 
            // btmMainDishes
            // 
            btmMainDishes.BackColor = Color.Red;
            btmMainDishes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmMainDishes.Location = new Point(219, 624);
            btmMainDishes.Name = "btmMainDishes";
            btmMainDishes.Size = new Size(395, 147);
            btmMainDishes.TabIndex = 2;
            btmMainDishes.Text = "Remove menu item";
            btmMainDishes.UseVisualStyleBackColor = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(373, 67);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "Menu Overview";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.LightCoral;
            btnReturn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.Location = new Point(52, 872);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(199, 81);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // MenuItemSelectionView
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
            Name = "MenuItemSelectionView";
            Text = "MenuItemSelectionView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewAllItems;
        private Button btnNewMenuItem;
        private Button btmMainDishes;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Button btnReturn;
    }
}