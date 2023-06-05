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
using System.Xml.Linq;

namespace ChapeauUI
{
    public partial class OrderView : Form
    {
        const int DinnerMenuStart = 14;
        const int DinnerMenuEnd = 4;
        //const int ButtonWidth = 60;
        //const int ButtonHeight = 25;

        MenuItemService menuItemService = new MenuItemService();

        // TODO: separate into lunch and dinner menus
        List<MenuItem> starterItems = new List<MenuItem>();
        List<MenuItem> mainsItems = new List<MenuItem>();
        List<MenuItem> dessertsItems = new List<MenuItem>();
        List<MenuItem> drinksItems = new List<MenuItem>();

        MenuType currentMenuType;
        MenuType otherMenuType;

        bool HideDrinkMenu;

        string currentMenuLabel;

        public OrderView()
        {
            currentMenuLabel = "Starters";

            InitializeComponent();
            // Get Data

            // TODO: separate into lunch and dinner menus
            starterItems.AddRange(menuItemService.GetAllStarters());
            mainsItems.AddRange(menuItemService.GetAllMains());
            dessertsItems.AddRange(menuItemService.GetAllDesserts());
            drinksItems.AddRange(menuItemService.GetAllDrinks());

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

            // Starting Displays
            DisplayItems(starterItems);
        }

        // Fills MenuItem menuItems with the Starters

        private void DisplayItems(List<MenuItem> items)
        {
            // clear the listview before filling it
            listViewMenuItems.Items.Clear();

            foreach (MenuItem item in items) 
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Description);
                //listViewItem.Tag = item;

                //Button addButton = new Button();
                //addButton.Text = "Add";
                //addButton.AutoSize = true;
                //addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                //listViewItem.Tag = addButton;

                listViewMenuItems.Items.Add(listViewItem);
            }

            //listViewMenuItems.DrawItem += listViewMenuItems_DrawItem;
            //listViewMenuItems.MouseClick += listViewMenuItems_MouseClick;
        }

        //private void listViewMenuItems_DrawItem(object sender, DrawListViewItemEventArgs e)
        //{
        //    e.DrawDefault = true;

        //    //if (e.Item.Tag is Button addButton)
        //    //{
        //    //    addButton.Location = new Point(
        //    //        e.Bounds.Right - addButton.Width,
        //    //        e.Bounds.Top + (e.Bounds.Height - addButton.Height) / 2 
        //    //    );

        //    //    addButton.Parent = listViewMenuItems;
        //    //}

        //    int buttonX = e.Bounds.Right - ButtonWidth;
        //    int buttonY = e.Bounds.Top + (e.Bounds.Height - ButtonHeight) / 2;

        //    Button addButton = new Button();
        //    addButton.Text = "Add";
        //    addButton.Size = new Size(ButtonWidth, ButtonHeight);
        //    addButton.Location = new Point(buttonX, buttonY);

        //    addButton.Parent = listViewMenuItems;
        //    addButton.BackColor = SystemColors.Control;

        //    addButton.Click += (s, args) =>
        //    {
        //        ListViewItem listViewItem = listViewMenuItems.Items[e.Item.Index];
        //        Button_Click(listViewItem);
        //    };
        //}

        //private void listViewMenuItems_MouseClick(object sender, MouseEventArgs e) 
        //{ 
        //    ListView listView = (ListView)sender;
        //    ListViewItem item = listView.GetItemAt(e.X, e.Y);

        //    if (item != null && e.Button == MouseButtons.Left)
        //    {
        //        Rectangle bounds = item.GetBounds(ItemBoundsPortion.Entire);

        //        if (bounds.Contains(e.Location) && e.X > bounds.Width - 60)
        //        {
        //            Button_Click(item);
        //        }
        //    }
        //}

        //private void Button_Click(ListViewItem listViewItem)
        //{
        //    string name = listViewItem.Text;
        //    string description = listViewItem.SubItems[1].Text;
        //}
        #region CategoryButtons
        private void buttonCategoryStarters_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Starters";
            HideDrinkMenu = true;

            DisplayItems(starterItems);
            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryMainDish_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Main Dish";
            HideDrinkMenu = true;

            DisplayItems(mainsItems);
            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDesserts_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Desserts";
            HideDrinkMenu = true;

            DisplayItems(dessertsItems);
            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDrinks_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Drinks";

            buttonSwitchMenu.Hide();
            buttonGoBackDrinksMenu.Show();
            HideDrinkMenu = false;

            DisplayItems(drinksItems);
            SwitchMenuLabel("Drinks", "Category");
        }
        #endregion
        #region BottomButtons
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
        #endregion

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

        // When ListViewMenuItems is selected it will create the OrderPopup form
        private void listViewMenuItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listViewMenuItems.SelectedItems.Count == 1)
            {
                // Detach the event handler temporarily
                listViewMenuItems.ItemSelectionChanged -= listViewMenuItems_ItemSelectionChanged;

                // Retrieve information from item
                string name = e.Item.SubItems[0].Text;
                string description = e.Item.SubItems[1].Text;

                // Create form
                OrderPopup orderPopup = new OrderPopup(name, description);
                orderPopup.FormClosed += (s, ev) =>
                {
                    // Reattach the event handler after the form is closed
                    listViewMenuItems.ItemSelectionChanged += listViewMenuItems_ItemSelectionChanged;
                };
                orderPopup.ShowDialog();
            }
        }
    }
}
