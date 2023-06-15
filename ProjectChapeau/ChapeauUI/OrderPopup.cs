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
        const int minimumQuantityAmount = 1;
        const int maximumQuantityAmount = 99;

        public string Comment { get; private set; }
        public int Amount { get; private set; }

        public OrderPopup(string popupName, string popupDescription)
        {
            InitializeComponent();
            Amount = 1;

            UpdateQuantity();
            labelPopupName.Text = popupName;
            labelPopupDescription.Text = popupDescription;
        }

        private void buttonQuantityMinus_Click(object sender, EventArgs e)
        {
            if (Amount > minimumQuantityAmount)
            {
                Amount--;
                UpdateQuantity();
            }
        }

        private void buttonQuantityPlus_Click(object sender, EventArgs e)
        {
            if (Amount < maximumQuantityAmount) 
            { 
                Amount++;
                UpdateQuantity();
            }
        }

        private void buttonPopupAddOrder_Click(object sender, EventArgs e)
        {
            Comment = textBoxPopupComment.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonPopupCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        void UpdateQuantity()
        {
            labelQuantityAmount.Text = Amount.ToString();
        }
    }
}
