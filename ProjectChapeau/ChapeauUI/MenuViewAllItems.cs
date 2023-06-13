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
        MenuItemService menuItemsService;
        List<MenuItem> items;

        public MenuViewAllItems()
        {
            InitializeComponent();
            items = new List<MenuItem>();
            menuItemsService = new MenuItemService();
            items.AddRange(menuItemsService.GetAllMenuItems());

            DisplayMenuItems(items);
        }

        //fills the listview with all the items 
        public void DisplayMenuItems(List<MenuItem> items)
        {
            //clear the listview before filling it
            listViewMenuItems.Clear();

            //adding the columns
            listViewMenuItems.Columns.Add("ID", 50);
            listViewMenuItems.Columns.Add("Name", 190);
            listViewMenuItems.Columns.Add("Description", 360);
            listViewMenuItems.Columns.Add("Price", 60);
            listViewMenuItems.Columns.Add("Vat", 60);
            listViewMenuItems.Columns.Add("Type", 100);

            //adding the rows to the listview
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.MenuItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Description);
                li.SubItems.Add(item.Price.ToString("0.00"));
                li.SubItems.Add(item.Vat.ToString());
                li.SubItems.Add(item.CourseType.ToString());
                li.Tag = item;
                listViewMenuItems.Items.Add(li);
            }
        }

        private void UpdateListview()
        {
            listViewMenuItems.Items.Clear();
            items.Clear();
            items.AddRange(menuItemsService.GetAllMenuItems());
            DisplayMenuItems(items);
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
                selectedItem.Description = selectedMenuItemRow.SubItems[2].Text;
                selectedItem.Price = decimal.Parse(selectedMenuItemRow.SubItems[3].Text);
                selectedItem.Vat = float.Parse(selectedMenuItemRow.SubItems[4].Text);
                //to get the correct enum, first get it as a string, then convert and assign
                string type = selectedMenuItemRow.SubItems[5].Text;
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
            NewMenuItem editMenuItem = new NewMenuItem(this.selectedItem);
            editMenuItem.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewMenuItem newEmployee = new NewMenuItem();
            newEmployee.ShowDialog();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewMenuItems.SelectedItems.Count > 0)
            {
                MenuItem item = new MenuItem();
                ListViewItem selectedListViewItemRow = listViewMenuItems.SelectedItems[0];

                //adds the menuID from the row to the menu Item 
                item.MenuItemId = int.Parse(selectedListViewItemRow.SubItems[0].Text);

                //double checks action 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        menuItemsService.RemoveItem(item);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        Return();
                    }
                    MessageBox.Show("Menu item was successfully removed from the database", "Success!");
                    UpdateListview();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Menu Item was selected", "Error");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return();
        }
        private void Return()
        {
            //this.Hide();
            //ManagerView managerView = new ManagerView();
            //managerView.ShowDialog();
            this.Close();
        }
    }
}
