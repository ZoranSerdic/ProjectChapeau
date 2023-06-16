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
                ListViewItem listViewItem = new ListViewItem(orderItem.MenuItem.Name);
                listViewItem.SubItems.Add(orderItem.Comment);
                listViewItem.SubItems.Add(orderItem.Amount.ToString()); 
                listViewItem.Tag = orderItem;

                listViewOrders.Items.Add(listViewItem);
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

        private void buttonRemoveAllOrders_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to remove all Orders from the Order list?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                listViewOrders.Clear();
                Order.OrderedItems.Clear();
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listViewOrders.SelectedItems.Count == 1)
            {

                ListViewItem selectedItem = e.Item;

                // Retrieve the MenuItem object from the Tag property
                OrderItem orderItem = selectedItem.Tag as OrderItem;

                DialogResult result = MessageBox.Show($"Are you sure you want to remove {orderItem.MenuItem.Name} from the Order list?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Order.OrderedItems.RemoveAt(selectedItem.Index);
                    DisplayOrderedItems();
                }
                else
                {
                    // Prevent double selection
                    selectedItem.Selected = true;
                }
            }
        }
    }
}
