namespace ChapeauUI
{
    partial class LoginView
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
            btnTableView = new Button();
            btnOrderView = new Button();
            btnBarKitchenView = new Button();
            btnPaymentView = new Button();
            btnManagerView = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTableView
            // 
            btnTableView.Location = new Point(316, 131);
            btnTableView.Name = "btnTableView";
            btnTableView.Size = new Size(153, 29);
            btnTableView.TabIndex = 0;
            btnTableView.Text = "Table View";
            btnTableView.UseVisualStyleBackColor = true;
            btnTableView.Click += btnTableView_Click;
            // 
            // btnOrderView
            // 
            btnOrderView.Location = new Point(316, 166);
            btnOrderView.Name = "btnOrderView";
            btnOrderView.Size = new Size(153, 29);
            btnOrderView.TabIndex = 1;
            btnOrderView.Text = "Order View";
            btnOrderView.UseVisualStyleBackColor = true;
            btnOrderView.Click += btnOrderView_Click;
            // 
            // btnBarKitchenView
            // 
            btnBarKitchenView.Location = new Point(316, 201);
            btnBarKitchenView.Name = "btnBarKitchenView";
            btnBarKitchenView.Size = new Size(153, 29);
            btnBarKitchenView.TabIndex = 2;
            btnBarKitchenView.Text = "Bar Kitchen View";
            btnBarKitchenView.UseVisualStyleBackColor = true;
            btnBarKitchenView.Click += btnBarKitchenView_Click;
            // 
            // btnPaymentView
            // 
            btnPaymentView.Location = new Point(316, 236);
            btnPaymentView.Name = "btnPaymentView";
            btnPaymentView.Size = new Size(153, 29);
            btnPaymentView.TabIndex = 3;
            btnPaymentView.Text = "Payment View";
            btnPaymentView.UseVisualStyleBackColor = true;
            btnPaymentView.Click += btnPaymentView_Click;
            // 
            // btnManagerView
            // 
            btnManagerView.Location = new Point(316, 271);
            btnManagerView.Name = "btnManagerView";
            btnManagerView.Size = new Size(153, 29);
            btnManagerView.TabIndex = 5;
            btnManagerView.Text = "Manager View";
            btnManagerView.UseVisualStyleBackColor = true;
            btnManagerView.Click += btnManagerView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 39);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 6;
            label1.Text = "This is the temporary login view";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnManagerView);
            Controls.Add(btnPaymentView);
            Controls.Add(btnBarKitchenView);
            Controls.Add(btnOrderView);
            Controls.Add(btnTableView);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTableView;
        private Button btnOrderView;
        private Button btnBarKitchenView;
        private Button btnPaymentView;
        private Button btnManagerView;
        private Label label1;
    }
}