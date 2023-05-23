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
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnOrderView = new System.Windows.Forms.Button();
            this.btnBarKitchenView = new System.Windows.Forms.Button();
            this.btnPaymentView = new System.Windows.Forms.Button();
            this.btnManagerView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(316, 131);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(153, 29);
            this.btnTableView.TabIndex = 0;
            this.btnTableView.Text = "Table View";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnOrderView
            // 
            this.btnOrderView.Location = new System.Drawing.Point(316, 166);
            this.btnOrderView.Name = "btnOrderView";
            this.btnOrderView.Size = new System.Drawing.Size(153, 29);
            this.btnOrderView.TabIndex = 1;
            this.btnOrderView.Text = "Order View";
            this.btnOrderView.UseVisualStyleBackColor = true;
            this.btnOrderView.Click += new System.EventHandler(this.btnOrderView_Click);
            // 
            // btnBarKitchenView
            // 
            this.btnBarKitchenView.Location = new System.Drawing.Point(316, 201);
            this.btnBarKitchenView.Name = "btnBarKitchenView";
            this.btnBarKitchenView.Size = new System.Drawing.Size(153, 29);
            this.btnBarKitchenView.TabIndex = 2;
            this.btnBarKitchenView.Text = "Bar Kitchen View";
            this.btnBarKitchenView.UseVisualStyleBackColor = true;
            this.btnBarKitchenView.Click += new System.EventHandler(this.btnBarKitchenView_Click);
            // 
            // btnPaymentView
            // 
            this.btnPaymentView.Location = new System.Drawing.Point(316, 236);
            this.btnPaymentView.Name = "btnPaymentView";
            this.btnPaymentView.Size = new System.Drawing.Size(153, 29);
            this.btnPaymentView.TabIndex = 3;
            this.btnPaymentView.Text = "Payment View";
            this.btnPaymentView.UseVisualStyleBackColor = true;
            this.btnPaymentView.Click += new System.EventHandler(this.btnPaymentView_Click);
            // 
            // btnManagerView
            // 
            this.btnManagerView.Location = new System.Drawing.Point(316, 271);
            this.btnManagerView.Name = "btnManagerView";
            this.btnManagerView.Size = new System.Drawing.Size(153, 29);
            this.btnManagerView.TabIndex = 5;
            this.btnManagerView.Text = "Manager View";
            this.btnManagerView.UseVisualStyleBackColor = true;
            this.btnManagerView.Click += new System.EventHandler(this.btnManagerView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "This is the temporary login view";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManagerView);
            this.Controls.Add(this.btnPaymentView);
            this.Controls.Add(this.btnBarKitchenView);
            this.Controls.Add(this.btnOrderView);
            this.Controls.Add(this.btnTableView);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

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