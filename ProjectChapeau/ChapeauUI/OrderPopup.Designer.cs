namespace ChapeauUI
{
    partial class OrderPopup
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
            this.panelNameOneBackground = new System.Windows.Forms.Panel();
            this.labelPopupNameOne = new System.Windows.Forms.Label();
            this.panelNameTwoBackground = new System.Windows.Forms.Panel();
            this.labelPopupNameTwo = new System.Windows.Forms.Label();
            this.panelQuantityBackground = new System.Windows.Forms.Panel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonQuantityMinus = new System.Windows.Forms.Button();
            this.buttonQuantityPlus = new System.Windows.Forms.Button();
            this.panelQuantityAmountBackground = new System.Windows.Forms.Panel();
            this.labelQuantityAmount = new System.Windows.Forms.Label();
            this.textBoxPopupComment = new System.Windows.Forms.TextBox();
            this.buttonPopupAddOrder = new System.Windows.Forms.Button();
            this.buttonPopupCancel = new System.Windows.Forms.Button();
            this.panelNameOneBackground.SuspendLayout();
            this.panelNameTwoBackground.SuspendLayout();
            this.panelQuantityBackground.SuspendLayout();
            this.panelQuantityAmountBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNameOneBackground
            // 
            this.panelNameOneBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.panelNameOneBackground.Controls.Add(this.labelPopupNameOne);
            this.panelNameOneBackground.Location = new System.Drawing.Point(6, 6);
            this.panelNameOneBackground.Name = "panelNameOneBackground";
            this.panelNameOneBackground.Size = new System.Drawing.Size(420, 41);
            this.panelNameOneBackground.TabIndex = 2;
            // 
            // labelPopupNameOne
            // 
            this.labelPopupNameOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPopupNameOne.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPopupNameOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPopupNameOne.Location = new System.Drawing.Point(0, 0);
            this.labelPopupNameOne.Name = "labelPopupNameOne";
            this.labelPopupNameOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPopupNameOne.Size = new System.Drawing.Size(420, 40);
            this.labelPopupNameOne.TabIndex = 2;
            this.labelPopupNameOne.Text = "Menu Item Name";
            this.labelPopupNameOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNameTwoBackground
            // 
            this.panelNameTwoBackground.BackColor = System.Drawing.Color.White;
            this.panelNameTwoBackground.Controls.Add(this.labelPopupNameTwo);
            this.panelNameTwoBackground.Location = new System.Drawing.Point(6, 53);
            this.panelNameTwoBackground.Name = "panelNameTwoBackground";
            this.panelNameTwoBackground.Size = new System.Drawing.Size(420, 67);
            this.panelNameTwoBackground.TabIndex = 3;
            // 
            // labelPopupNameTwo
            // 
            this.labelPopupNameTwo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPopupNameTwo.AutoEllipsis = true;
            this.labelPopupNameTwo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPopupNameTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPopupNameTwo.Location = new System.Drawing.Point(0, 1);
            this.labelPopupNameTwo.Name = "labelPopupNameTwo";
            this.labelPopupNameTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPopupNameTwo.Size = new System.Drawing.Size(420, 68);
            this.labelPopupNameTwo.TabIndex = 2;
            this.labelPopupNameTwo.Text = "With test and to see if it goes to a new line when reaching the end test\r\n";
            this.labelPopupNameTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelQuantityBackground
            // 
            this.panelQuantityBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.panelQuantityBackground.Controls.Add(this.labelQuantity);
            this.panelQuantityBackground.Location = new System.Drawing.Point(6, 126);
            this.panelQuantityBackground.Name = "panelQuantityBackground";
            this.panelQuantityBackground.Size = new System.Drawing.Size(200, 60);
            this.panelQuantityBackground.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuantity.Location = new System.Drawing.Point(3, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQuantity.Size = new System.Drawing.Size(194, 60);
            this.labelQuantity.TabIndex = 20;
            this.labelQuantity.Text = "Quantity :";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonQuantityMinus
            // 
            this.buttonQuantityMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.buttonQuantityMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuantityMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuantityMinus.Location = new System.Drawing.Point(212, 126);
            this.buttonQuantityMinus.Name = "buttonQuantityMinus";
            this.buttonQuantityMinus.Size = new System.Drawing.Size(69, 64);
            this.buttonQuantityMinus.TabIndex = 19;
            this.buttonQuantityMinus.Text = "-";
            this.buttonQuantityMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuantityMinus.UseVisualStyleBackColor = false;
            // 
            // buttonQuantityPlus
            // 
            this.buttonQuantityPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.buttonQuantityPlus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuantityPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuantityPlus.Location = new System.Drawing.Point(357, 126);
            this.buttonQuantityPlus.Name = "buttonQuantityPlus";
            this.buttonQuantityPlus.Size = new System.Drawing.Size(69, 64);
            this.buttonQuantityPlus.TabIndex = 20;
            this.buttonQuantityPlus.Text = "+";
            this.buttonQuantityPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuantityPlus.UseVisualStyleBackColor = false;
            // 
            // panelQuantityAmountBackground
            // 
            this.panelQuantityAmountBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panelQuantityAmountBackground.Controls.Add(this.labelQuantityAmount);
            this.panelQuantityAmountBackground.Location = new System.Drawing.Point(285, 126);
            this.panelQuantityAmountBackground.Name = "panelQuantityAmountBackground";
            this.panelQuantityAmountBackground.Size = new System.Drawing.Size(69, 64);
            this.panelQuantityAmountBackground.TabIndex = 21;
            // 
            // labelQuantityAmount
            // 
            this.labelQuantityAmount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantityAmount.Location = new System.Drawing.Point(0, 0);
            this.labelQuantityAmount.Name = "labelQuantityAmount";
            this.labelQuantityAmount.Size = new System.Drawing.Size(69, 64);
            this.labelQuantityAmount.TabIndex = 22;
            this.labelQuantityAmount.Text = "0";
            this.labelQuantityAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPopupComment
            // 
            this.textBoxPopupComment.BackColor = System.Drawing.Color.White;
            this.textBoxPopupComment.Location = new System.Drawing.Point(6, 192);
            this.textBoxPopupComment.Multiline = true;
            this.textBoxPopupComment.Name = "textBoxPopupComment";
            this.textBoxPopupComment.PlaceholderText = "Write additional comments here...";
            this.textBoxPopupComment.Size = new System.Drawing.Size(420, 90);
            this.textBoxPopupComment.TabIndex = 22;
            // 
            // buttonPopupAddOrder
            // 
            this.buttonPopupAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.buttonPopupAddOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPopupAddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPopupAddOrder.Location = new System.Drawing.Point(6, 288);
            this.buttonPopupAddOrder.Name = "buttonPopupAddOrder";
            this.buttonPopupAddOrder.Size = new System.Drawing.Size(420, 64);
            this.buttonPopupAddOrder.TabIndex = 23;
            this.buttonPopupAddOrder.Text = "Add Order";
            this.buttonPopupAddOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPopupAddOrder.UseVisualStyleBackColor = false;
            // 
            // buttonPopupCancel
            // 
            this.buttonPopupCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.buttonPopupCancel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPopupCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPopupCancel.Location = new System.Drawing.Point(6, 358);
            this.buttonPopupCancel.Name = "buttonPopupCancel";
            this.buttonPopupCancel.Size = new System.Drawing.Size(420, 64);
            this.buttonPopupCancel.TabIndex = 24;
            this.buttonPopupCancel.Text = "Cancel";
            this.buttonPopupCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPopupCancel.UseVisualStyleBackColor = false;
            // 
            // OrderPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(432, 433);
            this.Controls.Add(this.buttonPopupCancel);
            this.Controls.Add(this.buttonPopupAddOrder);
            this.Controls.Add(this.textBoxPopupComment);
            this.Controls.Add(this.panelQuantityAmountBackground);
            this.Controls.Add(this.buttonQuantityPlus);
            this.Controls.Add(this.buttonQuantityMinus);
            this.Controls.Add(this.panelQuantityBackground);
            this.Controls.Add(this.panelNameTwoBackground);
            this.Controls.Add(this.panelNameOneBackground);
            this.Name = "OrderPopup";
            this.Text = "OrderPopup";
            this.panelNameOneBackground.ResumeLayout(false);
            this.panelNameTwoBackground.ResumeLayout(false);
            this.panelQuantityBackground.ResumeLayout(false);
            this.panelQuantityAmountBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelNameOneBackground;
        private Label labelPopupNameOne;
        private Panel panelNameTwoBackground;
        private Label labelPopupNameTwo;
        private Panel panelQuantityBackground;
        private Label labelQuantity;
        private Button buttonQuantityMinus;
        private Button buttonQuantityPlus;
        private Panel panelQuantityAmountBackground;
        private Label labelQuantityAmount;
        private TextBox textBoxPopupComment;
        private Button buttonPopupAddOrder;
        private Button buttonPopupCancel;
    }
}