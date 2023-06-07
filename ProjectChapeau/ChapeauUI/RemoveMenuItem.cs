using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class RemoveMenuItem : Form
    {
        MenuItemService menuItemService;
        public RemoveMenuItem(List<MenuItem> menuItems)
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            DisplayMenuItems(menuItems);
        }
        public void DisplayMenuItems(List<MenuItem> items)
        {
            //clear the listview before filling it
            listViewItemsList.Clear();

            //adding the columns
            listViewItemsList.Columns.Add("ID", 60);
            listViewItemsList.Columns.Add("Name", 120);
            listViewItemsList.Columns.Add("Description", 320);
            listViewItemsList.Columns.Add("Price", 60);
            listViewItemsList.Columns.Add("Vat", 60);
            //listViewItemsList.Columns.Add("Course Type", 100);
            listViewItemsList.Columns.Add("Menu Type", 100);

            //adding the rows to the listview
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.MenuItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Description);
                li.SubItems.Add(item.Price.ToString("0.00"));
                li.SubItems.Add(item.Vat.ToString());
                //li.SubItems.Add(item.CourseType.ToString());
                li.SubItems.Add(item.MenuType.ToString());
                li.Tag = item;
                listViewItemsList.Items.Add(li);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewItemsList.SelectedItems.Count > 0)
            {
                MenuItem item = new MenuItem();
                ListViewItem selectedListViewItemRow = listViewItemsList.SelectedItems[0];

                //adds the menuID from the row to the menu Item 
                item.MenuItemId = int.Parse(selectedListViewItemRow.SubItems[0].Text);

                //double checks action 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        menuItemService.RemoveItem(item);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        Return();
                    }
                    MessageBox.Show("Menu item was successfully removed from the database", "Success!");
                    Return();
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
            this.Hide();
            MenuItemSelectionView itemSelection = new MenuItemSelectionView();
            itemSelection.ShowDialog();
            this.Close();
        }
    }
}
