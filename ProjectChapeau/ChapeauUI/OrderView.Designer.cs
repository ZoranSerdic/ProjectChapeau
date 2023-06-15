namespace ChapeauUI
{
    partial class OrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            labelTableNumber = new Label();
            panelMenuBackground = new Panel();
            labelMenuSeparator = new Label();
            labelMenuTime = new Label();
            labelMenuType = new Label();
            panelGreenSeparatorOne = new Panel();
            panelGreenSeparatorTwo = new Panel();
            panelGreenSeparatorThree = new Panel();
            pictureBoxChapeauLogo = new PictureBox();
            buttonCategoryStarters = new Button();
            buttonCategoryMainDish = new Button();
            buttonCategoryDesserts = new Button();
            buttonCategoryDrinks = new Button();
            buttonSwitchMenu = new Button();
            buttonCloseOrder = new Button();
            buttonFinaliseOrder = new Button();
            panelWhiteButtonBackground = new Panel();
            listViewMenuItems = new ListView();
            columnName = new ColumnHeader();
            columnDescription = new ColumnHeader();
            panelMenuBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChapeauLogo).BeginInit();
            panelWhiteButtonBackground.SuspendLayout();
            SuspendLayout();

            
            // 
            // labelTableNumber
            // 
            labelTableNumber.AutoSize = true;
            labelTableNumber.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTableNumber.Location = new Point(61, 9);
            labelTableNumber.Name = "labelTableNumber";
            labelTableNumber.Size = new Size(129, 45);
            labelTableNumber.TabIndex = 0;
            labelTableNumber.Text = "Table 1";
            labelTableNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMenuBackground
            // 
            panelMenuBackground.BackColor = Color.FromArgb(204, 68, 75);
            panelMenuBackground.Controls.Add(labelMenuSeparator);
            panelMenuBackground.Controls.Add(labelMenuTime);
            panelMenuBackground.Controls.Add(labelMenuType);
            panelMenuBackground.Location = new Point(12, 69);
            panelMenuBackground.Name = "panelMenuBackground";
            panelMenuBackground.Size = new Size(508, 41);
            panelMenuBackground.TabIndex = 1;
            // 
            // labelMenuSeparator
            // 
            labelMenuSeparator.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelMenuSeparator.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuSeparator.ForeColor = SystemColors.ControlLightLight;
            labelMenuSeparator.Location = new Point(242, -4);
            labelMenuSeparator.Name = "labelMenuSeparator";
            labelMenuSeparator.RightToLeft = RightToLeft.No;
            labelMenuSeparator.Size = new Size(25, 40);
            labelMenuSeparator.TabIndex = 4;
            labelMenuSeparator.Text = "-";
            labelMenuSeparator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMenuTime
            // 
            labelMenuTime.Anchor = AnchorStyles.Right;
            labelMenuTime.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuTime.ForeColor = SystemColors.ControlLightLight;
            labelMenuTime.Location = new Point(268, -4);
            labelMenuTime.Name = "labelMenuTime";
            labelMenuTime.RightToLeft = RightToLeft.No;
            labelMenuTime.Size = new Size(240, 40);
            labelMenuTime.TabIndex = 3;
            labelMenuTime.Text = "Lunch";
            labelMenuTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMenuType
            // 
            labelMenuType.Anchor = AnchorStyles.Left;
            labelMenuType.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenuType.ForeColor = SystemColors.ControlLightLight;
            labelMenuType.Location = new Point(0, -4);
            labelMenuType.Name = "labelMenuType";
            labelMenuType.RightToLeft = RightToLeft.No;
            labelMenuType.Size = new Size(240, 40);
            labelMenuType.TabIndex = 2;
            labelMenuType.Text = "Starters";
            labelMenuType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelGreenSeparatorOne
            // 
            panelGreenSeparatorOne.BackColor = Color.FromArgb(16, 115, 26);
            panelGreenSeparatorOne.Location = new Point(0, 113);
            panelGreenSeparatorOne.Name = "panelGreenSeparatorOne";
            panelGreenSeparatorOne.Size = new Size(532, 11);
            panelGreenSeparatorOne.TabIndex = 2;
            // 
            // panelGreenSeparatorTwo
            // 
            panelGreenSeparatorTwo.BackColor = Color.FromArgb(16, 115, 26);
            panelGreenSeparatorTwo.Location = new Point(0, 657);
            panelGreenSeparatorTwo.Name = "panelGreenSeparatorTwo";
            panelGreenSeparatorTwo.Size = new Size(532, 11);
            panelGreenSeparatorTwo.TabIndex = 3;
            // 
            // panelGreenSeparatorThree
            // 
            panelGreenSeparatorThree.BackColor = Color.FromArgb(16, 115, 26);
            panelGreenSeparatorThree.Location = new Point(0, 810);
            panelGreenSeparatorThree.Name = "panelGreenSeparatorThree";
            panelGreenSeparatorThree.Size = new Size(532, 11);
            panelGreenSeparatorThree.TabIndex = 4;
            // 
            // pictureBoxChapeauLogo
            // 
            pictureBoxChapeauLogo.BackColor = Color.Transparent;
            pictureBoxChapeauLogo.Image = (Image)resources.GetObject("pictureBoxChapeauLogo.Image");
            pictureBoxChapeauLogo.Location = new Point(210, 7);
            pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            pictureBoxChapeauLogo.Size = new Size(102, 58);
            pictureBoxChapeauLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxChapeauLogo.TabIndex = 17;
            pictureBoxChapeauLogo.TabStop = false;
            // 
            // buttonCategoryStarters
            // 
            buttonCategoryStarters.AutoSize = true;
            buttonCategoryStarters.BackColor = Color.FromArgb(57, 67, 183);
            buttonCategoryStarters.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategoryStarters.ForeColor = SystemColors.ControlLightLight;
            buttonCategoryStarters.Location = new Point(30, 14);
            buttonCategoryStarters.Name = "buttonCategoryStarters";
            buttonCategoryStarters.Size = new Size(222, 64);
            buttonCategoryStarters.TabIndex = 18;
            buttonCategoryStarters.Text = "Starters";
            buttonCategoryStarters.UseVisualStyleBackColor = false;
            buttonCategoryStarters.Click += buttonCategoryStarters_Click;
            // 
            // buttonCategoryMainDish
            // 
            buttonCategoryMainDish.AutoSize = true;
            buttonCategoryMainDish.BackColor = Color.FromArgb(57, 67, 183);
            buttonCategoryMainDish.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategoryMainDish.ForeColor = SystemColors.ControlLightLight;
            buttonCategoryMainDish.Location = new Point(280, 14);
            buttonCategoryMainDish.Name = "buttonCategoryMainDish";
            buttonCategoryMainDish.Size = new Size(222, 64);
            buttonCategoryMainDish.TabIndex = 19;
            buttonCategoryMainDish.Text = "Main Dish";
            buttonCategoryMainDish.UseVisualStyleBackColor = false;
            buttonCategoryMainDish.Click += buttonCategoryMainDish_Click;
            // 
            // buttonCategoryDesserts
            // 
            buttonCategoryDesserts.AutoSize = true;
            buttonCategoryDesserts.BackColor = Color.FromArgb(57, 67, 183);
            buttonCategoryDesserts.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategoryDesserts.ForeColor = SystemColors.ControlLightLight;
            buttonCategoryDesserts.Location = new Point(30, 80);
            buttonCategoryDesserts.Name = "buttonCategoryDesserts";
            buttonCategoryDesserts.Size = new Size(222, 64);
            buttonCategoryDesserts.TabIndex = 20;
            buttonCategoryDesserts.Text = "Desserts";
            buttonCategoryDesserts.UseVisualStyleBackColor = false;
            buttonCategoryDesserts.Click += buttonCategoryDesserts_Click;
            // 
            // buttonCategoryDrinks
            // 
            buttonCategoryDrinks.AutoSize = true;
            buttonCategoryDrinks.BackColor = Color.FromArgb(57, 67, 183);
            buttonCategoryDrinks.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategoryDrinks.ForeColor = SystemColors.ControlLightLight;
            buttonCategoryDrinks.Location = new Point(280, 80);
            buttonCategoryDrinks.Name = "buttonCategoryDrinks";
            buttonCategoryDrinks.Size = new Size(222, 64);
            buttonCategoryDrinks.TabIndex = 21;
            buttonCategoryDrinks.Text = "Drinks";
            buttonCategoryDrinks.UseVisualStyleBackColor = false;
            buttonCategoryDrinks.Click += buttonCategoryDrinks_Click;
            // 
            // buttonSwitchMenu
            // 
            buttonSwitchMenu.AutoSize = true;
            buttonSwitchMenu.BackColor = Color.FromArgb(57, 67, 183);
            buttonSwitchMenu.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSwitchMenu.ForeColor = SystemColors.ControlLightLight;
            buttonSwitchMenu.Location = new Point(64, 827);
            buttonSwitchMenu.Name = "buttonSwitchMenu";
            buttonSwitchMenu.Size = new Size(390, 56);
            buttonSwitchMenu.TabIndex = 22;
            buttonSwitchMenu.Text = "Switch To Dinner Menu";
            buttonSwitchMenu.UseVisualStyleBackColor = false;
            buttonSwitchMenu.Click += buttonSwitchMenu_Click;
            // 
            // buttonCloseOrder
            // 
            buttonCloseOrder.AutoSize = true;
            buttonCloseOrder.BackColor = Color.FromArgb(204, 68, 75);
            buttonCloseOrder.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseOrder.ForeColor = SystemColors.ControlLightLight;
            buttonCloseOrder.Location = new Point(12, 885);
            buttonCloseOrder.Name = "buttonCloseOrder";
            buttonCloseOrder.Size = new Size(217, 56);
            buttonCloseOrder.TabIndex = 23;
            buttonCloseOrder.Text = "Close Order";
            buttonCloseOrder.UseVisualStyleBackColor = false;
            buttonCloseOrder.Click += buttonCloseOrder_Click;
            // 
            // buttonFinaliseOrder
            // 
            buttonFinaliseOrder.AutoSize = true;
            buttonFinaliseOrder.BackColor = Color.FromArgb(16, 115, 26);
            buttonFinaliseOrder.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinaliseOrder.ForeColor = SystemColors.ControlLightLight;
            buttonFinaliseOrder.Location = new Point(268, 885);
            buttonFinaliseOrder.Name = "buttonFinaliseOrder";
            buttonFinaliseOrder.Size = new Size(252, 56);
            buttonFinaliseOrder.TabIndex = 0;
            buttonFinaliseOrder.Text = "Finalise Order";
            buttonFinaliseOrder.UseVisualStyleBackColor = false;
            buttonFinaliseOrder.Click += buttonFinaliseOrder_Click;
            // 
            // panelWhiteButtonBackground
            // 
            panelWhiteButtonBackground.BackColor = Color.White;
            panelWhiteButtonBackground.Controls.Add(buttonCategoryStarters);
            panelWhiteButtonBackground.Controls.Add(buttonCategoryMainDish);
            panelWhiteButtonBackground.Controls.Add(buttonCategoryDrinks);
            panelWhiteButtonBackground.Controls.Add(buttonCategoryDesserts);
            panelWhiteButtonBackground.Location = new Point(0, 660);
            panelWhiteButtonBackground.Name = "panelWhiteButtonBackground";
            panelWhiteButtonBackground.Size = new Size(532, 158);
            panelWhiteButtonBackground.TabIndex = 4;
            // 
            // listViewMenuItems
            // 
            listViewMenuItems.Columns.AddRange(new ColumnHeader[] { columnName, columnDescription });
            listViewMenuItems.FullRowSelect = true;
            listViewMenuItems.Location = new Point(12, 130);
            listViewMenuItems.MultiSelect = false;
            listViewMenuItems.Name = "listViewMenuItems";
            listViewMenuItems.Size = new Size(508, 527);
            listViewMenuItems.TabIndex = 24;
            listViewMenuItems.UseCompatibleStateImageBehavior = false;
            listViewMenuItems.View = View.Details;
            listViewMenuItems.ItemSelectionChanged += listViewMenuItems_ItemSelectionChanged;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 180;
            // 
            // columnDescription
            // 
            columnDescription.Text = "Description";
            columnDescription.Width = 300;
            // 

            

            //
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(532, 953);
            this.Controls.Add(this.buttonFinaliseOrder);
            this.Controls.Add(this.buttonCloseOrder);
            this.Controls.Add(this.buttonSwitchMenu);
            this.Controls.Add(this.pictureBoxChapeauLogo);
            this.Controls.Add(this.panelGreenSeparatorThree);
            this.Controls.Add(this.panelGreenSeparatorTwo);
            this.Controls.Add(this.panelGreenSeparatorOne);
            this.Controls.Add(this.listViewMenuItems);
            this.Controls.Add(this.panelWhiteButtonBackground);
            this.Controls.Add(this.panelMenuBackground);
            this.Controls.Add(this.labelTableNumber);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.panelMenuBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChapeauLogo)).EndInit();
            this.panelWhiteButtonBackground.ResumeLayout(false);
            this.panelWhiteButtonBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTableNumber;
        private Panel panelMenuBackground;
        private Label labelMenuType;
        private Label labelMenuTime;
        private Label labelMenuSeparator;
        private Panel panelGreenSeparatorOne;
        private Panel panelGreenSeparatorTwo;
        private Panel panelGreenSeparatorThree;
        private PictureBox pictureBoxChapeauLogo;
        private Button buttonCategoryStarters;
        private Button buttonCategoryMainDish;
        private Button buttonCategoryDesserts;
        private Button buttonCategoryDrinks;
        private Button buttonSwitchMenu;
        private Button buttonCloseOrder;
        private Button buttonFinaliseOrder;
        private Panel panelWhiteButtonBackground;
        private ListView listViewMenuItems;
        private ColumnHeader columnName;
        private ColumnHeader columnDescription;
    }
}