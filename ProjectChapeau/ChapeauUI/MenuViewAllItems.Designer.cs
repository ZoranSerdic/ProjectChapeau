namespace ChapeauUI
{
    partial class MenuViewAllItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuViewAllItems));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            btnReturn = new Button();
            listViewMenuItems = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblHeading.Location = new Point(229, 31);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(577, 67);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "All Menu Items Overview";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(79, 813);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(205, 118);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // listViewMenuItems
            // 
            listViewMenuItems.FullRowSelect = true;
            listViewMenuItems.Location = new Point(12, 195);
            listViewMenuItems.Name = "listViewMenuItems";
            listViewMenuItems.Size = new Size(794, 497);
            listViewMenuItems.TabIndex = 16;
            listViewMenuItems.UseCompatibleStateImageBehavior = false;
            listViewMenuItems.View = View.Details;
            // 
            // MenuViewAllItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 1055);
            Controls.Add(listViewMenuItems);
            Controls.Add(btnReturn);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeading);
            Name = "MenuViewAllItems";
            Text = "MenuViewAllItems";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Button btnReturn;
        private ListView listViewMenuItems;
    }
}