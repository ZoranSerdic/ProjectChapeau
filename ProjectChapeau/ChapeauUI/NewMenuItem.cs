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
        //employee needed for the login 
        Employee employee;
        const int NonAcloholicId = 1;
        const int AlcoholicID = 2;
        MenuItemService menuItemService;
        MenuItem itemToBeUpdated;

        int idToBeUpdated;
        //either going to add or update the item 
        bool update;

        public NewMenuItem(Employee employee)
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            this.employee = employee;
        }
        public NewMenuItem(MenuItem item, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            menuItemService = new MenuItemService();
            update = true;
            idToBeUpdated = item.MenuItemId;
            itemToBeUpdated = item;
            FillForm();
        }
        // METHODS FOR PREFILLING THE FORM 
        private void FillForm()
        {
            txtBoxName.Text = itemToBeUpdated.Name;
            numPrice.Value = itemToBeUpdated.Price;
            txtBoxDescription.Text = itemToBeUpdated.Description;
            FillRadButtons();
        }

        //METHODS FOR PRESELECTION/FILLING THE FORM - EASE OF USE 
        private void FillRadButtons()
        {
            //preselects the correct radiobuttons for the user 
            SelectMenuType();
            SelectCourseType();
            SelectVat();
        }
        private void SelectMenuType()
        {
            if (itemToBeUpdated.MenuType == MenuType.Dinner)
            {
                radBtnDinner.Checked = true;
            }
            else if (itemToBeUpdated.MenuType == MenuType.Lunch)
            {
                radBtnLunch.Checked = true;
            }
            else
            {
                radBtnAllDay.Checked = true;
            }
        }
        private void SelectCourseType()
        {
            if (itemToBeUpdated.CourseType == FoodType.MainCourse)
            {
                radBtnMainDish.Checked = true;
            }
            else if (itemToBeUpdated.CourseType == FoodType.Drink)
            {
                radBtnDrink.Checked = true;
            }
            else if (itemToBeUpdated.CourseType == FoodType.Starter)
            {
                radBtnStarter.Checked = true;
            }
            else
            {
                radBtnDessert.Checked = true;
            }
        }
        private void SelectVat()
        {
            //checks if the vat is non-alacoholic 
            if (itemToBeUpdated.Vat == (float)0.09)
            {
                radBtnNonAlcoholic.Checked = true;
            }
            else
                radBtnAlcoholic.Checked = true;
        }


        //METHODS FOR ADDING-UPDATING A MENU ITEM 
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (FieldsCorrect())
            {
                //Opens a message box for additional confirmation 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation needed", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK) //confirmation by the user 
                {
                    try
                    {
                        //creates the new menu item 
                        CreateNewMenuItem();

                        if (update)
                        {
                            menuItemService.UpdateItem(this.itemToBeUpdated);
                        }
                        else
                        {
                            menuItemService.AddItem(this.itemToBeUpdated);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        ReturnToMenu();
                    }
                    //MessageBox.Show("Action was performed successfuly", "Success!");
                    ReturnToMenu();
                }
            }
            else
            {
                //shows message that the fields are inccorect 
                MessageBox.Show("Fields not filled in correctly", "Error");
            }

        }
        //METHODS FOR CHECKING THE FORM
        private bool FieldsCorrect()
        {
            if (CheckNameAndPrice() && CheckCourseType() && CheckVat() && CheckMenuType())
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
            //checks that at least one button is selected
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


        //METHODS FOR CREATING THE NEW ITEM 
        private void CreateNewMenuItem()
        {
            this.itemToBeUpdated = new MenuItem();
            if (update)
            {
                //gets the ID from the Item which was in the constructor 
                itemToBeUpdated.MenuItemId = idToBeUpdated;
            }
            //all the other information is added 
            itemToBeUpdated.Name = txtBoxName.Text;
            itemToBeUpdated.Price = numPrice.Value;
            itemToBeUpdated.Description = txtBoxDescription.Text;

            //separate methods for menu, course and vat (keep the code clear)
            SetMenuType();
            SetCourseType();
            SetVat();
        }
        private void SetMenuType()
        {
            //sets the correct menu type for the new item 
            if (radBtnAllDay.Checked)
            {
                itemToBeUpdated.MenuType = MenuType.AllDay;
            }
            else if (radBtnDinner.Checked)
            {
                itemToBeUpdated.MenuType = MenuType.Dinner;
            }
            else { itemToBeUpdated.MenuType = MenuType.Lunch; }
        }
        private void SetCourseType()
        {
            //sets the correct food type for the new item 
            if (radBtnDrink.Checked)
            {
                itemToBeUpdated.CourseType = FoodType.Drink;
            }
            else if (radBtnStarter.Checked)
            {
                itemToBeUpdated.CourseType = FoodType.Starter;
            }
            else if (radBtnMainDish.Checked)
            {
                itemToBeUpdated.CourseType = FoodType.MainCourse;
            }
            else
            {
                itemToBeUpdated.CourseType = FoodType.Dessert;
            }
        }
        private void SetVat()
        {
            //sets the correct vatID type for the new item according to the database 
            if (radBtnAlcoholic.Checked)
            {
                itemToBeUpdated.Vat = AlcoholicID;
            }
            else
            {
                itemToBeUpdated.Vat = NonAcloholicId;
            }
        }


        //RETURN METHODS  
        private void ReturnToMenu()
        {
            this.Hide();
            MenuViewAllItems menuOverviewView = new MenuViewAllItems(this.employee);
            menuOverviewView.ShowDialog();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }

    }
}
