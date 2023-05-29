using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;

namespace ChapeauUI
{
    public partial class NewMenuItem : Form
    {
        MenuItemService menuItemService;
        public NewMenuItem()
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }
        /*private void ClearPanel()       this COULD BE removed 
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
        }*/

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //CHECKS FIRST IF ALL THE BTNS ARE CORRECTLY CHECKED 

            if (FieldsCorrect())
            {
                //Opens a message box for additional confirmation 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    //code for if the second confirmation occurs 
                    MenuItem newItem = new MenuItem();
                    CreateNewMenuItem(newItem);
                    menuItemService.AddItem(newItem);
                    dialogResult = MessageBox.Show("Menu item was successfully added to the database", "Success!");
                    ReturnToMenu();
                }
            }
            else
            {
                //shows message that the fields are inccorect 
                DialogResult dialogResult = MessageBox.Show("Fields not filled in correctly", "Error");
            }

        }
        private bool FieldsCorrect()
        {
            if (CheckNameAndPrice() && CheckMenuType() && CheckVat())
            {
                return true;
            }
            return false;
        }
        private bool CheckNameAndPrice()
        {
            //returns true if name and price are not empty 
            if (txtBoxName.Text != "" && numPrice != null)
            {
                return true;
            }
            return false;
        }
        private bool CheckMenuType()
        {
            //returns true if at least one radBtn is selected 
            if (radBtnDrink.Checked || radBtnStarter.Checked || radBtnMainDish.Checked || radBtnDessert.Checked)
            {
                return true;
            }
            return false;
        }
        private bool CheckVat()
        {
            //returns true if at least one radBtn is selected 
            if (radBtnAlcoholic.Checked || radBtnNonAlcoholic.Checked)
            {
                return true;
            }
            return false;
        }
        private void ReturnToMenu()
        {
            //clears and hides the form 
            //ClearPanel();
            this.Hide();

            //returns to the menu overview 
            MenuOverviewView menuOverviewView = new MenuOverviewView();
            menuOverviewView.ShowDialog();

            //closes the form 
            this.Close();
        }

        private void CreateNewMenuItem(MenuItem newItem)
        {
            newItem.Name = txtBoxName.Text;
            newItem.Price = numPrice.Value;

            if (radBtnDrink.Checked)
            {
                newItem.CourseType = FoodType.Drink;
            }
            else if (radBtnStarter.Checked)
            {
                newItem.CourseType = FoodType.Starter;
            }
            else if (radBtnMainDish.Checked)
            {
                newItem.CourseType = FoodType.MainCourse;
            }
            else
            {
                newItem.CourseType = FoodType.Dessert;
            }

            if (radBtnAlcoholic.Checked)
            {
                newItem.Vat = 2;
            }
            else
            {
                newItem.Vat = 1;
            }
        }
    }
}
