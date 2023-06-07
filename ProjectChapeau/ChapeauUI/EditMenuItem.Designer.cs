namespace ChapeauUI
{
    partial class EditMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenuItem));
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            txtBoxName = new TextBox();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            radBtnDessert = new RadioButton();
            radBtnMainDish = new RadioButton();
            panel1 = new Panel();
            radBtnStarter = new RadioButton();
            radBtnDrink = new RadioButton();
            lblHeading = new Label();
            radBtnNonAlcoholic = new RadioButton();
            panel2 = new Panel();
            radBtnAlcoholic = new RadioButton();
            btnCancel = new Button();
            btnConfirm = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            lblType = new Label();
            lblVat = new Label();
            lblSubHeading = new Label();
            txtBoxDescription = new TextBox();
            lblDescription = new Label();
            lblMenuType = new Label();
            panel7 = new Panel();
            radBtnDinner = new RadioButton();
            radBtnLunch = new RadioButton();
            radBtnAllDay = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(461, 274);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 47;
            lblPrice.Text = "Price:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(461, 326);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 46;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(62, 326);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(182, 27);
            txtBoxName.TabIndex = 39;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(62, 274);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 38;
            lblName.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
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
            // panel1
            // 
            panel1.Controls.Add(radBtnDessert);
            panel1.Controls.Add(radBtnMainDish);
            panel1.Controls.Add(radBtnStarter);
            panel1.Controls.Add(radBtnDrink);
            panel1.Location = new Point(65, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 61);
            panel1.TabIndex = 43;
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
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(267, 33);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(363, 67);
            lblHeading.TabIndex = 36;
            lblHeading.Text = "Edit menu item";
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
            // panel2
            // 
            panel2.Controls.Add(radBtnNonAlcoholic);
            panel2.Controls.Add(radBtnAlcoholic);
            panel2.Location = new Point(65, 565);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 73);
            panel2.TabIndex = 44;
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
            // btnCancel
            // 
            btnCancel.Location = new Point(59, 896);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 96);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(567, 896);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(164, 96);
            btnConfirm.TabIndex = 42;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 44);
            panel3.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 10);
            panel5.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(0, 1019);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 49;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.Location = new Point(0, 121);
            panel6.Name = "panel6";
            panel6.Size = new Size(839, 10);
            panel6.TabIndex = 51;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(65, 382);
            lblType.Name = "lblType";
            lblType.Size = new Size(92, 20);
            lblType.TabIndex = 52;
            lblType.Text = "Course Type:";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Location = new Point(65, 526);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(33, 20);
            lblVat.TabIndex = 53;
            lblVat.Text = "Vat:";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubHeading.Location = new Point(89, 186);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(673, 46);
            lblSubHeading.TabIndex = 54;
            lblSubHeading.Text = "Please fill in this form to edit the menu item";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(62, 822);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(663, 27);
            txtBoxDescription.TabIndex = 61;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(59, 783);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 60;
            lblDescription.Text = "Description:";
            // 
            // lblMenuType
            // 
            lblMenuType.AutoSize = true;
            lblMenuType.Location = new Point(62, 653);
            lblMenuType.Name = "lblMenuType";
            lblMenuType.Size = new Size(84, 20);
            lblMenuType.TabIndex = 63;
            lblMenuType.Text = "Menu Type:";
            // 
            // panel7
            // 
            panel7.Controls.Add(radBtnAllDay);
            panel7.Controls.Add(radBtnDinner);
            panel7.Controls.Add(radBtnLunch);
            panel7.Location = new Point(62, 692);
            panel7.Name = "panel7";
            panel7.Size = new Size(585, 73);
            panel7.TabIndex = 62;
            // 
            // radBtnDinner
            // 
            radBtnDinner.AutoSize = true;
            radBtnDinner.Location = new Point(204, 29);
            radBtnDinner.Name = "radBtnDinner";
            radBtnDinner.Size = new Size(74, 24);
            radBtnDinner.TabIndex = 27;
            radBtnDinner.TabStop = true;
            radBtnDinner.Text = "Dinner";
            radBtnDinner.UseVisualStyleBackColor = true;
            // 
            // radBtnLunch
            // 
            radBtnLunch.AutoSize = true;
            radBtnLunch.Location = new Point(24, 29);
            radBtnLunch.Name = "radBtnLunch";
            radBtnLunch.Size = new Size(68, 24);
            radBtnLunch.TabIndex = 26;
            radBtnLunch.TabStop = true;
            radBtnLunch.Text = "Lunch";
            radBtnLunch.UseVisualStyleBackColor = true;
            // 
            // radBtnAllDay
            // 
            radBtnAllDay.AutoSize = true;
            radBtnAllDay.Location = new Point(369, 29);
            radBtnAllDay.Name = "radBtnAllDay";
            radBtnAllDay.Size = new Size(78, 24);
            radBtnAllDay.TabIndex = 28;
            radBtnAllDay.TabStop = true;
            radBtnAllDay.Text = "All Day";
            radBtnAllDay.UseVisualStyleBackColor = true;
            // 
            // EditMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(lblMenuType);
            Controls.Add(panel7);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblSubHeading);
            Controls.Add(lblVat);
            Controls.Add(lblType);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblHeading);
            Controls.Add(panel2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Name = "EditMenuItem";
            Text = "EditMenuItem";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private NumericUpDown numPrice;
        private TextBox txtBoxName;
        private Label lblName;
        private PictureBox pictureBox1;
        private RadioButton radBtnDessert;
        private RadioButton radBtnMainDish;
        private Panel panel1;
        private RadioButton radBtnStarter;
        private RadioButton radBtnDrink;
        private Label lblHeading;
        private RadioButton radBtnNonAlcoholic;
        private Panel panel2;
        private RadioButton radBtnAlcoholic;
        private Button btnCancel;
        private Button btnConfirm;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label lblType;
        private Label lblVat;
        private Label lblSubHeading;
        private TextBox txtBoxDescription;
        private Label lblDescription;
        private Label lblMenuType;
        private Panel panel7;
        private RadioButton radBtnAllDay;
        private RadioButton radBtnDinner;
        private RadioButton radBtnLunch;
    }
}