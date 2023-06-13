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
            buttonPlaceOrder.Location = new Point(128, 139);
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
            buttonGenerateBill.Location = new Point(128, 705);
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
            // TablePopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 250);
            ClientSize = new Size(532, 953);
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
    }
}