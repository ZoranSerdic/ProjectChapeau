namespace ChapeauUI
{
    partial class NewMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMenuItem));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            lblName = new Label();
            txtBoxName = new TextBox();
            lblType = new Label();
            lblVAT = new Label();
            lblTimeAvailability = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            radBtnDrink = new RadioButton();
            radBtnStarter = new RadioButton();
            radBtnMainDish = new RadioButton();
            radBtnDessert = new RadioButton();
            radBtnAlcoholic = new RadioButton();
            radBtnNonAlcoholic = new RadioButton();
            radBtnLunchTime = new RadioButton();
            radBtnDinnerTime = new RadioButton();
            radBtnAllDay = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            numPrice = new NumericUpDown();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(379, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "New menu item";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(62, 196);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Name:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(65, 235);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(182, 27);
            txtBoxName.TabIndex = 16;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(65, 340);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 17;
            lblType.Text = "Type:";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Location = new Point(65, 461);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(37, 20);
            lblVAT.TabIndex = 18;
            lblVAT.Text = "VAT:";
            // 
            // lblTimeAvailability
            // 
            lblTimeAvailability.AutoSize = true;
            lblTimeAvailability.Location = new Point(65, 609);
            lblTimeAvailability.Name = "lblTimeAvailability";
            lblTimeAvailability.Size = new Size(143, 20);
            lblTimeAvailability.TabIndex = 19;
            lblTimeAvailability.Text = "Time of availability: ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(125, 798);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(629, 798);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 21;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // radBtnDrink
            // 
            radBtnDrink.AutoSize = true;
            radBtnDrink.Location = new Point(22, 18);
            radBtnDrink.Name = "radBtnDrink";
            radBtnDrink.Size = new Size(65, 24);
            radBtnDrink.TabIndex = 22;
            radBtnDrink.TabStop = true;
            radBtnDrink.Text = "Drink";
            radBtnDrink.UseVisualStyleBackColor = true;
            // 
            // radBtnStarter
            // 
            radBtnStarter.AutoSize = true;
            radBtnStarter.Location = new Point(202, 18);
            radBtnStarter.Name = "radBtnStarter";
            radBtnStarter.Size = new Size(74, 24);
            radBtnStarter.TabIndex = 23;
            radBtnStarter.TabStop = true;
            radBtnStarter.Text = "Starter";
            radBtnStarter.UseVisualStyleBackColor = true;
            // 
            // radBtnMainDish
            // 
            radBtnMainDish.AutoSize = true;
            radBtnMainDish.Location = new Point(397, 18);
            radBtnMainDish.Name = "radBtnMainDish";
            radBtnMainDish.Size = new Size(96, 24);
            radBtnMainDish.TabIndex = 24;
            radBtnMainDish.TabStop = true;
            radBtnMainDish.Text = "Main Dish";
            radBtnMainDish.UseVisualStyleBackColor = true;
            // 
            // radBtnDessert
            // 
            radBtnDessert.AutoSize = true;
            radBtnDessert.Location = new Point(587, 18);
            radBtnDessert.Name = "radBtnDessert";
            radBtnDessert.Size = new Size(79, 24);
            radBtnDessert.TabIndex = 25;
            radBtnDessert.TabStop = true;
            radBtnDessert.Text = "Dessert";
            radBtnDessert.UseVisualStyleBackColor = true;
            // 
            // radBtnAlcoholic
            // 
            radBtnAlcoholic.AutoSize = true;
            radBtnAlcoholic.Location = new Point(24, 29);
            radBtnAlcoholic.Name = "radBtnAlcoholic";
            radBtnAlcoholic.Size = new Size(126, 24);
            radBtnAlcoholic.TabIndex = 26;
            radBtnAlcoholic.TabStop = true;
            radBtnAlcoholic.Text = "Alcoholic Item";
            radBtnAlcoholic.UseVisualStyleBackColor = true;
            // 
            // radBtnNonAlcoholic
            // 
            radBtnNonAlcoholic.AutoSize = true;
            radBtnNonAlcoholic.Location = new Point(204, 29);
            radBtnNonAlcoholic.Name = "radBtnNonAlcoholic";
            radBtnNonAlcoholic.Size = new Size(158, 24);
            radBtnNonAlcoholic.TabIndex = 27;
            radBtnNonAlcoholic.TabStop = true;
            radBtnNonAlcoholic.Text = "Non-alcoholic Item";
            radBtnNonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // radBtnLunchTime
            // 
            radBtnLunchTime.AutoSize = true;
            radBtnLunchTime.Location = new Point(25, 22);
            radBtnLunchTime.Name = "radBtnLunchTime";
            radBtnLunchTime.Size = new Size(105, 24);
            radBtnLunchTime.TabIndex = 28;
            radBtnLunchTime.TabStop = true;
            radBtnLunchTime.Text = "Lunch Time";
            radBtnLunchTime.UseVisualStyleBackColor = true;
            // 
            // radBtnDinnerTime
            // 
            radBtnDinnerTime.AutoSize = true;
            radBtnDinnerTime.Location = new Point(205, 22);
            radBtnDinnerTime.Name = "radBtnDinnerTime";
            radBtnDinnerTime.Size = new Size(111, 24);
            radBtnDinnerTime.TabIndex = 29;
            radBtnDinnerTime.TabStop = true;
            radBtnDinnerTime.Text = "Dinner Time";
            radBtnDinnerTime.UseVisualStyleBackColor = true;
            // 
            // radBtnAllDay
            // 
            radBtnAllDay.AutoSize = true;
            radBtnAllDay.Location = new Point(400, 22);
            radBtnAllDay.Name = "radBtnAllDay";
            radBtnAllDay.Size = new Size(78, 24);
            radBtnAllDay.TabIndex = 30;
            radBtnAllDay.TabStop = true;
            radBtnAllDay.Text = "All Day";
            radBtnAllDay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radBtnDessert);
            panel1.Controls.Add(radBtnMainDish);
            panel1.Controls.Add(radBtnStarter);
            panel1.Controls.Add(radBtnDrink);
            panel1.Location = new Point(65, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 61);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(radBtnNonAlcoholic);
            panel2.Controls.Add(radBtnAlcoholic);
            panel2.Location = new Point(63, 504);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 73);
            panel2.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(radBtnAllDay);
            panel3.Controls.Add(radBtnDinnerTime);
            panel3.Controls.Add(radBtnLunchTime);
            panel3.Location = new Point(62, 642);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 70);
            panel3.TabIndex = 33;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(462, 236);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 34;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(461, 206);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 35;
            lblPrice.Text = "Price:";
            // 
            // NewMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblTimeAvailability);
            Controls.Add(lblVAT);
            Controls.Add(lblType);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "NewMenuItem";
            Text = "NewMenuItem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblName;
        private TextBox txtBoxName;
        private Label lblType;
        private Label lblVAT;
        private Label lblTimeAvailability;
        private Button btnCancel;
        private Button btnConfirm;
        private RadioButton radBtnDrink;
        private RadioButton radBtnStarter;
        private RadioButton radBtnMainDish;
        private RadioButton radBtnDessert;
        private RadioButton radBtnAlcoholic;
        private RadioButton radBtnNonAlcoholic;
        private RadioButton radBtnLunchTime;
        private RadioButton radBtnDinnerTime;
        private RadioButton radBtnAllDay;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private NumericUpDown numPrice;
        private Label lblPrice;
    }
}