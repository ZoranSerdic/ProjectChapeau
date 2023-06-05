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

namespace ChapeauUI
{
    public partial class OrderView : Form
    {
        const int DinnerMenuStart = 14;
        const int DinnerMenuEnd = 4;

        MenuType currentMenuType;
        MenuType otherMenuType;

        bool HideDrinkMenu;

        string currentMenuLabel;

        public OrderView()
        {
            InitializeComponent();

            currentMenuLabel = "Starters";

            // Automatically determine Menu Type based on time
            #region AutomaticTime
            DateTime dateTime = DateTime.Now;

            TimeSpan dinnerMenuStart = new TimeSpan(DinnerMenuStart, 0, 0);
            TimeSpan dinnerMenuEnd = new TimeSpan(DinnerMenuEnd, 0, 0);
            TimeSpan timeOfDay = dateTime.TimeOfDay;

            // Set default values
            currentMenuType = MenuType.Lunch;
            otherMenuType = MenuType.Dinner;

            if (timeOfDay >= dinnerMenuStart || timeOfDay <= dinnerMenuEnd)
            {
                SwitchMenuType();
            }
            #endregion
        }

        private void buttonCategoryStarters_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Starters";
            HideDrinkMenu = true;

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryMainDish_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Main Dish";
            HideDrinkMenu = true;

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDesserts_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Desserts";
            HideDrinkMenu = true;

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDrinks_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Drinks";

            buttonSwitchMenu.Hide();
            buttonGoBackDrinksMenu.Show();
            HideDrinkMenu = false;

            SwitchMenuLabel("Drinks", "Category");
        }

        private void buttonSwitchMenu_Click(object sender, EventArgs e)
        {
            SwitchMenuType();
        }

        private void buttonGoBackDrinksMenu_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Drinks";

            SwitchMenuLabel("Drinks", "Category");
        }

        private void buttonCloseOrder_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView();
            this.Hide();
            tableView.ShowDialog();
            this.Close();
        }

        private void buttonFinaliseOrder_Click(object sender, EventArgs e)
        {
            OrderFinalise orderFinalise = new OrderFinalise();
            this.Hide();
            orderFinalise.ShowDialog();
            this.Show();
        }

        void SwitchMenuType()
        {
            if (currentMenuType == MenuType.Lunch)
            {
                currentMenuType = MenuType.Dinner;
                otherMenuType = MenuType.Lunch;
            }
            else
            {
                currentMenuType = MenuType.Lunch;
                otherMenuType = MenuType.Dinner;
            }

            buttonSwitchMenu.Text = $"Switch To {otherMenuType.ToString()} Menu";
            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        void SwitchMenuLabel(string menuType, string menuTime)
        {
            if (HideDrinkMenu == true)
            {
                buttonSwitchMenu.Show();
                buttonGoBackDrinksMenu.Hide();
                HideDrinkMenu = false;
            }

            labelMenuType.Text = menuType;
            labelMenuTime.Text = menuTime;
        }
    }
}
