using ChapeauModel;
using ChapeauService;
//using System.Timers;
//using System.Windows.Forms;

namespace ChapeauUI
{
    // show comments completely
    // change colors?
    // change design in figma

    // error handeling
    public partial class BarKitchenView : Form
    {
        private OrderService orderService;
        private Employee loggedInEmployee;
        private OrderItemService orderItemService;
        public BarKitchenView() // Employee loggedInEmployee
        {
            InitializeComponent();

            //? do i need this
            buttonHistory.Show();
            buttonRefresh.Show();
            buttonLogOut.Show();
            listViewOrders.Show();
            labelOrders.Show();

            buttonReady.Hide();
            buttonStart.Hide();
            buttonOrders.Hide();
            listViewHistory.Hide();
            labelHistory.Hide();

            orderService = new OrderService();
            loggedInEmployee = new Employee();
            orderItemService = new OrderItemService();

            loggedInEmployee.Occupation = Role.Chef; // потім це видалити
            //this.loggedInEmployee = loggedInEmployee;
            DisplayUnpreparedOrders();
        }

        private void DisplayUnpreparedOrders()
        {
            if (loggedInEmployee.Occupation == Role.Barman)
                DisplayUnpreparedDrinks();
            else if (loggedInEmployee.Occupation == Role.Chef)
                DisplayUnpreparedFood();
        }

        private ListViewItem DisplayUnpreparedItem(Order order, OrderItem orderItem)
        {
            ListViewItem item = new ListViewItem(order.Table.TableId.ToString());
            item.SubItems.Add(orderItem.Amount.ToString());

            /*if (string.IsNullOrEmpty(orderedItem.Comment))
               item.SubItems.Add(orderedItem.MenuItem.Name);
              else
                 item.SubItems.Add(orderedItem.MenuItem.Name + orderedItem.Comment);*/
            item.SubItems.Add(string.IsNullOrEmpty(orderItem.Comment)
            ? orderItem.MenuItem.Name
            : orderItem.MenuItem.Name + ": " + orderItem.Comment.ToLower()); // rewrite the formatting?

            item.SubItems.Add(order.Time.ToString("HH:mm"));
            item.SubItems.Add((DateTime.Now - order.Time).ToString(@"hh\:mm"));
            item.SubItems.Add(orderItem.Status.ToString());

            item.Tag = orderItem;
            listViewOrders.Items.Add(item);

            return item;
        }

