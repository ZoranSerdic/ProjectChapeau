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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listViewOrders.SelectedItems.Count == 1)
            {
                int selectedIndex = e.Item.Index;
                string name = e.Item.SubItems[0].Text;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    Order.OrderedItems.RemoveAt(selectedIndex);
                    DisplayOrderedItems();
                }
                else
                {
                    // Restore selection
                    listViewOrders.Items[selectedIndex].Selected = true;
                }
            }
        }

        private void buttonRemoveAllOrders_Click(object sender, EventArgs e)
        {
            listViewOrders.Clear();
            Order.OrderedItems.Clear();
        }
    }
}
