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
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
        }

    }
}
