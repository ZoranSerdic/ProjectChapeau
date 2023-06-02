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
            ListViewGroup listViewGroup1 = new ListViewGroup("gggggg", HorizontalAlignment.Center);
            ListViewGroup listViewGroup2 = new ListViewGroup("mmmmmm", HorizontalAlignment.Center);
            ListViewGroup listViewGroup3 = new ListViewGroup("fffff", HorizontalAlignment.Center);
            ListViewItem listViewItem1 = new ListViewItem("one");
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "two", "frfr" }, -1);
            ListViewItem listViewItem3 = new ListViewItem("three");
            buttonHistory = new Button();
            button2 = new Button();
            labelOrders = new Label();
            listViewOrders = new ListView();
            Table = new ColumnHeader();
            Quantity = new ColumnHeader();
            Item = new ColumnHeader();
            Received = new ColumnHeader();
            Waiting = new ColumnHeader();
            Status = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.Lime;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistory.Location = new Point(261, 36);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(190, 53);
            buttonHistory.TabIndex = 8;
            buttonHistory.Text = "HISTORY";
            buttonHistory.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(991, 36);
            button2.Name = "button2";
            button2.Size = new Size(190, 53);
            button2.TabIndex = 9;
            button2.Text = "LOG OUT";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.FlatStyle = FlatStyle.System;
            labelOrders.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrders.ForeColor = SystemColors.ActiveCaptionText;
            labelOrders.Location = new Point(610, 27);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(206, 62);
            labelOrders.TabIndex = 10;
            labelOrders.Text = "ORDERS";
            labelOrders.TextAlign = ContentAlignment.TopCenter;
            // 
            // listViewOrders
            // 
            listViewOrders.BackColor = SystemColors.ControlLight;
            listViewOrders.Columns.AddRange(new ColumnHeader[] { Table, Quantity, Item, Received, Waiting, Status });
            listViewOrders.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewOrders.FullRowSelect = true;
            listViewGroup1.Header = "gggggg";
            listViewGroup1.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "mmmmmm";
            listViewGroup2.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "fffff";
            listViewGroup3.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup3.Name = "listViewGroup3";
            listViewOrders.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup3;
            listViewOrders.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listViewOrders.Location = new Point(42, 128);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(1331, 793);
            listViewOrders.TabIndex = 11;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged;
            // 
            // Table
            // 
            Table.Text = "     Table";
            Table.Width = 120;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.TextAlign = HorizontalAlignment.Center;
            Quantity.Width = 150;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.TextAlign = HorizontalAlignment.Center;
            Item.Width = 570;
            // 
            // Received
            // 
            Received.Text = "Received";
            Received.TextAlign = HorizontalAlignment.Center;
            Received.Width = 150;
            // 
            // Waiting
            // 
            Waiting.Text = "Waiting";
            Waiting.TextAlign = HorizontalAlignment.Center;
            Waiting.Width = 150;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 180;
            // 
            // BarKitchenView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1418, 968);
            Controls.Add(listViewOrders);
            Controls.Add(labelOrders);
            Controls.Add(button2);
            Controls.Add(buttonHistory);
            Name = "BarKitchenView";
            Text = "BarKitchenView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonHistory;
        private Button button2;
        private Label labelOrders;
        private ListView listViewOrders;
        private ColumnHeader Table;
        private ColumnHeader Quantity;
        private ColumnHeader Item;
        private ColumnHeader Received;
        private ColumnHeader Waiting;
        private ColumnHeader Status;
    }
}