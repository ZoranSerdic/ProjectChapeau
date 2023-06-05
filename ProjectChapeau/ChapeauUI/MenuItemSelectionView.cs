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
    public partial class MenuItemSelectionView : Form
    {
        MenuItemService menuItemService;
        public MenuItemSelectionView()
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveMenuItem removeMenuItem = new RemoveMenuItem(menuItemService.GetAllDrinks());
            removeMenuItem.ShowDialog();
            this.Close();
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveMenuItem removeMenuItem = new RemoveMenuItem(menuItemService.GetAllStarters());
            removeMenuItem.ShowDialog();
            this.Close();
        }
        private void btnMainDishes_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveMenuItem removeMenuItem = new RemoveMenuItem(menuItemService.GetAllMains());
            removeMenuItem.ShowDialog();
            this.Close();
        }
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveMenuItem removeMenuItem = new RemoveMenuItem(menuItemService.GetAllDesserts());
            removeMenuItem.ShowDialog();
            this.Close();
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
