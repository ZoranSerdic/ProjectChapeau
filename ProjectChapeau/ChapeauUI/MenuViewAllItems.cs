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
    public partial class MenuViewAllItems : Form
    {
        public MenuViewAllItems()
        {
            InitializeComponent();
            List<MenuItem> items = new List<MenuItem>();
            MenuItemService menuItemsService = new MenuItemService();
            items.AddRange(menuItemsService.GetAllMenuItems());

            DisplayMenuItems(items);
        }

        //fills the listview with all the items 
        public void DisplayMenuItems(List<MenuItem> items)
        {
            //clear the listview before filling it
            listViewMenuItems.Clear();

            //adding the columns
            listViewMenuItems.Columns.Add("Menu Item ID", 110);
            listViewMenuItems.Columns.Add("Name", 430);
            listViewMenuItems.Columns.Add("Price", 60);
            listViewMenuItems.Columns.Add("Vat", 60);
            listViewMenuItems.Columns.Add("Type", 80);

            //adding the rows to the listview
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.MenuItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Vat.ToString());
                li.SubItems.Add(item.CourseType.ToString());
                li.Tag = item;
                listViewMenuItems.Items.Add(li);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuOverviewView menuOverviewView = new MenuOverviewView();
            menuOverviewView.ShowDialog();
            this.Close();
        }
    }
}
