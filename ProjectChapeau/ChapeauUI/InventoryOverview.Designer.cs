namespace ChapeauUI
{
    partial class InventoryOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryOverview));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            listViewInventory = new ListView();
            btnReturn = new Button();
            btnAddItem = new Button();
            btnEditItem = new Button();
            btnRemoveItem = new Button();
            panelAdd = new Panel();
            lblPanelHeading = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            txtBoxCount = new TextBox();
            txtBoxMenuId = new TextBox();
            lblCount = new Label();
            lblName = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAdd.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(365, 67);
            lblHeading.TabIndex = 38;
            lblHeading.Text = "Stock Overview";
            // 
            // listViewInventory
            // 
            listViewInventory.FullRowSelect = true;
            listViewInventory.Location = new Point(87, 172);
            listViewInventory.Name = "listViewInventory";
            listViewInventory.Size = new Size(675, 421);
            listViewInventory.TabIndex = 40;
            listViewInventory.UseCompatibleStateImageBehavior = false;
            listViewInventory.View = View.Details;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(47, 904);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(170, 89);
            btnReturn.TabIndex = 41;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(135, 227, 78);
            btnAddItem.Location = new Point(87, 639);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(146, 85);
            btnAddItem.TabIndex = 42;
            btnAddItem.Text = "Add item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(369, 639);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(129, 85);
            btnEditItem.TabIndex = 43;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(237, 122, 122);
            btnRemoveItem.Location = new Point(613, 639);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(134, 85);
            btnRemoveItem.TabIndex = 44;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // panelAdd
            // 
            panelAdd.BackColor = SystemColors.ActiveCaption;
            panelAdd.Controls.Add(lblPanelHeading);
            panelAdd.Controls.Add(btnCancel);
            panelAdd.Controls.Add(btnConfirm);
            panelAdd.Controls.Add(txtBoxCount);
            panelAdd.Controls.Add(txtBoxMenuId);
            panelAdd.Controls.Add(lblCount);
            panelAdd.Controls.Add(lblName);
            panelAdd.Location = new Point(87, 639);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(690, 228);
            panelAdd.TabIndex = 45;
            // 
            // lblPanelHeading
            // 
            lblPanelHeading.AutoSize = true;
            lblPanelHeading.Location = new Point(44, 13);
            lblPanelHeading.Name = "lblPanelHeading";
            lblPanelHeading.Size = new Size(191, 20);
            lblPanelHeading.TabIndex = 6;
            lblPanelHeading.Text = "Please fill in the entire form";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(44, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(360, 166);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtBoxCount
            // 
            txtBoxCount.Location = new Point(44, 105);
            txtBoxCount.Name = "txtBoxCount";
            txtBoxCount.Size = new Size(125, 27);
            txtBoxCount.TabIndex = 3;
            txtBoxCount.TextChanged += txtBoxCount_TextChanged;
            // 
            // txtBoxMenuId
            // 
            txtBoxMenuId.Location = new Point(323, 105);
            txtBoxMenuId.Name = "txtBoxMenuId";
            txtBoxMenuId.Size = new Size(125, 27);
            txtBoxMenuId.TabIndex = 2;
            txtBoxMenuId.TextChanged += txtBoxMenuId_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(44, 65);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 1;
            lblCount.Text = "Count:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(323, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Menu Item ID:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(1, 1021);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(1, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 46);
            panel3.TabIndex = 52;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 10);
            panel5.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(1, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 10);
            panel1.TabIndex = 51;
            // 
            // InventoryOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(836, 1055);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelAdd);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnEditItem);
            Controls.Add(btnAddItem);
            Controls.Add(btnReturn);
            Controls.Add(listViewInventory);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "InventoryOverview";
            Text = "InventoryOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private ListView listViewInventory;
        private Button btnReturn;
        private Button btnAddItem;
        private Button btnEditItem;
        private Button btnRemoveItem;
        private Panel panelAdd;
        private Label lblCount;
        private Label lblName;
        private TextBox txtBoxCount;
        private TextBox txtBoxMenuId;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblPanelHeading;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel1;
    }
}