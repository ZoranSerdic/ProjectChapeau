using ChapeauModel;
using ChapeauService;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauUI
{
    // change MenuItem ReadMenuItem(DataRow dataRow)
    

    // code inside constructor?, error handling
    // add code for logged-in user
    // logging out
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

            loggedInEmployee.Occupation = Role.Chef; // delete this later
            //this.loggedInEmployee = loggedInEmployee;

            DisplayUnpreparedOrders(); // in the main screen the open orders are displayed
            timerRefreshDisplay.Start();
        }

        private void DisplayUnpreparedOrders() // depending on the logged in user the orders are shown : bar or kitchen
        {
            try
            {
                if (loggedInEmployee.Occupation == Role.Barman)
                    DisplayUnpreparedDrinks();
                else if (loggedInEmployee.Occupation == Role.Chef)
                    DisplayUnpreparedFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying orders: " + ex.Message);
            }
        }

        private void DisplayUnpreparedDrinks()
        {
            listViewOrders.Items.Clear();
            List<Order> drinks = orderService.GetUnpreparedOrdersByType(FoodType.Drink);

            foreach (Order order in drinks)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    DisplayUnpreparedItem(order, orderItem);
                }
            }
        }

        private void DisplayUnpreparedFood()
        {
            listViewOrders.Items.Clear();

            List<Order> starters = orderService.GetUnpreparedOrdersByType(FoodType.Starter);
            List<Order> mains = orderService.GetUnpreparedOrdersByType(FoodType.MainCourse);
            List<Order> desserts = orderService.GetUnpreparedOrdersByType(FoodType.Dessert);

            List<ListViewGroup> headers = CreateHeadersForKitchen(); // creates groups and headers for kitchen view: "starters" , "main courses" and "desserts"

            foreach (Order order in starters) // firstly displays all the starters
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[0]; // assigns the item to the first group (starters)
                }
            }

            foreach (Order order in mains) // main courses
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[1]; // assigns the item to the group main courses
                }
            }

            foreach (Order order in desserts)
            {
                foreach (OrderItem orderItem in order.OrderedItems)
                {
                    ListViewItem item = DisplayUnpreparedItem(order, orderItem);
                    item.Group = headers[2]; // assigns the item to the group desserts
                }
            }
        }

        private List<ListViewGroup> CreateHeadersForKitchen()
        {
            // create 3 groups 
            List<ListViewGroup> headers = new List<ListViewGroup>();

            ListViewGroup startersGroup = new ListViewGroup("Starters");
            ListViewGroup mainsGroup = new ListViewGroup("Mains");
            ListViewGroup dessertsGroup = new ListViewGroup("Desserts");

            // add the groups to the ListView
            listViewOrders.Groups.Add(startersGroup);
            listViewOrders.Groups.Add(mainsGroup);
            listViewOrders.Groups.Add(dessertsGroup);

            // create 3 headers
            startersGroup.Header = "Starters";
            startersGroup.HeaderAlignment = HorizontalAlignment.Center;

            mainsGroup.Header = "Mains";
            mainsGroup.HeaderAlignment = HorizontalAlignment.Center;

            dessertsGroup.Header = "Desserts";
            dessertsGroup.HeaderAlignment = HorizontalAlignment.Center;

            // add headers to the list
            headers.Add(startersGroup);
            headers.Add(mainsGroup);
            headers.Add(dessertsGroup);

            // makes headers in ListView not selectable
            listViewOrders.MouseDown += (sender, e) =>
            {
                ListViewItem clickedItem = listViewOrders.GetItemAt(e.X, e.Y);//retrieves the ListViewItem that corresponds to the coordinates of the mouse click
                if (clickedItem != null && clickedItem.Group != null) //checks if the clicked item is not null and belongs to a group
                {
                    clickedItem.Selected = false; //deselect the clicked item
                }
            };

            return headers;
        }

        private ListViewItem DisplayUnpreparedItem(Order order, OrderItem orderItem) // used for both bar and kitchen views
        {
            ListViewItem item = new ListViewItem(order.Table.TableId.ToString()); // 1st column - table number 
            item.SubItems.Add(orderItem.Amount.ToString()); // 2nd column = number of ordered items

            // 3rd column - the nemu item name and description and if the comment is not empty - also adds it to this row
            item.SubItems.Add(string.IsNullOrEmpty(orderItem.Comment) 
                  ? $"{orderItem.MenuItem.Name} {orderItem.MenuItem.Description}"
                  : $"{orderItem.MenuItem.Name} {orderItem.MenuItem.Description}: {orderItem.Comment.ToLower()}");

            item.SubItems.Add(order.Time.ToString("HH:mm")); // 4th column - time when it was received
            item.SubItems.Add((DateTime.Now - order.Time).ToString(@"hh\:mm")); // low long the order item has been open
            item.SubItems.Add(orderItem.Status.ToString()); // status of the order item

            item.Tag = orderItem;
            listViewOrders.Items.Add(item);

            // Create a new ToolTip for the itemName
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(listViewOrders, item.SubItems[2].Text); // if the name + description and comment are too long then the whole text appears when you hover it

            return item; // the method returns the item object because i need to assign items in the kitchen view to groups depending on the type of the dish
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
            try
            {
                OrderItem orderItem = (OrderItem)listViewOrders.SelectedItems[0].Tag; // gets the selected item 
                orderItem.Status = OrderedItemStatus.Preparing; // changes the status 

                orderItemService.UpdateOrderItemStatus(orderItem); // updates the status in the database

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while starting the order preparation: "+ ex.Message);
            }
            finally
            {
                buttonStart.Hide();
                DisplayUnpreparedOrders(); // refreshes the list view
            }        
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            try
            {
                OrderItem orderItem = (OrderItem)listViewOrders.SelectedItems[0].Tag;
                orderItem.Status = OrderedItemStatus.Ready; // changes the status to "ready" 
                orderItem.PreparedAt = DateTime.Now; // and sets the time when it was prepared to the current time

                orderItemService.UpdateOrderItemStatus(orderItem); // updates status in the database
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while finishing the order: " + ex.Message);
            }
            finally
            {
                buttonReady.Hide();
                DisplayUnpreparedOrders();// refreshes the list view
            }
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

        private void DisplayPreparedOrders() // depending on the logged-in user
        {
            try
            {
                if (loggedInEmployee.Occupation == Role.Barman)
                    DisplayDrinksHistory();
                else if (loggedInEmployee.Occupation == Role.Chef)
                    DisplayFoodHistory();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while displaying order history: " + ex.Message);
            }         
        }

        private void DisplayDrinksHistory()
        {
            List<Order> drinks = orderService.GetReadyDrinks(); // gets frinks

            DisplayOrdersHistory(drinks);
        }

        private void DisplayFoodHistory()
        {
            List<Order> food = orderService.GetReadyFood(); // gets food

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

        private ListViewItem DisplayPreparedItem(Order order, OrderItem orderItem)
        {
            ListViewItem item = new ListViewItem(order.Table.TableId.ToString()); // table id
            item.SubItems.Add(orderItem.Amount.ToString()); // amount

            item.SubItems.Add(string.IsNullOrEmpty(orderItem.Comment) // name, description and comment if it's not empty)
                   ? $"{orderItem.MenuItem.Name} {orderItem.MenuItem.Description}"
                   : $"{orderItem.MenuItem.Name} {orderItem.MenuItem.Description}: {orderItem.Comment.ToLower()}");

            item.SubItems.Add(order.Time.ToString("HH:mm")); // time when it was received

            if (orderItem.PreparedAt != null)
                item.SubItems.Add(orderItem.PreparedAt.Value.ToString("HH:mm")); // time when it was prepared

            item.Tag = orderItem;
            listViewHistory.Items.Add(item);

            // create a new ToolTip for the itemName
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(listViewHistory, item.SubItems[2].Text);

            return item;
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

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            try
            {
                // add code for logging out the user
                LoginView loginView = new LoginView();
                Hide();
                loginView.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error occurred while logging out: " + ex.Message);
            }
        }

        private void timerRefreshDisplay_Tick(object sender, EventArgs e)
        {
            buttonStart.Hide();
            buttonReady.Hide();
            if (listViewHistory.Visible)
            {
                DisplayPreparedOrders();
            }
            else if (listViewOrders.Visible)
                DisplayUnpreparedOrders();
        }
    }
}
