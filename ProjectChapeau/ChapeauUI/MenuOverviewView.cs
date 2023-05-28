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
    public partial class MenuOverviewView : Form
    {
        public MenuOverviewView()
        {
            InitializeComponent();
        }

        private void btnNewMenuItem_Click(object sender, EventArgs e)
        {
            //hides this panel, and opens the NewMenuItem form, and closes this form 
            this.Hide();
            NewMenuItem newMenuItem = new NewMenuItem();
            newMenuItem.ShowDialog();
            this.Close();
        }

        private void btmMainDishes_Click(object sender, EventArgs e)
        {
            //hides this panel, and opens the MenuItemSelection form, and closes this form 
            this.Hide();
            MenuItemSelectionView itemSelection = new MenuItemSelectionView();
            itemSelection.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //hides then closes this form, and returns to the Manager view
            this.Hide();
            ManagerView managerView = new ManagerView();
            managerView.ShowDialog();
            this.Close();
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuViewAllItems menuViews = new MenuViewAllItems();
            menuViews.ShowDialog();
            this.Close();
        }
    }
}
