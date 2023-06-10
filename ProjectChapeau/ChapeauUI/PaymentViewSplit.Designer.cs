namespace ChapeauUI
{
    partial class PaymentViewSplit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvat21 = new System.Windows.Forms.Label();
            this.lblvat9 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblvat1 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.listviewPayments = new System.Windows.Forms.ListView();
            this.PaymentView = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.rdbtnCredit = new System.Windows.Forms.RadioButton();
            this.rdbtnDebit = new System.Windows.Forms.RadioButton();
            this.rdbtnCash = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).BeginInit();
            this.panel1.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Table 0 - 1/1/23 - 6:00PM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
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
            this.panel1.TabIndex = 14;
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
            // listviewPayments
            // 
            this.listviewPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaymentView,
            this.Qty,
            this.Price,
            this.VAT});
            this.listviewPayments.Location = new System.Drawing.Point(14, 621);
            this.listviewPayments.Margin = new System.Windows.Forms.Padding(0);
            this.listviewPayments.MultiSelect = false;
            this.listviewPayments.Name = "listviewPayments";
            this.listviewPayments.OwnerDraw = true;
            this.listviewPayments.Size = new System.Drawing.Size(443, 344);
            this.listviewPayments.TabIndex = 15;
            this.listviewPayments.UseCompatibleStateImageBehavior = false;
            this.listviewPayments.View = System.Windows.Forms.View.Details;
            this.listviewPayments.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listviewPayments_ColumnWidthChanging);
            this.listviewPayments.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listviewPayments_DrawColumnHeader);
            this.listviewPayments.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listviewPayments_DrawItem);
            // 
            // PaymentView
            // 
            this.PaymentView.Name = "PaymentView";
            this.PaymentView.Text = "Nr.";
            this.PaymentView.Width = 75;
            // 
            // Qty
            // 
            this.Qty.Text = "Amount";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Tip";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 100;
            // 
            // VAT
            // 
            this.VAT.Text = "Method";
            this.VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAT.Width = 150;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(297, 476);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(122, 27);
            this.txtCVV.TabIndex = 32;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(14, 476);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(183, 27);
            this.txtExpDate.TabIndex = 31;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(14, 391);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(405, 27);
            this.txtCardNumber.TabIndex = 30;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(14, 317);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(405, 27);
            this.txtCardName.TabIndex = 29;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.Location = new System.Drawing.Point(297, 433);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(50, 28);
            this.lblCVV.TabIndex = 28;
            this.lblCVV.Text = "CVV";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpDate.Location = new System.Drawing.Point(14, 433);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(160, 28);
            this.lblExpDate.TabIndex = 27;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardNumber.Location = new System.Drawing.Point(14, 359);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(138, 28);
            this.lblCardNumber.TabIndex = 26;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardName.Location = new System.Drawing.Point(14, 285);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(117, 28);
            this.lblCardName.TabIndex = 25;
            this.lblCardName.Text = "Card Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(278, 535);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 60);
            this.btnConfirm.TabIndex = 34;
            this.btnConfirm.Text = "Pay";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(53, 535);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 60);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(306, 220);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(114, 34);
            this.txtTotal.TabIndex = 41;
            this.txtTotal.Text = "0.00";
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(91, 220);
            this.txtTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(114, 34);
            this.txtTip.TabIndex = 40;
            this.txtTip.Text = "0.00";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal2.Location = new System.Drawing.Point(218, 220);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(93, 32);
            this.lblTotal2.TabIndex = 39;
            this.lblTotal2.Text = "Total: €";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTip.Location = new System.Drawing.Point(25, 220);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(73, 32);
            this.lblTip.TabIndex = 38;
            this.lblTip.Text = "Tip: €";
            // 
            // rdbtnCredit
            // 
            this.rdbtnCredit.AutoSize = true;
            this.rdbtnCredit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCredit.Location = new System.Drawing.Point(314, 155);
            this.rdbtnCredit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnCredit.Name = "rdbtnCredit";
            this.rdbtnCredit.Size = new System.Drawing.Size(99, 36);
            this.rdbtnCredit.TabIndex = 37;
            this.rdbtnCredit.TabStop = true;
            this.rdbtnCredit.Text = "Credit";
            this.rdbtnCredit.UseVisualStyleBackColor = true;
            // 
            // rdbtnDebit
            // 
            this.rdbtnDebit.AutoSize = true;
            this.rdbtnDebit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnDebit.Location = new System.Drawing.Point(191, 155);
            this.rdbtnDebit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnDebit.Name = "rdbtnDebit";
            this.rdbtnDebit.Size = new System.Drawing.Size(93, 36);
            this.rdbtnDebit.TabIndex = 36;
            this.rdbtnDebit.TabStop = true;
            this.rdbtnDebit.Text = "Debit";
            this.rdbtnDebit.UseVisualStyleBackColor = true;
            // 
            // rdbtnCash
            // 
            this.rdbtnCash.AutoSize = true;
            this.rdbtnCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCash.Location = new System.Drawing.Point(56, 155);
            this.rdbtnCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnCash.Name = "rdbtnCash";
            this.rdbtnCash.Size = new System.Drawing.Size(86, 36);
            this.rdbtnCash.TabIndex = 35;
            this.rdbtnCash.TabStop = true;
            this.rdbtnCash.Text = "Cash";
            this.rdbtnCash.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(53, 101);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(171, 32);
            this.lblAmount.TabIndex = 42;
            this.lblAmount.Text = "Amount left: €";
            // 
            // lblTotalLeft
            // 
            this.lblTotalLeft.AutoSize = true;
            this.lblTotalLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotalLeft.Location = new System.Drawing.Point(218, 101);
            this.lblTotalLeft.Name = "lblTotalLeft";
            this.lblTotalLeft.Size = new System.Drawing.Size(63, 32);
            this.lblTotalLeft.TabIndex = 43;
            this.lblTotalLeft.Text = "0.00";
            // 
            // PaymentViewSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(475, 1051);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTotalLeft);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.rdbtnCredit);
            this.Controls.Add(this.rdbtnDebit);
            this.Controls.Add(this.rdbtnCash);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.listviewPayments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chapeauIcon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentViewSplit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentViewSplit";
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox chapeauIcon;
        private Label lblTitle;
        private Panel panel1;
        private Label lblvat21;
        private Label lblvat9;
        private Label lblSubtotal;
        private Label lblTotal;
        private Label lblTotal1;
        private Label lblvat1;
        private Label lblvat;
        private Label lblSub;
        private ListView listviewPayments;
        private ColumnHeader PaymentView;
        private ColumnHeader Qty;
        private ColumnHeader Price;
        private ColumnHeader VAT;
        private TextBox txtCVV;
        private TextBox txtExpDate;
        private TextBox txtCardNumber;
        private TextBox txtCardName;
        private Label lblCVV;
        private Label lblExpDate;
        private Label lblCardNumber;
        private Label lblCardName;
        private Button btnConfirm;
        private Button btnCancel;
        private TextBox txtTotal;
        private TextBox txtTip;
        private Label lblTotal2;
        private Label lblTip;
        private RadioButton rdbtnCredit;
        private RadioButton rdbtnDebit;
        private RadioButton rdbtnCash;
        private Label lblAmount;
        private Label lblTotalLeft;
    }
}