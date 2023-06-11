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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblComeAgain = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.pictureCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // chapeauIcon
            // 
            this.chapeauIcon.Image = global::ChapeauUI.Properties.Resources.chapeauIcon;
            this.chapeauIcon.Location = new System.Drawing.Point(212, -3);
            this.chapeauIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chapeauIcon.Name = "chapeauIcon";
            this.chapeauIcon.Size = new System.Drawing.Size(190, 77);
            this.chapeauIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chapeauIcon.TabIndex = 3;
            this.chapeauIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(11, 47);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 15);
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
            this.panel1.Location = new System.Drawing.Point(11, 794);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 134);
            this.panel1.TabIndex = 14;
            // 
            // lblvat21
            // 
            this.lblvat21.AutoSize = true;
            this.lblvat21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat21.Location = new System.Drawing.Point(109, 90);
            this.lblvat21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvat21.Name = "lblvat21";
            this.lblvat21.Size = new System.Drawing.Size(56, 25);
            this.lblvat21.TabIndex = 7;
            this.lblvat21.Text = "€0.00";
            // 
            // lblvat9
            // 
            this.lblvat9.AutoSize = true;
            this.lblvat9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat9.Location = new System.Drawing.Point(109, 54);
            this.lblvat9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvat9.Name = "lblvat9";
            this.lblvat9.Size = new System.Drawing.Size(56, 25);
            this.lblvat9.TabIndex = 6;
            this.lblvat9.Text = "€0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.Location = new System.Drawing.Point(109, 16);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(56, 25);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "€0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotal.Location = new System.Drawing.Point(252, 90);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "€0.00";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotal1.Location = new System.Drawing.Point(180, 90);
            this.lblTotal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(73, 25);
            this.lblTotal1.TabIndex = 3;
            this.lblTotal1.Text = "TOTAL:";
            // 
            // lblvat1
            // 
            this.lblvat1.AutoSize = true;
            this.lblvat1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat1.Location = new System.Drawing.Point(11, 90);
            this.lblvat1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvat1.Name = "lblvat1";
            this.lblvat1.Size = new System.Drawing.Size(101, 25);
            this.lblvat1.TabIndex = 2;
            this.lblvat1.Text = "VAT (21%):";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblvat.Location = new System.Drawing.Point(11, 54);
            this.lblvat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(91, 25);
            this.lblvat.TabIndex = 1;
            this.lblvat.Text = "VAT (9%):";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(11, 16);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(86, 25);
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
            this.listviewPayments.Location = new System.Drawing.Point(11, 497);
            this.listviewPayments.Margin = new System.Windows.Forms.Padding(0);
            this.listviewPayments.MultiSelect = false;
            this.listviewPayments.Name = "listviewPayments";
            this.listviewPayments.OwnerDraw = true;
            this.listviewPayments.Size = new System.Drawing.Size(355, 276);
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
            this.txtCVV.Location = new System.Drawing.Point(238, 381);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(98, 23);
            this.txtCVV.TabIndex = 32;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(11, 381);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(147, 23);
            this.txtExpDate.TabIndex = 31;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(11, 313);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(325, 23);
            this.txtCardNumber.TabIndex = 30;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(11, 254);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(325, 23);
            this.txtCardName.TabIndex = 29;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.Location = new System.Drawing.Point(238, 346);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(42, 21);
            this.lblCVV.TabIndex = 28;
            this.lblCVV.Text = "CVV";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpDate.Location = new System.Drawing.Point(11, 346);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(129, 21);
            this.lblExpDate.TabIndex = 27;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardNumber.Location = new System.Drawing.Point(11, 287);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(112, 21);
            this.lblCardNumber.TabIndex = 26;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardName.Location = new System.Drawing.Point(11, 228);
            this.lblCardName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(95, 21);
            this.lblCardName.TabIndex = 25;
            this.lblCardName.Text = "Card Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(222, 428);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 48);
            this.btnConfirm.TabIndex = 34;
            this.btnConfirm.Text = "Pay";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(42, 428);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 48);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(245, 176);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(92, 29);
            this.txtTotal.TabIndex = 41;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(73, 176);
            this.txtTip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(92, 29);
            this.txtTip.TabIndex = 40;
            this.txtTip.Text = "0.00";
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal2.Location = new System.Drawing.Point(174, 176);
            this.lblTotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(74, 25);
            this.lblTotal2.TabIndex = 39;
            this.lblTotal2.Text = "Total: €";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTip.Location = new System.Drawing.Point(20, 176);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(59, 25);
            this.lblTip.TabIndex = 38;
            this.lblTip.Text = "Tip: €";
            // 
            // rdbtnCredit
            // 
            this.rdbtnCredit.AutoSize = true;
            this.rdbtnCredit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCredit.Location = new System.Drawing.Point(251, 124);
            this.rdbtnCredit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnCredit.Name = "rdbtnCredit";
            this.rdbtnCredit.Size = new System.Drawing.Size(81, 29);
            this.rdbtnCredit.TabIndex = 37;
            this.rdbtnCredit.TabStop = true;
            this.rdbtnCredit.Text = "Credit";
            this.rdbtnCredit.UseVisualStyleBackColor = true;
            this.rdbtnCredit.CheckedChanged += new System.EventHandler(this.rdbtnCredit_CheckedChanged);
            // 
            // rdbtnDebit
            // 
            this.rdbtnDebit.AutoSize = true;
            this.rdbtnDebit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnDebit.Location = new System.Drawing.Point(153, 124);
            this.rdbtnDebit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnDebit.Name = "rdbtnDebit";
            this.rdbtnDebit.Size = new System.Drawing.Size(75, 29);
            this.rdbtnDebit.TabIndex = 36;
            this.rdbtnDebit.TabStop = true;
            this.rdbtnDebit.Text = "Debit";
            this.rdbtnDebit.UseVisualStyleBackColor = true;
            this.rdbtnDebit.CheckedChanged += new System.EventHandler(this.rdbtnDebit_CheckedChanged);
            // 
            // rdbtnCash
            // 
            this.rdbtnCash.AutoSize = true;
            this.rdbtnCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCash.Location = new System.Drawing.Point(45, 124);
            this.rdbtnCash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnCash.Name = "rdbtnCash";
            this.rdbtnCash.Size = new System.Drawing.Size(71, 29);
            this.rdbtnCash.TabIndex = 35;
            this.rdbtnCash.TabStop = true;
            this.rdbtnCash.Text = "Cash";
            this.rdbtnCash.UseVisualStyleBackColor = true;
            this.rdbtnCash.CheckedChanged += new System.EventHandler(this.rdbtnCash_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(42, 81);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(137, 25);
            this.lblAmount.TabIndex = 42;
            this.lblAmount.Text = "Amount left: €";
            // 
            // lblTotalLeft
            // 
            this.lblTotalLeft.AutoSize = true;
            this.lblTotalLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.lblTotalLeft.Location = new System.Drawing.Point(174, 81);
            this.lblTotalLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLeft.Name = "lblTotalLeft";
            this.lblTotalLeft.Size = new System.Drawing.Size(50, 25);
            this.lblTotalLeft.TabIndex = 43;
            this.lblTotalLeft.Text = "0.00";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(127, 346);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 48);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblComeAgain
            // 
            this.lblComeAgain.AutoSize = true;
            this.lblComeAgain.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComeAgain.Location = new System.Drawing.Point(126, 315);
            this.lblComeAgain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComeAgain.Name = "lblComeAgain";
            this.lblComeAgain.Size = new System.Drawing.Size(120, 25);
            this.lblComeAgain.TabIndex = 46;
            this.lblComeAgain.Text = "Come again!";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuccess.Location = new System.Drawing.Point(106, 286);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(180, 25);
            this.lblSuccess.TabIndex = 45;
            this.lblSuccess.Text = "Payment Successful";
            // 
            // pictureCheck
            // 
            this.pictureCheck.Image = global::ChapeauUI.Properties.Resources.checkcircle;
            this.pictureCheck.InitialImage = null;
            this.pictureCheck.Location = new System.Drawing.Point(94, 144);
            this.pictureCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureCheck.Name = "pictureCheck";
            this.pictureCheck.Size = new System.Drawing.Size(186, 127);
            this.pictureCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCheck.TabIndex = 44;
            this.pictureCheck.TabStop = false;
            // 
            // PaymentViewSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(380, 841);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblComeAgain);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.pictureCheck);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentViewSplit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentViewSplit";
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).EndInit();
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
        private Button btnClose;
        private Label lblComeAgain;
        private Label lblSuccess;
        private PictureBox pictureCheck;
    }
}