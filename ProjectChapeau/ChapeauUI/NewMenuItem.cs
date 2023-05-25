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
    public partial class NewMenuItem : Form
    {
        public NewMenuItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //clears and hides the form 
            ClearPanel();
            this.Hide();

            //returns to the menu overview 
            MenuOverviewView menuOverviewView = new MenuOverviewView();
            menuOverviewView.ShowDialog();

            //closes the form 
            this.Close();
        }
        private void ClearPanel()
        {
            //clears the information that the user has added
            txtBoxName.Text = string.Empty;
            radBtnDrink.Checked = false;
            radBtnStarter.Checked = false;
            radBtnMainDish.Checked = false;
            radBtnDessert.Checked = false;

            radBtnAlcoholic.Checked = false;
            radBtnNonAlcoholic.Checked = false;

            radBtnLunchTime.Checked = false;
            radBtnDinnerTime.Checked = false;
            radBtnAllDay.Checked = false;
        }
    }
}
