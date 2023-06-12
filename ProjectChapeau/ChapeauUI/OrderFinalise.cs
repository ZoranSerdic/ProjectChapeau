using ChapeauModel;
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
    public partial class OrderFinalise : Form
    {
        public Order Order { get; private set; }

        public DialogResult Result { get; private set; }

        public OrderFinalise(Order order)
        {
            InitializeComponent();
            
            Order = order;
            DisplayOrderedItems();
        }

        private void DisplayOrderedItems()
        {
            // clear the listview items before filling it
            listViewOrders.Items.Clear();

            foreach (OrderItem orderItem in Order.OrderedItems)
            {
                ListViewItem item = new ListViewItem(orderItem.MenuItem.Name);
                item.SubItems.Add(orderItem.Comment);
                item.SubItems.Add(orderItem.Amount.ToString());

                listViewOrders.Items.Add(item);
            }
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            this.Close();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                int selectedIndex = listViewOrders.SelectedIndices[0];
                Order.OrderedItems.RemoveAt(selectedIndex);
                DisplayOrderedItems();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
