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
            btnCancel = new Button();
            btnConfirm = new Button();
            radBtnDrink = new RadioButton();
            radBtnStarter = new RadioButton();
            radBtnMainDish = new RadioButton();
            radBtnDessert = new RadioButton();
            radBtnAlcoholic = new RadioButton();
            radBtnNonAlcoholic = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            numPrice = new NumericUpDown();
            lblPrice = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            lblSubHeading = new Label();
            txtBoxDescription = new TextBox();
            lblDescription = new Label();
            lblMenuType = new Label();
            panel7 = new Panel();
            radBtnAllDay = new RadioButton();
            radBtnDinner = new RadioButton();
            radBtnLunch = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
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
            lblHeading.Size = new Size(417, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "Menu Items Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 264);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Name:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(66, 303);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(182, 27);
            txtBoxName.TabIndex = 16;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(65, 386);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 17;
            lblType.Text = "Type:";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Location = new Point(65, 529);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(37, 20);
            lblVAT.TabIndex = 18;
            lblVAT.Text = "VAT:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(50, 913);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 59);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(576, 911);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 62);
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
            // panel1
            // 
            panel1.Controls.Add(radBtnDessert);
            panel1.Controls.Add(radBtnMainDish);
            panel1.Controls.Add(radBtnStarter);
            panel1.Controls.Add(radBtnDrink);
            panel1.Location = new Point(65, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 61);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(radBtnNonAlcoholic);
            panel2.Controls.Add(radBtnAlcoholic);
            panel2.Location = new Point(62, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 73);
            panel2.TabIndex = 32;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(463, 304);
            numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 34;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(462, 274);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 35;
            lblPrice.Text = "Price:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Location = new Point(0, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 10);
            panel3.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(0, 1017);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 56;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 46);
            panel5.TabIndex = 55;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.Location = new Point(0, 34);
            panel6.Name = "panel6";
            panel6.Size = new Size(839, 10);
            panel6.TabIndex = 50;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubHeading.Location = new Point(50, 188);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(672, 46);
            lblSubHeading.TabIndex = 57;
            lblSubHeading.Text = "Please fill in this form to add the menu item";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(53, 856);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(663, 27);
            txtBoxDescription.TabIndex = 59;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(50, 817);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 58;
            lblDescription.Text = "Description:";
            // 
            // lblMenuType
            // 
            lblMenuType.AutoSize = true;
            lblMenuType.Location = new Point(58, 658);
            lblMenuType.Name = "lblMenuType";
            lblMenuType.Size = new Size(84, 20);
            lblMenuType.TabIndex = 65;
            lblMenuType.Text = "Menu Type:";
            // 
            // panel7
            // 
            panel7.Controls.Add(radBtnAllDay);
            panel7.Controls.Add(radBtnDinner);
            panel7.Controls.Add(radBtnLunch);
            panel7.Location = new Point(58, 697);
            panel7.Name = "panel7";
            panel7.Size = new Size(585, 73);
            panel7.TabIndex = 64;
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
            // NewMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(836, 1055);
            Controls.Add(lblMenuType);
            Controls.Add(panel7);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblSubHeading);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
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
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Button btnCancel;
        private Button btnConfirm;
        private RadioButton radBtnDrink;
        private RadioButton radBtnStarter;
        private RadioButton radBtnMainDish;
        private RadioButton radBtnDessert;
        private RadioButton radBtnAlcoholic;
        private RadioButton radBtnNonAlcoholic;
        private Panel panel1;
        private Panel panel2;
        private NumericUpDown numPrice;
        private Label lblPrice;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
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