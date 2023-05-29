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
        private MenuItem selectedItem; 
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
            listViewMenuItems.Columns.Add("Type", 100);

            //adding the rows to the listview
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.MenuItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Price.ToString("0.00"));
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

        private void btnEditMenuItem_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewMenuItems.SelectedItems.Count > 0)
            {
                selectedItem = new MenuItem();
                ListViewItem selectedMenuItemRow = listViewMenuItems.SelectedItems[0];

                //adds the menuID from the row to the menu Item 
                selectedItem.MenuItemId = int.Parse(selectedMenuItemRow.SubItems[0].Text);
                selectedItem.Name = selectedMenuItemRow.SubItems[1].Text;
                selectedItem.Price = decimal.Parse(selectedMenuItemRow.SubItems[2].Text);
                selectedItem.Vat = float.Parse(selectedMenuItemRow.SubItems[3].Text);
                //to get the correct enum, first get it as a string, then convert and assign
                string type = selectedMenuItemRow.SubItems[4].Text;
                selectedItem.CourseType = (FoodType)Enum.Parse(typeof(FoodType), type);
                ChangeToEditEmployee();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Menu Item was selected", "Error");
            }
        }

        private void ChangeToEditEmployee()
        {
            this.Hide();
            EditMenuItem editMenuItem = new EditMenuItem(this.selectedItem);
            editMenuItem.ShowDialog();
            this.Close();
        }
    }
}
