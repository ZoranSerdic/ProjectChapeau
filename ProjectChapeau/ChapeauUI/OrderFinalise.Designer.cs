namespace ChapeauUI
{
    partial class OrderFinalise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFinalise));
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBoxChapeauLogo = new System.Windows.Forms.PictureBox();
            this.panelGreenSeparatorThree = new System.Windows.Forms.Panel();
            this.panelGreenSeparatorTwo = new System.Windows.Forms.Panel();
            this.panelGreenSeparatorOne = new System.Windows.Forms.Panel();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderComment = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAmount = new System.Windows.Forms.ColumnHeader();
            this.labelMenuType = new System.Windows.Forms.Label();
            this.panelMenuBackground = new System.Windows.Forms.Panel();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.panelWhiteBackground = new System.Windows.Forms.Panel();
            this.labelInformationOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveAllOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChapeauLogo)).BeginInit();
            this.panelMenuBackground.SuspendLayout();
            this.panelWhiteBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.AutoSize = true;
            this.buttonConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.buttonConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmOrder.Location = new System.Drawing.Point(268, 873);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(254, 70);
            this.buttonConfirmOrder.TabIndex = 25;
            this.buttonConfirmOrder.Text = "Confirm Order";
            this.buttonConfirmOrder.UseVisualStyleBackColor = false;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.AutoSize = true;
            this.buttonGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGoBack.Location = new System.Drawing.Point(12, 873);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(217, 70);
            this.buttonGoBack.TabIndex = 34;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBoxChapeauLogo
            // 
            this.pictureBoxChapeauLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChapeauLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChapeauLogo.Image")));
            this.pictureBoxChapeauLogo.Location = new System.Drawing.Point(210, 9);
            this.pictureBoxChapeauLogo.Name = "pictureBoxChapeauLogo";
            this.pictureBoxChapeauLogo.Size = new System.Drawing.Size(102, 58);
            this.pictureBoxChapeauLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChapeauLogo.TabIndex = 32;
            this.pictureBoxChapeauLogo.TabStop = false;
            // 
            // panelGreenSeparatorThree
            // 
            this.panelGreenSeparatorThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.panelGreenSeparatorThree.Location = new System.Drawing.Point(0, 846);
            this.panelGreenSeparatorThree.Name = "panelGreenSeparatorThree";
            this.panelGreenSeparatorThree.Size = new System.Drawing.Size(532, 11);
            this.panelGreenSeparatorThree.TabIndex = 30;
            // 
            // panelGreenSeparatorTwo
            // 
            this.panelGreenSeparatorTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.panelGreenSeparatorTwo.Location = new System.Drawing.Point(0, 159);
            this.panelGreenSeparatorTwo.Name = "panelGreenSeparatorTwo";
            this.panelGreenSeparatorTwo.Size = new System.Drawing.Size(532, 11);
            this.panelGreenSeparatorTwo.TabIndex = 29;
            // 
            // panelGreenSeparatorOne
            // 
            this.panelGreenSeparatorOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.panelGreenSeparatorOne.Location = new System.Drawing.Point(0, 115);
            this.panelGreenSeparatorOne.Name = "panelGreenSeparatorOne";
            this.panelGreenSeparatorOne.Size = new System.Drawing.Size(532, 11);
            this.panelGreenSeparatorOne.TabIndex = 28;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderComment,
            this.columnHeaderAmount});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.Location = new System.Drawing.Point(12, 169);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(508, 602);
            this.listViewOrders.TabIndex = 35;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.ItemSelectionChanged += listViewOrders_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 160;
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Comment";
            this.columnHeaderComment.Width = 280;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Amount";
            // 
            // labelMenuType
            // 
            this.labelMenuType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMenuType.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMenuType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMenuType.Location = new System.Drawing.Point(3, 0);
            this.labelMenuType.Name = "labelMenuType";
            this.labelMenuType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMenuType.Size = new System.Drawing.Size(505, 40);
            this.labelMenuType.TabIndex = 2;
            this.labelMenuType.Text = "Finalise Order";
            this.labelMenuType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuBackground
            // 
            this.panelMenuBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.panelMenuBackground.Controls.Add(this.labelMenuType);
            this.panelMenuBackground.Location = new System.Drawing.Point(12, 71);
            this.panelMenuBackground.Name = "panelMenuBackground";
            this.panelMenuBackground.Size = new System.Drawing.Size(508, 41);
            this.panelMenuBackground.TabIndex = 27;
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTableNumber.Location = new System.Drawing.Point(61, 11);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(129, 45);
            this.labelTableNumber.TabIndex = 26;
            this.labelTableNumber.Text = "Table 1";
            // 
            // panelWhiteBackground
            // 
            this.panelWhiteBackground.BackColor = System.Drawing.Color.White;
            this.panelWhiteBackground.Controls.Add(this.labelInformationOrders);
            this.panelWhiteBackground.Location = new System.Drawing.Point(0, 125);
            this.panelWhiteBackground.Name = "panelWhiteBackground";
            this.panelWhiteBackground.Size = new System.Drawing.Size(532, 42);
            this.panelWhiteBackground.TabIndex = 36;
            // 
            // labelInformationOrders
            // 
            this.labelInformationOrders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInformationOrders.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInformationOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInformationOrders.Location = new System.Drawing.Point(-6, -6);
            this.labelInformationOrders.Name = "labelInformationOrders";
            this.labelInformationOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInformationOrders.Size = new System.Drawing.Size(526, 40);
            this.labelInformationOrders.TabIndex = 37;
            this.labelInformationOrders.Text = "Select an Order to remove it";
            this.labelInformationOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.panel1.Location = new System.Drawing.Point(1, 763);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 11);
            this.panel1.TabIndex = 31;
            // 
            // buttonRemoveAllOrders
            // 
            this.buttonRemoveAllOrders.AutoSize = true;
            this.buttonRemoveAllOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.buttonRemoveAllOrders.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveAllOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemoveAllOrders.Location = new System.Drawing.Point(106, 776);
            this.buttonRemoveAllOrders.Name = "buttonRemoveAllOrders";
            this.buttonRemoveAllOrders.Size = new System.Drawing.Size(313, 70);
            this.buttonRemoveAllOrders.TabIndex = 37;
            this.buttonRemoveAllOrders.Text = "Remove all Orders";
            this.buttonRemoveAllOrders.UseVisualStyleBackColor = false;
            this.buttonRemoveAllOrders.Click += new System.EventHandler(this.buttonRemoveAllOrders_Click);
            // 
            // OrderFinalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(532, 953);
            this.Controls.Add(this.buttonRemoveAllOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.pictureBoxChapeauLogo);
            this.Controls.Add(this.panelGreenSeparatorThree);
            this.Controls.Add(this.panelGreenSeparatorTwo);
            this.Controls.Add(this.panelGreenSeparatorOne);
            this.Controls.Add(this.panelWhiteBackground);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.panelMenuBackground);
            this.Controls.Add(this.labelTableNumber);
            this.Name = "OrderFinalise";
            this.Text = "OrderFinalise";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChapeauLogo)).EndInit();
            this.panelMenuBackground.ResumeLayout(false);
            this.panelWhiteBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConfirmOrder;
        private Button buttonGoBack;
        private PictureBox pictureBoxChapeauLogo;
        private Panel panelGreenSeparatorThree;
        private Panel panelGreenSeparatorTwo;
        private Panel panelGreenSeparatorOne;
        private ListView listViewOrders;
        private Label labelMenuType;
        private Panel panelMenuBackground;
        private Label labelTableNumber;
        private Panel panelWhiteBackground;
        private Label labelInformationOrders;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderComment;
        private ColumnHeader columnHeaderAmount;
        private Panel panel1;
        private Button buttonRemoveAllOrders;
    }
}