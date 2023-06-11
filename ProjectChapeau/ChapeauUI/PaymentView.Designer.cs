namespace ChapeauUI
{
    partial class PaymentView
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
            this.listviewItems = new System.Windows.Forms.ListView();
            this.notName = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chapeauIcon = new System.Windows.Forms.PictureBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.rdbtnCash = new System.Windows.Forms.RadioButton();
            this.rdbtnDebit = new System.Windows.Forms.RadioButton();
            this.rdbtnCredit = new System.Windows.Forms.RadioButton();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblLiked = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvat21 = new System.Windows.Forms.Label();
            this.lblvat9 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblvat1 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewItems
            // 
            this.listviewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.notName,
            this.Qty,
            this.Price,
            this.VAT});
            this.listviewItems.Location = new System.Drawing.Point(11, 77);
            this.listviewItems.Margin = new System.Windows.Forms.Padding(0);
            this.listviewItems.MultiSelect = false;
            this.listviewItems.Name = "listviewItems";
            this.listviewItems.OwnerDraw = true;
            this.listviewItems.Size = new System.Drawing.Size(355, 432);
            this.listviewItems.TabIndex = 0;
            this.listviewItems.UseCompatibleStateImageBehavior = false;
            this.listviewItems.View = System.Windows.Forms.View.Details;
            this.listviewItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listviewItems_ColumnWidthChanging);
            this.listviewItems.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listviewItems_DrawColumnHeader);
            this.listviewItems.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listviewItems_DrawItem);
            this.listviewItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listviewItems_ItemSelectionChanged);
            // 
            // notName
            // 
            this.notName.Name = "PaymentView";
            this.notName.Text = "Name";
            this.notName.Width = 200;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(11, 47);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Table 0 - 1/1/23 - 6:00PM";
            // 
            // chapeauIcon
            // 
            this.chapeauIcon.Image = global::ChapeauUI.Properties.Resources.chapeauIcon;
            this.chapeauIcon.Location = new System.Drawing.Point(212, -3);
            this.chapeauIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chapeauIcon.Name = "chapeauIcon";
            this.chapeauIcon.Size = new System.Drawing.Size(190, 77);
            this.chapeauIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chapeauIcon.TabIndex = 2;
            this.chapeauIcon.TabStop = false;
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(183)))));
            this.btnSplit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSplit.ForeColor = System.Drawing.Color.Transparent;
            this.btnSplit.Location = new System.Drawing.Point(41, 874);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(110, 48);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.btnPay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPay.Location = new System.Drawing.Point(212, 874);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(110, 48);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rdbtnCash
            // 
            this.rdbtnCash.AutoSize = true;
            this.rdbtnCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCash.Location = new System.Drawing.Point(43, 813);
            this.rdbtnCash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnCash.Name = "rdbtnCash";
            this.rdbtnCash.Size = new System.Drawing.Size(71, 29);
            this.rdbtnCash.TabIndex = 5;
            this.rdbtnCash.TabStop = true;
            this.rdbtnCash.Text = "Cash";
            this.rdbtnCash.UseVisualStyleBackColor = true;
            // 
            // rdbtnDebit
            // 
            this.rdbtnDebit.AutoSize = true;
            this.rdbtnDebit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnDebit.Location = new System.Drawing.Point(151, 813);
            this.rdbtnDebit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnDebit.Name = "rdbtnDebit";
            this.rdbtnDebit.Size = new System.Drawing.Size(75, 29);
            this.rdbtnDebit.TabIndex = 6;
            this.rdbtnDebit.TabStop = true;
            this.rdbtnDebit.Text = "Debit";
            this.rdbtnDebit.UseVisualStyleBackColor = true;
            // 
            // rdbtnCredit
            // 
            this.rdbtnCredit.AutoSize = true;
            this.rdbtnCredit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtnCredit.Location = new System.Drawing.Point(250, 813);
            this.rdbtnCredit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbtnCredit.Name = "rdbtnCredit";
            this.rdbtnCredit.Size = new System.Drawing.Size(81, 29);
            this.rdbtnCredit.TabIndex = 7;
            this.rdbtnCredit.TabStop = true;
            this.rdbtnCredit.Text = "Credit";
            this.rdbtnCredit.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTip.Location = new System.Drawing.Point(22, 774);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(59, 25);
            this.lblTip.TabIndex = 8;
            this.lblTip.Text = "Tip: €";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal2.Location = new System.Drawing.Point(177, 774);
            this.lblTotal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(74, 25);
            this.lblTotal2.TabIndex = 9;
            this.lblTotal2.Text = "Total: €";
            // 
            // lblLiked
            // 
            this.lblLiked.AutoSize = true;
            this.lblLiked.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiked.Location = new System.Drawing.Point(11, 687);
            this.lblLiked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLiked.Name = "lblLiked";
            this.lblLiked.Size = new System.Drawing.Size(266, 25);
            this.lblLiked.TabIndex = 10;
            this.lblLiked.Text = "Was everything to your liking?";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComment.Location = new System.Drawing.Point(11, 717);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtComment.MaxLength = 256;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(349, 29);
            this.txtComment.TabIndex = 11;
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
            this.panel1.Location = new System.Drawing.Point(11, 529);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 134);
            this.panel1.TabIndex = 12;
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
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(74, 774);
            this.txtTip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(92, 29);
            this.txtTip.TabIndex = 13;
            this.txtTip.Text = "0.00";
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            this.txtTip.Enter += new System.EventHandler(this.txtTip_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(247, 774);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(92, 29);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(4, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(377, 841);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblLiked);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.rdbtnCredit);
            this.Controls.Add(this.rdbtnDebit);
            this.Controls.Add(this.rdbtnCash);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.chapeauIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listviewItems);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentView";
            ((System.ComponentModel.ISupportInitialize)(this.chapeauIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listviewItems;
        private Label lblTitle;
        private PictureBox chapeauIcon;
        private ColumnHeader notName;
        private ColumnHeader Qty;
        private ColumnHeader Price;
        private ColumnHeader VAT;
        private Button btnSplit;
        private Button btnPay;
        private RadioButton rdbtnCash;
        private RadioButton rdbtnDebit;
        private RadioButton rdbtnCredit;
        private Label lblTip;
        private Label lblTotal2;
        private Label lblLiked;
        private TextBox txtComment;
        private Panel panel1;
        private Label lblTotal1;
        private Label lblvat1;
        private Label lblvat;
        private Label lblSub;
        private TextBox txtTip;
        private TextBox txtTotal;
        private Label lblvat21;
        private Label lblvat9;
        private Label lblSubtotal;
        private Label lblTotal;
        private Button btnCancel;
    }
}