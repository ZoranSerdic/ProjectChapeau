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
        public MenuItemSelectionView()
        {
            InitializeComponent();
        }

        private void btmMainDishes_Click(object sender, EventArgs e)
        {
        }

        private void btnNewMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
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
