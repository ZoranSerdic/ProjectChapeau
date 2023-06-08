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
    public partial class InventoryOverview : Form
    {
        InventoryItemService service;
        InventoryItem selectedItem;
        bool update = false;
        public InventoryOverview()
        {
            service = new InventoryItemService();
            InitializeComponent();
            panelAdd.Hide();
            DisplayItems(service.GetInventoryItems());
        }
        public void DisplayItems(List<InventoryItem> items)
        {
            //adding the columns
            listViewInventory.Columns.Add("Stock item ID", 120);
            listViewInventory.Columns.Add("Name", 180);
            listViewInventory.Columns.Add("Count in stock", 150);
            listViewInventory.Columns.Add("Menu item ID", 120);

            //adding the rows to the listview
            foreach (InventoryItem item in items)
            {
                ListViewItem li = new ListViewItem(item.InventoryItemId.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.InStock.ToString());
                li.SubItems.Add(item.MenuItemID.ToString());
                li.Tag = item;
                listViewInventory.Items.Add(li);
            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewInventory.SelectedItems.Count > 0)
            {
                selectedItem = new InventoryItem();
                ListViewItem selectedListViewItemRow = listViewInventory.SelectedItems[0];

                //adds the itemId from the row (selected item) to the Item 
                selectedItem.InventoryItemId = int.Parse(selectedListViewItemRow.SubItems[0].Text);

                //double checks action 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    service.RemoveInventoryItem(selectedItem);
                    UpdateListView();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Employee was selected", "Error");
            }
        }
        private void UpdateListView()
        {
            listViewInventory.Clear();
            DisplayItems(service.GetInventoryItems());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnConfirm.Text = "Add item";
            panelAdd.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            ClearTextBoxes();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (BoxesNotEmpty())
            {
                selectedItem = new InventoryItem();
                if (update)
                {
                    ListViewItem seletedRow = listViewInventory.SelectedItems[0];
                    
                    //adds the menuID from the row to the menu Item 
                    selectedItem.InventoryItemId = int.Parse(seletedRow.SubItems[0].Text);
                    selectedItem.Name = txtBoxMenuId.Text;
                    selectedItem.InStock = int.Parse(txtBoxCount.Text);
                    service.UpdateInventoryItem(selectedItem);
                    update = false;
                }
                else
                {
                    selectedItem.MenuItemID = int.Parse(txtBoxMenuId.Text);
                    selectedItem.InStock = int.Parse(txtBoxCount.Text);
                    service.AddInventoryItem(selectedItem);
                }
                panelAdd.Hide();
                ClearTextBoxes();
                UpdateListView();
            }
            else
            {
                DisplayMessageBox("Missing information in the Form");
            }
        }

        private void DisplayMessageBox(string message)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Error");
        }
        private bool BoxesNotEmpty()
        {
            if (txtBoxMenuId.Text != "" || txtBoxCount.Text != "")
            {
                return true;
            }

            return false;
        }

        private void txtBoxCount_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared
            if (!int.TryParse(txtBoxCount.Text, out int result))
            {
                txtBoxCount.Text = string.Empty;
            }
        }
        private void txtBoxMenuId_TextChanged(object sender, EventArgs e)
        {
            //try to parse the input, if it is unsuccessful, the inside textbox is cleared
            if (!int.TryParse(txtBoxMenuId.Text, out int result))
            {
                txtBoxMenuId.Text = string.Empty;
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            //checks first if there is a selected row 
            if (listViewInventory.SelectedItems.Count > 0)
            {
                ListViewItem seletedRow = listViewInventory.SelectedItems[0];

                txtBoxCount.Text = (seletedRow.SubItems[2].Text).ToString();
                txtBoxMenuId.Text = (seletedRow.SubItems[3].Text).ToString();
                update = true;
                btnConfirm.Text = "Update";
                panelAdd.Show();
                txtBoxMenuId.Hide();    
                lblName.Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No Item was selected", "Error");
            }
        }
        private void ClearTextBoxes()
        {
            txtBoxCount.Text = string.Empty;
            txtBoxMenuId.Text = string.Empty;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.ShowDialog();
            this.Close();
        }

        
    }
}
