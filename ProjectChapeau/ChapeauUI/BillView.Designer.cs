namespace ChapeauUI
{
    partial class BillView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillView));
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            listViewBills = new ListView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(-1, 1011);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 38);
            panel4.TabIndex = 61;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(-1, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 46);
            panel3.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 10);
            panel1.TabIndex = 62;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 10);
            panel5.TabIndex = 50;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(60, 813);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(172, 102);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Return";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 103);
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.Location = new Point(228, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(332, 67);
            lblHeading.TabIndex = 57;
            lblHeading.Text = "Bills Overview";
            // 
            // listViewBills
            // 
            listViewBills.FullRowSelect = true;
            listViewBills.Location = new Point(37, 181);
            listViewBills.Name = "listViewBills";
            listViewBills.Size = new Size(759, 525);
            listViewBills.TabIndex = 62;
            listViewBills.UseCompatibleStateImageBehavior = false;
            listViewBills.View = View.Details;
            // 
            // BillView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(836, 1055);
            Controls.Add(listViewBills);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "BillView";
            Text = "BillView";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private Label lblHeading;
        private ListView listViewBills;
    }
}