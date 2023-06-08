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
        MenuItem newItem;
        int idToBeUpdated;
        private bool update;
        public NewMenuItem()
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
        }
        public NewMenuItem(MenuItem item)
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            update = true;
            idToBeUpdated = item.MenuItemId;
            newItem = item; 
            FillForm();
        }
        // METHODS FOR PREFILLING THE FORM 
        private void FillForm()
        {
            txtBoxName.Text = newItem.Name;
            numPrice.Value = newItem.Price;
            txtBoxDescription.Text = newItem.Description;
            FillRadButtons();
        }
        private void FillRadButtons()
        {
            //preselects the correct radiobuttons for the user 
            FillMenuTypeButtons();
            FillCourseTypeButtons();
            FillVatButtons();
        }
        private void FillMenuTypeButtons()
        {
            if (newItem.MenuType == MenuType.Dinner)
            {
                radBtnDinner.Checked = true;
            }
            else if (newItem.MenuType == MenuType.Lunch)
            {
                radBtnLunch.Checked = true;
            }
            else
            {
                radBtnAllDay.Checked = true;
            }
        }
        private void FillCourseTypeButtons()
        {
            if (newItem.CourseType == FoodType.MainCourse)
            {
                radBtnMainDish.Checked = true;
            }
            else if (newItem.CourseType == FoodType.Drink)
            {
                radBtnDrink.Checked = true;
            }
            else if (newItem.CourseType == FoodType.Starter)
            {
                radBtnStarter.Checked = true;
            }
            else
            {
                radBtnDessert.Checked = true;
            }
        }
        private void FillVatButtons()
        {
            if (newItem.Vat == (float)0.09)
            {
                radBtnNonAlcoholic.Checked = true;
            }
            else
                radBtnAlcoholic.Checked = true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (FieldsCorrect())
            {
                //Opens a message box for additional confirmation 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    //code for if the second confirmation occurs 
                    this.newItem = new MenuItem();
                    try
                    {
                        CreateNewMenuItem();
                        if (update)
                        {
                            menuItemService.UpdateItem(this.newItem);
                        }
                        else
                        {
                            menuItemService.AddItem(this.newItem);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        ReturnToMenu();
                    }
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
            if (CheckNamePriceDescription() && CheckCourseType() && CheckVat() && CheckMenuType())
            {
                return true;
            }
            return false;
        }
        private bool CheckNamePriceDescription()
        {
            //returns true if name and price are not empty 
            if (txtBoxName.Text != "" && numPrice != null && txtBoxDescription.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool CheckMenuType()
        {
            if (radBtnAllDay.Checked || radBtnDinner.Checked || radBtnLunch.Checked)
            {
                return true;
            }
            return false;
        }
        private bool CheckCourseType()
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
            this.Hide();
            MenuViewAllItems menuOverviewView = new MenuViewAllItems();
            menuOverviewView.ShowDialog();
            this.Close();
        }

        private void CreateNewMenuItem()
        {
            this.newItem = new MenuItem();
            if (update)
            {
                newItem.MenuItemId = idToBeUpdated; 
            }
            newItem.Name = txtBoxName.Text;
            newItem.Price = numPrice.Value;
            newItem.Description = txtBoxDescription.Text;

            SetMenuType();
            SetCourseType();
            SetVat();
        }
        private void SetMenuType()
        {
            if (radBtnAllDay.Checked)
            {
                newItem.MenuType = MenuType.AllDay;
            }
            else if (radBtnDinner.Checked)
            {
                newItem.MenuType = MenuType.Dinner;
            }
            else { newItem.MenuType = MenuType.Lunch; }
        }
        private void SetCourseType()
        {
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
        }
        private void SetVat()
        {
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
