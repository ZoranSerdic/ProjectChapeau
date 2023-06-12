using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderPopup : Form
    {
        public string Comment { get; private set; }
        public int Amount { get; private set; }

        public OrderPopup(string popupName, string popupDescription)
        {
            InitializeComponent();

            labelPopupName.Text = popupName;
            labelPopupDescription.Text = popupDescription;
            labelQuantityAmount.Text = Amount.ToString();
        }

        private void buttonQuantityMinus_Click(object sender, EventArgs e)
        {
            if (Amount > 0)
            {
                Amount--;
            }

            UpdateQuantity();
        }

        private void buttonQuantityPlus_Click(object sender, EventArgs e)
        {
            Amount++;
            UpdateQuantity();
        }

        private void buttonPopupAddOrder_Click(object sender, EventArgs e)
        {
            Comment = textBoxPopupComment.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonPopupCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void UpdateQuantity()
        {
            labelQuantityAmount.Text = Amount.ToString();
        }
    }
}
