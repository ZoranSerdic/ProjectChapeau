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
        private Order order = new Order();

        private OrderItemService orderItemService = new OrderItemService();
        private InventoryItemService inventoryItemService = new InventoryItemService();

        private List<MenuItem> currentMenuItems = new List<MenuItem>();
        private List<InventoryItem> currentInventoryItems = new List<InventoryItem>();

        private FoodType currentCourseType = FoodType.Starter;
        private MenuType currentMenuType = MenuType.Lunch;
        private MenuType otherMenuType = MenuType.Dinner;

        private string currentMenuLabel = "Starters";

        public OrderView(Table table, Employee employee)
        {
            CreateOrder(table, employee);
            string tableId = table.TableId.ToString();

            FillMenuItemList(FoodType.Starter, MenuType.Lunch);
            InitializeComponent();
            labelTableNumber.Text = $"Table {tableId}";
            DisplayItems(currentMenuItems);
        }

        private void FillMenuItemList(FoodType foodType, MenuType menuType)
        {
            MenuItemService menuItemService = new MenuItemService();

            currentMenuItems.Clear();
            currentInventoryItems.Clear();

            try
            { 
                currentMenuItems.AddRange(menuItemService.GetCourseMenuType(foodType, menuType));
                currentInventoryItems.AddRange(inventoryItemService.GetInventoryItems());
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

                // Find the corresponding InventoryItem for the current MenuItem
                InventoryItem inventoryItem = FindInventorytemById(currentInventoryItems, item.MenuItemId);

                // Set the text colour based on the inStock value
                if (inventoryItem != null)
                {
                    if (inventoryItem.InStock > 0)
                    {
                        listViewItem.ForeColor = Color.Black;
                    }
                    else
                    {
                        listViewItem.ForeColor = Color.Red;
                    }
                }
                else
                {
                    // InventoryItem not found, default text colour
                    listViewMenuItems.ForeColor = Color.Turquoise;
                }

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

            SwitchMenuLabel(currentMenuLabel, "All Day");
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
            this.Close();
        }

        private void buttonFinaliseOrder_Click(object sender, EventArgs e)
        {
            OrderFinalise orderFinalise = new OrderFinalise(order);
            DialogResult dialogResult = orderFinalise.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                order = orderFinalise.Order;
                AddOrderItem(order);
                // call method to reduce stock amount
                this.Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                order = orderFinalise.Order;
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
            labelMenuType.Text = menuType;
            labelMenuTime.Text = menuTime;
        }

        // When ListViewMenuItems item is selected it will create the OrderPopup form
        private void listViewMenuItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listViewMenuItems.SelectedItems.Count == 1)
            {
                if (e.Item.ForeColor == Color.Red)
                {
                    MessageBox.Show("This item is out of stock.", "Out of Stock");
                }
                else
                {
                    // Detach the event handler temporarily
                    listViewMenuItems.ItemSelectionChanged -= listViewMenuItems_ItemSelectionChanged;

                    // Retrieve information from item
                    string name = e.Item.SubItems[0].Text;
                    string description = e.Item.SubItems[1].Text;
                    int menuId = (int)e.Item.Tag;

                    // Set menuItem
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
        }

        private MenuItem FindMenuItemById(List<MenuItem> menuItems, int menuId)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.MenuItemId == menuId)
                {
                    return item;
                }
            }

            return null;
        }

        private InventoryItem FindInventorytemById(List<InventoryItem> inventoryItems, int menuItemId) 
        {
            foreach (InventoryItem item in inventoryItems)
            {
                if (item.MenuItemID == menuItemId)
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

            // Creates order in the database and gets id
            order.OrderId = orderItemService.CreateOrder(order);
        }

        // Add Orders to database & Calls method ReduceStockQuery
        public void AddOrderItem(Order order)
        {
            foreach (OrderItem orderItem in order.OrderedItems)
            {
                orderItemService.AddOrderItem(orderItem);
                ReduceStockQuery(orderItem.MenuItem.MenuItemId, orderItem.Amount);
            }
        }

        // Reduce Stock Amount
        public void ReduceStockQuery(int menuItemId, int amount)
        {
            inventoryItemService.DecreaseInventoryItemStock(menuItemId, amount);
        }
    }
}
