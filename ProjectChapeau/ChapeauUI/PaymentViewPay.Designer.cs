namespace ChapeauUI
{
    partial class PaymentViewPay
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
            this.chapeauIcon = new System.Windows.Forms.PictureBox();
            this.listviewItems = new System.Windows.Forms.ListView();
            this.PaymentView = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTip = new System.Windows.Forms.Label();
            this.lblTotalTip1 = new System.Windows.Forms.Label();
            this.lblvat21 = new System.Windows.Forms.Label();
            this.lblvat9 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblvat1 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.pictureCheck = new System.Windows.Forms.PictureBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblComeAgain = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // chapeauIcon
            // 
            this.chapeauIcon.Image = global::ChapeauUI.Properties.Resources.chapeauIcon;
            this.chapeauIcon.Location = new System.Drawing.Point(265, -4);
            this.chapeauIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chapeauIcon.Name = "chapeauIcon";
            this.chapeauIcon.Size = new System.Drawing.Size(237, 96);
            this.chapeauIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chapeauIcon.TabIndex = 3;
            this.chapeauIcon.TabStop = false;
            // 
            // listviewItems
            // 
            this.listviewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaymentView,
            this.Qty,
            this.Price,
            this.VAT});
            this.listviewItems.Location = new System.Drawing.Point(14, 427);
            this.listviewItems.Margin = new System.Windows.Forms.Padding(0);
            this.listviewItems.MultiSelect = false;
            this.listviewItems.Name = "listviewItems";
            this.listviewItems.OwnerDraw = true;
            this.listviewItems.Size = new System.Drawing.Size(443, 539);
            this.listviewItems.TabIndex = 4;
            this.listviewItems.UseCompatibleStateImageBehavior = false;
            this.listviewItems.View = System.Windows.Forms.View.Details;
            this.listviewItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listviewItems_ColumnWidthChanging);
            this.listviewItems.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listviewItems_DrawColumnHeader);
            this.listviewItems.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listviewItems_DrawItem);
            this.listviewItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listviewItems_ItemSelectionChanged);
            // 
            // PaymentView
            // 
            this.PaymentView.Name = "PaymentView";
            this.PaymentView.Text = "Name";
            this.PaymentView.Width = 200;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Width = 75;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 75;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAT.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.lblTotalTip);
            this.panel1.Controls.Add(this.lblTotalTip1);
            this.panel1.Controls.Add(this.lblvat21);
            this.panel1.Controls.Add(this.lblvat9);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTotal1);
            this.panel1.Controls.Add(this.lblvat1);
            this.panel1.Controls.Add(this.lblvat);
            this.panel1.Controls.Add(this.lblSub);
            this.panel1.Location = new System.Drawing.Point(14, 992);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 167);
            this.panel1.TabIndex = 13;
            // 
            // lblTotalTip
            // 
            this.lblTotalTip.AutoSize = true;
            this.lblTotalTip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotalTip.Location = new System.Drawing.Point(315, 67);
            this.lblTotalTip.Name = "lblTotalTip";
            this.lblTotalTip.Size = new System.Drawing.Size(77, 32);
            this.lblTotalTip.TabIndex = 9;
            this.lblTotalTip.Text = "€0.00";
            // 
            // lblTotalTip1
            // 
            this.lblTotalTip1.AutoSize = true;
            this.lblTotalTip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotalTip1.Location = new System.Drawing.Point(225, 67);
            this.lblTotalTip1.Name = "lblTotalTip1";
            this.lblTotalTip1.Size = new System.Drawing.Size(58, 32);
            this.lblTotalTip1.TabIndex = 8;
            this.lblTotalTip1.Text = "TIP:";
            // 
            // lblvat21
            // 
            this.lblvat21.AutoSize = true;
            this.lblvat21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat21.Location = new System.Drawing.Point(136, 113);
            this.lblvat21.Name = "lblvat21";
            this.lblvat21.Size = new System.Drawing.Size(71, 32);
            this.lblvat21.TabIndex = 7;
            this.lblvat21.Text = "€0.00";
            // 
            // lblvat9
            // 
            this.lblvat9.AutoSize = true;
            this.lblvat9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat9.Location = new System.Drawing.Point(136, 67);
            this.lblvat9.Name = "lblvat9";
            this.lblvat9.Size = new System.Drawing.Size(71, 32);
            this.lblvat9.TabIndex = 6;
            this.lblvat9.Text = "€0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.Location = new System.Drawing.Point(136, 20);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(71, 32);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "€0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotal.Location = new System.Drawing.Point(315, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 32);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "€0.00";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotal1.Location = new System.Drawing.Point(225, 113);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(92, 32);
            this.lblTotal1.TabIndex = 3;
            this.lblTotal1.Text = "TOTAL:";
            // 
            // lblvat1
            // 
            this.lblvat1.AutoSize = true;
            this.lblvat1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat1.Location = new System.Drawing.Point(14, 113);
            this.lblvat1.Name = "lblvat1";
            this.lblvat1.Size = new System.Drawing.Size(126, 32);
            this.lblvat1.TabIndex = 2;
            this.lblvat1.Text = "VAT (21%):";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat.Location = new System.Drawing.Point(14, 67);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(113, 32);
            this.lblvat.TabIndex = 1;
            this.lblvat.Text = "VAT (9%):";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(14, 20);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(108, 32);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "Subtotal:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 20);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Table 0 - 1/1/23 - 6:00PM";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(265, 348);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 60);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(40, 348);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 60);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardName.Location = new System.Drawing.Point(14, 108);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 28);
            this.lblCardName.TabIndex = 17;
            this.lblCardName.Text = "Card Name";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardNumber.Location = new System.Drawing.Point(14, 181);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(138, 28);
            this.lblCardNumber.TabIndex = 18;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpDate.Location = new System.Drawing.Point(14, 256);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(160, 28);
            this.lblExpDate.TabIndex = 19;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.Location = new System.Drawing.Point(297, 256);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(50, 28);
            this.lblCVV.TabIndex = 20;
            this.lblCVV.Text = "CVV";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(14, 140);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(405, 27);
            this.txtCardName.TabIndex = 21;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(14, 213);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(405, 27);
            this.txtCardNumber.TabIndex = 22;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(14, 299);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(183, 27);
            this.txtExpDate.TabIndex = 23;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(297, 299);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(122, 27);
            this.txtCVV.TabIndex = 24;
            // 
            // pictureCheck
            // 
            this.pictureCheck.Image = global::ChapeauUI.Properties.Resources.checkcircle;
            this.pictureCheck.InitialImage = null;
            this.pictureCheck.Location = new System.Drawing.Point(113, 102);
            this.pictureCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureCheck.Name = "pictureCheck";
            this.pictureCheck.Size = new System.Drawing.Size(232, 159);
            this.pictureCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCheck.TabIndex = 25;
            this.pictureCheck.TabStop = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuccess.Location = new System.Drawing.Point(127, 280);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(226, 32);
            this.lblSuccess.TabIndex = 26;
            this.lblSuccess.Text = "Payment Successful";
            // 
            // lblComeAgain
            // 
            this.lblComeAgain.AutoSize = true;
            this.lblComeAgain.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComeAgain.Location = new System.Drawing.Point(153, 316);
            this.lblComeAgain.Name = "lblComeAgain";
            this.lblComeAgain.Size = new System.Drawing.Size(151, 32);
            this.lblComeAgain.TabIndex = 27;
            this.lblComeAgain.Text = "Come again!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(154, 355);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 60);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PaymentViewPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(475, 1051);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblComeAgain);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.pictureCheck);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listviewItems);
            this.Controls.Add(this.chapeauIcon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentViewPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentViewPay";
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox chapeauIcon;
        private ListView listviewItems;
        private ColumnHeader PaymentView;
        private ColumnHeader Qty;
        private ColumnHeader Price;
        private ColumnHeader VAT;
        private Panel panel1;
        private Label lblvat21;
        private Label lblvat9;
        private Label lblSubtotal;
        private Label lblTotal;
        private Label lblTotal1;
        private Label lblvat1;
        private Label lblvat;
        private Label lblSub;
        private Label lblTitle;
        private Label lblTotalTip;
        private Label lblTotalTip1;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblCardName;
        private Label lblCardNumber;
        private Label lblExpDate;
        private Label lblCVV;
        private TextBox txtCardName;
        private TextBox txtCardNumber;
        private TextBox txtExpDate;
        private TextBox txtCVV;
        private PictureBox pictureCheck;
        private Label lblSuccess;
        private Label lblComeAgain;
        private Button btnClose;
    }
}