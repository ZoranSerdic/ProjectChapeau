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
            txtBoxName = new TextBox();
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
            btnAddItem.Location = new Point(87, 639);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(118, 29);
            btnAddItem.TabIndex = 42;
            btnAddItem.Text = "Add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(369, 639);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(112, 29);
            btnEditItem.TabIndex = 43;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(630, 639);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(117, 29);
            btnRemoveItem.TabIndex = 44;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // panelAdd
            // 
            panelAdd.BackColor = SystemColors.ActiveCaption;
            panelAdd.Controls.Add(lblPanelHeading);
            panelAdd.Controls.Add(btnCancel);
            panelAdd.Controls.Add(btnConfirm);
            panelAdd.Controls.Add(txtBoxCount);
            panelAdd.Controls.Add(txtBoxName);
            panelAdd.Controls.Add(lblCount);
            panelAdd.Controls.Add(lblName);
            panelAdd.Location = new Point(87, 626);
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
            txtBoxCount.Location = new Point(360, 103);
            txtBoxCount.Name = "txtBoxCount";
            txtBoxCount.Size = new Size(125, 27);
            txtBoxCount.TabIndex = 3;
            txtBoxCount.TextChanged += txtBoxCount_TextChanged;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(44, 103);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 27);
            txtBoxName.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(360, 63);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(51, 20);
            lblCount.TabIndex = 1;
            lblCount.Text = "Count:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(44, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Item Name:";
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
        private TextBox txtBoxName;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblPanelHeading;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel1;
    }
}