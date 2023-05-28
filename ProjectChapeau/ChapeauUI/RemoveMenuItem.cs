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

namespace ChapeauUI
{
    public partial class RemoveMenuItem : Form
    {
        public RemoveMenuItem(List<MenuItem> menuItems)
        {
            InitializeComponent();
            DisplayMenuItems(menuItems);
        }
        public void DisplayMenuItems(List<MenuItem> items)
        {
            //clear the listview before filling it
            listViewItemsList.Clear();

            //adding the columns
            listViewItemsList.Columns.Add("Menu Item ID", 110);
            listViewItemsList.Columns.Add("Name", 430);
            listViewItemsList.Columns.Add("Price", 60);
            listViewItemsList.Columns.Add("Vat", 60);
            listViewItemsList.Columns.Add("Type", 100); // could be removed 

            //adding the rows to the listview
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.MenuItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Price.ToString("0.00"));
                li.SubItems.Add(item.Vat.ToString());
                li.SubItems.Add(item.CourseType.ToString());
                li.Tag = item;
                listViewItemsList.Items.Add(li);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuItemSelectionView itemSelection = new MenuItemSelectionView();
            itemSelection.ShowDialog();
            this.Close();
        }
    }
}
