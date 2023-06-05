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

        public OrderView()
        {
            InitializeComponent();

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
            labelMenuTime.Text = currentMenuType.ToString();
        }

        private void buttonCategoryStarters_Click(object sender, EventArgs e)
        {

        }

        private void buttonCategoryMainDish_Click(object sender, EventArgs e)
        {

        }

        private void buttonCategoryDesserts_Click(object sender, EventArgs e)
        {

        }

        private void buttonCategoryDrinks_Click(object sender, EventArgs e)
        {

        }

        private void buttonSwitchMenu_Click(object sender, EventArgs e)
        {
            SwitchMenuType();
        }

        private void buttonCloseOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonFinaliseOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
