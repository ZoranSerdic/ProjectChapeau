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
    public partial class EditMenuItem : Form
    {
        private MenuItem menuItem;
        private MenuItem updatedItem;
        private MenuItemService menuItemService;
        public EditMenuItem(MenuItem menuItem)
        {
            this.menuItem = menuItem;
            menuItemService = new MenuItemService();
            InitializeComponent();
            FillForm();
        }
        private void FillForm()
        {
            txtBoxName.Text = menuItem.Name;
            numPrice.Value = menuItem.Price;
            txtBoxDescription.Text = menuItem.Description;
            FillRadButtons();
        }
        private void FillRadButtons()
        {
            //preselects the correct radiobuttons for the user 
            if (menuItem.CourseType == FoodType.MainCourse)
            {
                radBtnMainDish.Checked = true;
            }
            else if (menuItem.CourseType == FoodType.Drink)
            {
                radBtnDrink.Checked = true;
            }
            else if (menuItem.CourseType == FoodType.Starter)
            {
                radBtnStarter.Checked = true;
            }
            else
            {
                radBtnDessert.Checked = true;
            }

            if (menuItem.Vat == (float)0.09)
            {
                radBtnNonAlcoholic.Checked = true;
            }
            else
                radBtnAlcoholic.Checked = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToItemView();
        }
        private void ReturnToItemView()
        {
            this.Hide();
            MenuViewAllItems menuViewAllItems = new MenuViewAllItems();
            menuViewAllItems.ShowDialog();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //CHECKS FIRST IF ALL THE BTNS ARE CORRECTLY CHECKED 
            if (FieldsCorrect())
            {
                //Opens a message box for additional confirmation 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        updatedItem = new MenuItem();
                        CreateNewMenuItem();
                        menuItemService.UpdateItem(updatedItem);
                        MessageBox.Show("Menu item was successfully edited in the database", "Success!");
                        ReturnToItemView();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            else
            {
                //shows message that the fields are inccorect 
                MessageBox.Show("Fields not filled in correctly", "Error");
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
        private void CreateNewMenuItem()
        {
            updatedItem.MenuItemId = menuItem.MenuItemId;
            updatedItem.Name = txtBoxName.Text;
            updatedItem.Price = numPrice.Value;
            updatedItem.Description = txtBoxDescription.Text;

            if (radBtnDrink.Checked)
            {
                updatedItem.CourseType = FoodType.Drink;
            }
            else if (radBtnStarter.Checked)
            {
                updatedItem.CourseType = FoodType.Starter;
            }
            else if (radBtnMainDish.Checked)
            {
                updatedItem.CourseType = FoodType.MainCourse;
            }
            else
            {
                updatedItem.CourseType = FoodType.Dessert;
            }

            if (radBtnAlcoholic.Checked)
            {
                updatedItem.Vat = 2;
            }
            else
            {
                updatedItem.Vat = 1;
            }
        }
    }
}