        private void DisplayUnpreparedDrinks()
        {
            listViewOrders.Items.Clear();
            List<Order> drinks = orderService.GetUnpreparedOrdersByFoodType(FoodType.Drink);

            foreach (Order order in drinks)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    DisplayUnpreparedItem(order, orderItem);
                }
            }
        }

        private List<ListViewGroup> CreateHeadersForKitchen()
        {
            List<ListViewGroup> headers = new List<ListViewGroup>();

            ListViewGroup startersGroup = new ListViewGroup("Starters");
            ListViewGroup mainsGroup = new ListViewGroup("Mains");
            ListViewGroup dessertsGroup = new ListViewGroup("Desserts");

            // Add the group headers to the ListView
            listViewOrders.Groups.Add(startersGroup);
            listViewOrders.Groups.Add(mainsGroup);
            listViewOrders.Groups.Add(dessertsGroup);

            startersGroup.Header = "Starters";
            startersGroup.HeaderAlignment = HorizontalAlignment.Center;

            mainsGroup.Header = "Mains";
            mainsGroup.HeaderAlignment = HorizontalAlignment.Center;

            dessertsGroup.Header = "Desserts";
            dessertsGroup.HeaderAlignment = HorizontalAlignment.Center;

            headers.Add(startersGroup);
            headers.Add(mainsGroup);
            headers.Add(dessertsGroup);

            return headers;

        }

        private void DisplayUnpreparedFood()
        {
            listViewOrders.Items.Clear();

            List<Order> starters = orderService.GetUnpreparedOrdersByFoodType(FoodType.Starter);
            List<Order> mains = orderService.GetUnpreparedOrdersByFoodType(FoodType.MainCourse);
            List<Order> desserts = orderService.GetUnpreparedOrdersByFoodType(FoodType.Dessert);

            List<ListViewGroup> headers = CreateHeadersForKitchen();

            foreach (Order order in starters)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[0];
                }
            }

            foreach (Order order in mains)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[1];
                }
            }

            foreach (Order order in desserts)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[2];
                }
            }

            listViewOrders.MouseDown += (sender, e) => // makes headers in ListView not selectable
            {
                ListViewItem clickedItem = listViewOrders.GetItemAt(e.X, e.Y);//retrieves the ListViewItem that corresponds to the coordinates of the mouse click
                if (clickedItem != null && clickedItem.Group != null) //checks if the clicked item is not null and belongs to a group
                {
                    clickedItem.Selected = false; //deselect the clicked item
                }
            };
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0) // checks if there is at least one selected item before doing the next step
            {
                OrderItem orderItem = (OrderItem)listViewOrders.SelectedItems[0].Tag;
                switch (orderItem.Status)
                {
                    case OrderedItemStatus.Sent:
                        buttonReady.Hide();
                        buttonStart.Show();
                        break;
                    case OrderedItemStatus.Preparing:
                        buttonStart.Hide();
                        buttonReady.Show();
                        break;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = (OrderItem)listViewOrders.SelectedItems[0].Tag;
            orderItem.Status = OrderedItemStatus.Preparing;
            buttonStart.Hide();
            orderItemService.UpdateOrderItemStatus(orderItem);

            DisplayUnpreparedOrders();
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = (OrderItem)listViewOrders.SelectedItems[0].Tag;
            orderItem.Status = OrderedItemStatus.Ready;
            orderItem.PreparedAt = DateTime.Now;

            buttonReady.Hide();
            orderItemService.UpdateOrderItemStatus(orderItem);
            // сказати Зорану щоб він робив перевірку на статус усіх айтемс одного типу на заказ 

            DisplayUnpreparedOrders();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            listViewOrders.Hide();
            buttonHistory.Hide();
            labelOrders.Hide();

            buttonStart.Hide();
            buttonReady.Hide();

            labelHistory.Show();
            listViewHistory.Show();
            buttonOrders.Show();

            DisplayPreparedOrders();
        }

        private void DisplayPreparedOrders()
        {
            if (loggedInEmployee.Occupation == Role.Barman)
                DisplayDrinksHistory();
            else if (loggedInEmployee.Occupation == Role.Chef)
                DisplayFoodHistory();
        }

        private ListViewItem DisplayPreparedItem(Order order, OrderItem orderItem)
        {

            ListViewItem item = new ListViewItem(order.Table.TableId.ToString());
            item.SubItems.Add(orderItem.Amount.ToString());
            /*if (string.IsNullOrEmpty(orderedItem.Comment))
               item.SubItems.Add(orderedItem.MenuItem.Name);
              else
                 item.SubItems.Add(orderedItem.MenuItem.Name + orderedItem.Comment);*/
            item.SubItems.Add(string.IsNullOrEmpty(orderItem.Comment)
            ? orderItem.MenuItem.Name
            : orderItem.MenuItem.Name + ": " + orderItem.Comment.ToLower()); // rewrite the formatting

            item.SubItems.Add(order.Time.ToString("HH:mm"));
            item.SubItems.Add((orderItem.PreparedAt - order.Time)?.ToString(@"hh\:mm") ?? ""); // ? checks is it's null, if so it converts an empty string
            item.SubItems.Add(orderItem.PreparedAt?.ToString("HH:mm") ?? "");

            item.Tag = orderItem;
            listViewHistory.Items.Add(item);

            return item;
        }

        private void DisplayDrinksHistory()
        {
            List<Order> drinks = orderService.GetReadyDrinks();

            DisplayOrdersHistory(drinks);
        }

        private void DisplayFoodHistory()
        {
            List<Order> food = orderService.GetReadyFood();

            DisplayOrdersHistory(food);
        }

        private void DisplayOrdersHistory(List<Order> orders)
        {
            listViewHistory.Items.Clear();

            foreach (Order order in orders)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    DisplayPreparedItem(order, orderItem);
                }
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            buttonOrders.Hide();
            listViewHistory.Hide();
            labelHistory.Hide();

            buttonStart.Hide();
            buttonReady.Hide();

            buttonHistory.Show();
            labelOrders.Show();
            listViewOrders.Show();

            DisplayUnpreparedOrders();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (listViewHistory.Visible)
            {
                DisplayPreparedOrders();
            }
            else if (listViewOrders.Visible)
                DisplayUnpreparedOrders();
        }

        //later
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            // later
        }
    }
}
