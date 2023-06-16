namespace ChapeauUI
{
    partial class BarKitchenView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarKitchenView));
            buttonHistory = new Button();
            buttonLogOut = new Button();
            labelOrders = new Label();
            listViewOrders = new ListView();
            Table = new ColumnHeader();
            Quantity = new ColumnHeader();
            Item = new ColumnHeader();
            Received = new ColumnHeader();
            Waiting = new ColumnHeader();
            Status = new ColumnHeader();
            buttonStart = new Button();
            buttonReady = new Button();
            listViewHistory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            buttonOrders = new Button();
            labelHistory = new Label();
            timerRefreshDisplay = new System.Windows.Forms.Timer(components);
            labelPrompt = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.FromArgb(135, 227, 78);
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistory.Location = new Point(300, 44);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(190, 53);
            buttonHistory.TabIndex = 8;
            buttonHistory.Text = "HISTORY";
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Blue;
            buttonLogOut.FlatStyle = FlatStyle.Popup;
            buttonLogOut.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.ForeColor = SystemColors.ButtonHighlight;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogOut.Location = new Point(934, 44);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(190, 53);
            buttonLogOut.TabIndex = 9;
            buttonLogOut.Text = "LOG OUT";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.FlatStyle = FlatStyle.System;
            labelOrders.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrders.ForeColor = SystemColors.ActiveCaptionText;
            labelOrders.Location = new Point(608, 44);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(206, 62);
            labelOrders.TabIndex = 10;
            labelOrders.Text = "ORDERS";
            labelOrders.TextAlign = ContentAlignment.TopCenter;
            // 
            // listViewOrders
            // 
            listViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewOrders.BackColor = SystemColors.ControlLight;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { Table, Quantity, Item, Received, Waiting, Status });
            listViewOrders.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(46, 163);
            listViewOrders.MultiSelect = false;
            listViewOrders.Name = "listViewOrders";
            listViewOrders.ShowItemToolTips = true;
            listViewOrders.Size = new Size(1322, 710);
            listViewOrders.TabIndex = 11;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged;
            // 
            // Table
            // 
            Table.Text = "Table";
            Table.Width = 70;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.TextAlign = HorizontalAlignment.Center;
            Quantity.Width = 100;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.TextAlign = HorizontalAlignment.Center;
            Item.Width = 750;
            // 
            // Received
            // 
            Received.Text = "Received";
            Received.TextAlign = HorizontalAlignment.Center;
            Received.Width = 120;
            // 
            // Waiting
            // 
            Waiting.Text = "Waiting";
            Waiting.TextAlign = HorizontalAlignment.Center;
            Waiting.Width = 120;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 130;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Cyan;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(593, 892);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(190, 53);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonReady
            // 
            buttonReady.BackColor = Color.Yellow;
            buttonReady.FlatStyle = FlatStyle.Popup;
            buttonReady.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReady.ForeColor = SystemColors.ControlText;
            buttonReady.Location = new Point(593, 892);
            buttonReady.Name = "buttonReady";
            buttonReady.Size = new Size(190, 53);
            buttonReady.TabIndex = 13;
            buttonReady.Text = "READY";
            buttonReady.UseVisualStyleBackColor = false;
            buttonReady.Click += buttonReady_Click;
            // 
            // listViewHistory
            // 
            listViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewHistory.BackColor = SystemColors.ControlLight;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewHistory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewHistory.FullRowSelect = true;
            listViewHistory.Location = new Point(46, 163);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.Size = new Size(1322, 710);
            listViewHistory.TabIndex = 14;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Table";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantity";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Item";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 820;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Received";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prepared";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.FromArgb(237, 122, 122);
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrders.Location = new Point(300, 44);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(190, 53);
            buttonOrders.TabIndex = 15;
            buttonOrders.Text = "ORDERS";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.FlatStyle = FlatStyle.System;
            labelHistory.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            labelHistory.ForeColor = SystemColors.ActiveCaptionText;
            labelHistory.Location = new Point(608, 44);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(221, 62);
            labelHistory.TabIndex = 17;
            labelHistory.Text = "HISTORY";
            labelHistory.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerRefreshDisplay
            // 
            timerRefreshDisplay.Interval = 30000;
            timerRefreshDisplay.Tick += timerRefreshDisplay_Tick;
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Font = new Font("Segoe UI Historic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrompt.Location = new Point(505, 120);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(424, 30);
            labelPrompt.TabIndex = 19;
            labelPrompt.Text = "Press on an item to start/finish preparation";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 87);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1418, 968);
            Controls.Add(pictureBox1);
            Controls.Add(labelPrompt);
            Controls.Add(labelHistory);
            Controls.Add(buttonOrders);
            Controls.Add(listViewHistory);
            Controls.Add(buttonReady);
            Controls.Add(buttonStart);
            Controls.Add(listViewOrders);
            Controls.Add(labelOrders);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonHistory);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonHistory;
        private Button buttonLogOut;
        private Label labelOrders;
        private ListView listViewOrders;
        private ColumnHeader Table;
        private ColumnHeader Quantity;
        private ColumnHeader Item;
        private ColumnHeader Received;
        private ColumnHeader Waiting;
        private ColumnHeader Status;
        private Button buttonStart;
        private Button buttonReady;
        private ListView listViewHistory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button buttonOrders;
        private Label labelHistory;
        private System.Windows.Forms.Timer timerRefreshDisplay;
        private Label labelPrompt;
        private PictureBox pictureBox1;
    }
}