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
        int quantity = 0;

        public OrderPopup(string popupName, string popupDescription)
        {
            InitializeComponent();

            labelPopupName.Text = popupName;
            labelPopupDescription.Text = popupDescription;
            labelQuantityAmount.Text = quantity.ToString();
        }

        private void buttonQuantityMinus_Click(object sender, EventArgs e)
        {
            quantity--;
            UpdateQuantity();
        }

        private void buttonQuantityPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateQuantity();
        }

        private void buttonPopupAddOrder_Click(object sender, EventArgs e)
        {
            // TODO: Add order to a list which contains of all the other orders

            // for each quantity add separately 
        }

        private void buttonPopupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateQuantity()
        {
            labelQuantityAmount.Text = quantity.ToString();
        }
    }
}
