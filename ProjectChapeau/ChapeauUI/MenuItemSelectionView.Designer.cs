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
            btnDrinks = new Button();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            btnReturn = new Button();
            btnMainDishes = new Button();
            btnStarters = new Button();
            btnDesserts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(229, 234, 250);
            btnDrinks.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDrinks.Location = new Point(219, 181);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(395, 147);
            btnDrinks.TabIndex = 0;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnViewAllItems_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(483, 67);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "Menu Item Selection";
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
            btnReturn.BackColor = Color.FromArgb(204, 68, 75);
            btnReturn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.Location = new Point(52, 872);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(199, 81);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMainDishes
            // 
            btnMainDishes.BackColor = Color.FromArgb(229, 234, 250);
            btnMainDishes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainDishes.Location = new Point(219, 518);
            btnMainDishes.Name = "btnMainDishes";
            btnMainDishes.Size = new Size(395, 147);
            btnMainDishes.TabIndex = 8;
            btnMainDishes.Text = "Main Dishes";
            btnMainDishes.UseVisualStyleBackColor = false;
            // 
            // btnStarters
            // 
            btnStarters.BackColor = Color.FromArgb(229, 234, 250);
            btnStarters.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStarters.Location = new Point(219, 352);
            btnStarters.Name = "btnStarters";
            btnStarters.Size = new Size(395, 147);
            btnStarters.TabIndex = 9;
            btnStarters.Text = "Starters";
            btnStarters.UseVisualStyleBackColor = false;
            // 
            // btnDesserts
            // 
            btnDesserts.BackColor = Color.FromArgb(229, 234, 250);
            btnDesserts.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDesserts.Location = new Point(219, 683);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(395, 147);
            btnDesserts.TabIndex = 10;
            btnDesserts.Text = "Desserts";
            btnDesserts.UseVisualStyleBackColor = false;
            // 
            // MenuItemSelectionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(836, 1055);
            Controls.Add(btnDesserts);
            Controls.Add(btnStarters);
            Controls.Add(btnMainDishes);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Controls.Add(btnDrinks);
            Name = "MenuItemSelectionView";
            Text = "MenuItemSelectionView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrinks;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Button btnReturn;
        private Button btnMainDishes;
        private Button btnStarters;
        private Button btnDesserts;
    }
}