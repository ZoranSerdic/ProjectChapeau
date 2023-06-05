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
    public partial class ManagerView : Form
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryOverview inventoryOverview = new InventoryOverview();
            inventoryOverview.ShowDialog();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuOverviewView menuOverviewView = new MenuOverviewView();
            menuOverviewView.ShowDialog();
            this.Close();
        }

        private void btnTableOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableView tableView = new TableView();
            tableView.ShowDialog();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerEmployeeOverview employeeOverview = new ManagerEmployeeOverview();
            employeeOverview.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
            this.Close();
        }
    }
}
