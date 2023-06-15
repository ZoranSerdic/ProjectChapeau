namespace ChapeauUI
{
    partial class TablePopup
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
            pictureBoxRedSeparator = new PictureBox();
            labelTableNumber = new Label();
            labelTableHaveBeenOccupied = new Label();
            buttonPlaceOrder = new Button();
            buttonGenerateBill = new Button();
            buttonGoBack = new Button();
            buttonCancelOccupation = new Button();
            listViewOrders = new ListView();
            itemName = new ColumnHeader();
            waitingTime = new ColumnHeader();
            orderStatus = new ColumnHeader();
            label_noOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRedSeparator
            // 
            pictureBoxRedSeparator.BackColor = Color.FromArgb(204, 68, 75);
            pictureBoxRedSeparator.Location = new Point(1, 12);
            pictureBoxRedSeparator.Name = "pictureBoxRedSeparator";
            pictureBoxRedSeparator.Size = new Size(606, 62);
            pictureBoxRedSeparator.TabIndex = 0;
            pictureBoxRedSeparator.TabStop = false;
            // 
            // labelTableNumber
            // 
            labelTableNumber.AutoSize = true;
            labelTableNumber.BackColor = Color.FromArgb(204, 68, 75);
            labelTableNumber.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableNumber.ForeColor = Color.White;
            labelTableNumber.Location = new Point(180, 26);
            labelTableNumber.Name = "labelTableNumber";
            labelTableNumber.Size = new Size(108, 48);
            labelTableNumber.TabIndex = 1;
            labelTableNumber.Text = "Table";
            // 
            // labelTableHaveBeenOccupied
            // 
            labelTableHaveBeenOccupied.AutoSize = true;
            labelTableHaveBeenOccupied.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTableHaveBeenOccupied.Location = new Point(115, 86);
            labelTableHaveBeenOccupied.Name = "labelTableHaveBeenOccupied";
            labelTableHaveBeenOccupied.Size = new Size(268, 31);
            labelTableHaveBeenOccupied.TabIndex = 2;
            labelTableHaveBeenOccupied.Text = "Table has been occupied";
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.BackColor = Color.FromArgb(57, 67, 183);
            buttonPlaceOrder.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlaceOrder.ForeColor = Color.White;
            buttonPlaceOrder.Location = new Point(151, 717);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(244, 66);
            buttonPlaceOrder.TabIndex = 3;
            buttonPlaceOrder.Text = "Place Order";
            buttonPlaceOrder.UseVisualStyleBackColor = false;
            buttonPlaceOrder.Click += buttonPlaceOrder_Click;
            // 
            // buttonGenerateBill
            // 
            buttonGenerateBill.BackColor = Color.FromArgb(16, 115, 26);
            buttonGenerateBill.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerateBill.ForeColor = Color.White;
            buttonGenerateBill.Location = new Point(126, 798);
            buttonGenerateBill.Name = "buttonGenerateBill";
            buttonGenerateBill.Size = new Size(292, 66);
            buttonGenerateBill.TabIndex = 4;
            buttonGenerateBill.Text = "Generate Bill";
            buttonGenerateBill.UseVisualStyleBackColor = false;
            buttonGenerateBill.Click += buttonGenerateBill_Click;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.FromArgb(204, 68, 75);
            buttonGoBack.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGoBack.ForeColor = Color.White;
            buttonGoBack.Location = new Point(12, 879);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(166, 62);
            buttonGoBack.TabIndex = 5;
            buttonGoBack.Text = "Go Back";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // buttonCancelOccupation
            // 
            buttonCancelOccupation.BackColor = Color.FromArgb(204, 68, 75);
            buttonCancelOccupation.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelOccupation.ForeColor = Color.White;
            buttonCancelOccupation.Location = new Point(202, 879);
            buttonCancelOccupation.Name = "buttonCancelOccupation";
            buttonCancelOccupation.Size = new Size(318, 62);
            buttonCancelOccupation.TabIndex = 6;
            buttonCancelOccupation.Text = "Cancel Occupation";
            buttonCancelOccupation.UseVisualStyleBackColor = false;
            buttonCancelOccupation.Click += buttonCancelOccupation_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Columns.AddRange(new ColumnHeader[] { itemName, waitingTime, orderStatus });
            listViewOrders.FullRowSelect = true;
            listViewOrders.Location = new Point(46, 129);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(437, 509);
            listViewOrders.TabIndex = 7;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.View = View.Details;
            // 
            // itemName
            // 
            itemName.Text = "Name";
            itemName.Width = 150;
            // 
            // waitingTime
            // 
            waitingTime.Text = "Waiting time";
            waitingTime.Width = 150;
            // 
            // orderStatus
            // 
            orderStatus.Text = "Status";
            orderStatus.Width = 150;
            // 
            // label_noOrder
            // 
            label_noOrder.AutoSize = true;
            label_noOrder.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_noOrder.Location = new Point(47, 241);
            label_noOrder.Name = "label_noOrder";
            label_noOrder.Size = new Size(436, 46);
            label_noOrder.TabIndex = 8;
            label_noOrder.Text = "This table did not order yet!";
            // 
            // TablePopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 250);
            ClientSize = new Size(532, 953);
            Controls.Add(label_noOrder);
            Controls.Add(listViewOrders);
            Controls.Add(buttonCancelOccupation);
            Controls.Add(buttonGoBack);
            Controls.Add(buttonGenerateBill);
            Controls.Add(buttonPlaceOrder);
            Controls.Add(labelTableHaveBeenOccupied);
            Controls.Add(labelTableNumber);
            Controls.Add(pictureBoxRedSeparator);
            Name = "TablePopup";
            Text = "TablePopup";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRedSeparator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxRedSeparator;
        private Label labelTableNumber;
        private Label labelTableHaveBeenOccupied;
        private Button buttonPlaceOrder;
        private Button buttonGenerateBill;
        private Button buttonGoBack;
        private Button buttonCancelOccupation;
        private ListView listViewOrders;
        private ColumnHeader itemName;
        private ColumnHeader waitingTime;
        private ColumnHeader orderStatus;
        private Label label_noOrder;
    }
}