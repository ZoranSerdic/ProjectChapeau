using ChapeauModel;
using ChapeauService;
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
    public partial class BarKitchenView : Form
    {
        private OrderService orderService;
        public BarKitchenView()
        {
            InitializeComponent();
            orderService = new OrderService();
            DisplayDrinks();
            // get logged in employee
            //if logged -in employee == bar then get-drinks else get - food)
        }
        private void DisplayDrinks()
        {
            List<Order> orders = orderService.GetDrinks();

            listViewOrders.Items.Clear();

            foreach (Order order in orders)
            {
                foreach (OrderItem orderedItem in order.OrderedItems)
                {
                    ListViewItem item = new ListViewItem(order.Table.TableId.ToString());
                    item.SubItems.Add(orderedItem.Amount.ToString());
                    /*if (string.IsNullOrEmpty(orderedItem.Comment))
                       item.SubItems.Add(orderedItem.MenuItem.Name);
                      else
                         item.SubItems.Add(orderedItem.MenuItem.Name + orderedItem.Comment);*/
                    item.SubItems.Add(string.IsNullOrEmpty(orderedItem.Comment)
                    ? orderedItem.MenuItem.Name
                    : orderedItem.MenuItem.Name + ": " + orderedItem.Comment.ToLower()); // rewrite thr formatting

                    item.SubItems.Add(order.Time.ToString("HH:mm"));
                    item.SubItems.Add((DateTime.Now - order.Time).ToString(@"hh\:mm"));
                    item.SubItems.Add(orderedItem.Status.ToString());

                    item.Tag = order;
                    listViewOrders.Items.Add(item);
                }
            }
        }

        private void DisplayFood()
        {
            
        }





        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
