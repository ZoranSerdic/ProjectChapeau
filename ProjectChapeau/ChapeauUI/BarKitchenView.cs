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
        private Employee loggedInEmployee;
        public BarKitchenView() // Employee loggedInEmployee
        {
            InitializeComponent();
            orderService = new OrderService();
            loggedInEmployee = new Employee();
            loggedInEmployee.Occupation = Role.Barman;
            //this.loggedInEmployee = loggedInEmployee;

            if(loggedInEmployee.Occupation == Role.Barman)
                DisplayUnpreparedDrinks();
            else if(loggedInEmployee.Occupation == Role.Chef)
                DisplayUnpreparedFood();
        }
        private void DisplayUnpreparedDrinks()
        {
            List<Order> orders = orderService.GetUnpreparedDrinks();

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

        private void DisplayUnpreparedFood()
        {
            
        }

        private void DisplayReadyDrinks()
        {

        }

        private void DisplayReadyFood()
        {

        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
