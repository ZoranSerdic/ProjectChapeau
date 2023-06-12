using ChapeauDAL;
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
        Order order = new Order();

        private MenuItemService menuItemService = new MenuItemService();
        private OrderItemService orderItemService = new OrderItemService();

        private List<MenuItem> currentMenuItems = new List<MenuItem>();

        private FoodType currentCourseType = FoodType.Starter;
        private MenuType currentMenuType = MenuType.Lunch;
        private MenuType otherMenuType = MenuType.Dinner;

        private string currentMenuLabel = "Starters";

        // TODO: Bianca's tableview gives Table tableID & Employee for Order order
        public OrderView(Table table, Employee employee)
        {
            string tableId = table.TableId.ToString();

            FillMenuItemList(FoodType.Starter, MenuType.Lunch);
            InitializeComponent();
            labelTableNumber.Text = $"Table {tableId}";
            DisplayItems(currentMenuItems);

            CreateOrder(table, employee);
        }

        private void FillMenuItemList(FoodType foodType, MenuType menuType)
        {
            currentMenuItems.Clear();

            try
            {
                currentMenuItems.AddRange(menuItemService.GetCourseMenuType(foodType, menuType));
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred.\n" + e.Message);
            }
        }

        // Displays items in listViewMenuItems
        private void DisplayItems(List<MenuItem> items)
        {
            // clear the listview items before filling it
            listViewMenuItems.Items.Clear();

            foreach (MenuItem item in items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Description);
                listViewItem.Tag = item.MenuItemId;

                listViewMenuItems.Items.Add(listViewItem);
            }
        }

        private void buttonCategoryStarters_Click(object sender, EventArgs e)
        {
            buttonSwitchMenu.Show();
            currentCourseType = FoodType.Starter;
            currentMenuLabel = "Starters";

            FillMenuItemList(currentCourseType, currentMenuType);
            DisplayItems(currentMenuItems);

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryMainDish_Click(object sender, EventArgs e)
        {
            buttonSwitchMenu.Show();
            currentCourseType = FoodType.MainCourse;
            currentMenuLabel = "Main Dish";

            FillMenuItemList(currentCourseType, currentMenuType);
            DisplayItems(currentMenuItems);

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDesserts_Click(object sender, EventArgs e)
        {
            buttonSwitchMenu.Show();
            currentCourseType = FoodType.Dessert;
            currentMenuLabel = "Desserts";

            FillMenuItemList(currentCourseType, currentMenuType);
            DisplayItems(currentMenuItems);

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void buttonCategoryDrinks_Click(object sender, EventArgs e)
        {
            buttonSwitchMenu.Hide();
            currentCourseType = FoodType.Drink;
            currentMenuLabel = "Drinks";

            FillMenuItemList(currentCourseType, MenuType.AllDay);
            DisplayItems(currentMenuItems);

            SwitchMenuLabel(currentMenuLabel, "Category");
        }

        private void buttonSwitchMenu_Click(object sender, EventArgs e)
        {
            SwitchMenuType();
        }

        private void buttonGoBackDrinksMenu_Click(object sender, EventArgs e)
        {
            currentMenuLabel = "Drinks";

            SwitchMenuLabel(currentMenuLabel, "Category");
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
            OrderFinalise orderFinalise = new OrderFinalise(order);
            DialogResult dialogResult = orderFinalise.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void SwitchMenuType()
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

            FillMenuItemList(currentCourseType, currentMenuType);
            DisplayItems(currentMenuItems);

            SwitchMenuLabel(currentMenuLabel, currentMenuType.ToString());
        }

        private void SwitchMenuLabel(string menuType, string menuTime)
        {
            switch (currentMenuType)
            {
                case MenuType.Lunch:
                    break;
                case MenuType.Dinner:
                    break;
                case MenuType.AllDay:
                    break;
                default:
                    break;
            }

            labelMenuType.Text = menuType;
            labelMenuTime.Text = menuTime;
        }

        // When ListViewMenuItems item is selected it will create the OrderPopup form
        private void listViewMenuItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listViewMenuItems.SelectedItems.Count == 1)
            {
                // Detach the event handler temporarily
                listViewMenuItems.ItemSelectionChanged -= listViewMenuItems_ItemSelectionChanged;

                // Retrieve information from item
                string name = e.Item.SubItems[0].Text;
                string description = e.Item.SubItems[1].Text;
                int menuId = (int)e.Item.Tag;

                //
                MenuItem menuItem = FindMenuItemById(currentMenuItems, menuId);

                // Create form
                OrderPopup orderPopup = new OrderPopup(name, description);
                DialogResult dialogResult = orderPopup.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    OrderItem orderItem = new OrderItem();

                    orderItem.OrderItemId = order.OrderId;
                    orderItem.MenuItem = menuItem;
                    orderItem.Comment = orderPopup.Comment;
                    orderItem.Amount = orderPopup.Amount;
                    orderItem.Status = OrderedItemStatus.Sent;
                    orderItem.PreparedAt = null;

                    // Add to list
                    order.OrderedItems.Add(orderItem);
                }

                // Reattach the event handler after the form is closed
                listViewMenuItems.ItemSelectionChanged += listViewMenuItems_ItemSelectionChanged;
            }
        }

        private MenuItem FindMenuItemById(List<MenuItem> items, int menuId) 
        {
            foreach (MenuItem item in currentMenuItems)
            {
                if (item.MenuItemId == menuId)
                {
                    return item;
                }
            }
            return null;
        }

        public void CreateOrder(Table table, Employee employee)
        {
            order.Table = table;
            order.Time = DateTime.Now;
            order.Employee = employee;
            order.IsPaid = false;
            order.OrderedItems = new List<OrderItem>();

            order.OrderId = 200;
            //order.OrderId = orderItemService.CreateOrder(order);
            //labelTableNumber.Text = $"Order {order.OrderId.ToString()}";
        }

        public void AddOrderItem(Order order)
        {
            foreach (OrderItem orderItem in order.OrderedItems)
            {
                orderItemService.AddOrderItem(orderItem);
            }
        }
    }
}
