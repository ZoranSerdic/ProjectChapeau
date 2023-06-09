using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class MenuItemDAO : BaseDAO
    {
        public List<MenuItem> GetAllMenuItems()
        {
            //gathering all menu items from the table
            string query = "SELECT M.menuItemid,M.[Description], M.[menuType], M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId;";
            return ReadTables(ExecuteSelectQuery(query));
        }
        // if there are no paramenters, get rid of them 
        // only one method for Getting by Menu Type
        public List<MenuItem> GetAllDrinks()
        {
            //gathering all drinks from the table
            string query = "SELECT M.menuItemid,M.[Description], M.[menuType], M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Drink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllStarters()
        {
            //gathering all starters from the table
            string query = "SELECT M.menuItemid, M.[Description],M.[menuType], M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Starter';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllMainDishes()
        {
            //gathering all main courses from the table
            string query = "SELECT M.menuItemid, M.[Description], M.[menuType], M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'MainCourse';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllDesserts()
        {
            //gathering all desserts from the table
            string query = "SELECT M.menuItemid,M.[Description], M.[menuType], M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Dessert';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        #region OrderMethods
        public List<MenuItem> GetCourseMenuType(FoodType courseType, MenuType menuType)
        {
            //gather specific courseType and menuType from the table
            string query = $"SELECT M.menuItemid, M.[name], M.[Description], M.CourseType, M.[menuType] FROM menuitem AS M WHERE courseType = @courseType AND menuType = @menuType;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@courseType", courseType.ToString());
            sqlParameters[1] = new SqlParameter("@menuType", menuType.ToString());
            return ReadTableOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTableOrder(DataTable dataTable)
        {
            //this methods gets specific information from the menuItems in a list from the database 
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                try
                {
                    //gets the courseType firstly as a string (starter, main, dessert, drink)
                    string foodType = dr["courseType"].ToString();
                    string menuType = dr["menuType"].ToString();

                    //creates the new Item with all the information from the table
                    MenuItem item = new MenuItem()
                    {
                        //parsing the string into the enum 
                        CourseType = (FoodType)Enum.Parse(typeof(FoodType), foodType),
                        MenuType = (MenuType)Enum.Parse(typeof(MenuType), menuType),
                        MenuItemId = (int)dr["menuitemId"],
                        Name = dr["Name"].ToString(),
                        Description = dr["Description"].ToString(),
                    };
                    //adds the item to the list of all items 
                    items.Add(item);
                }
                catch (Exception exception)
                {
                    throw;
                }
            }
            //finally all items are returned in a list 
            return items;
        }
        #endregion

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            //this methods gets all the menuItems in a list from the database 
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                try
                {
                    //gets the courseType firstly as a string (starter, main, dessert, drink)
                    string foodType = dr["courseType"].ToString();
                    string menuType = dr["menuType"].ToString();

                    //creates the new Item with all the information from the table
                    MenuItem item = new MenuItem()
                    {
                        //parsing the string into the enum 
                        CourseType = (FoodType)Enum.Parse(typeof(FoodType), foodType),
                        MenuType = (MenuType)Enum.Parse(typeof(MenuType), menuType),
                        MenuItemId = (int)dr["menuitemId"],
                        Price = (decimal)dr["price"],
                        Name = dr["Name"].ToString(),
                        Description = dr["Description"].ToString(),
                        //converts first into double, then a float
                        Vat = (float)(double)dr["vat"],
                    };
                    //adds the item to the list of all items 
                    items.Add(item);
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message); 
                }
            }
            //finally all items are returned in a list 
            return items;
        }

        public void RemoveItem(MenuItem item)
        {
            string query = "DELETE FROM MenuItem WHERE MenuItemID = @ItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemID", item.MenuItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddItem(MenuItem item)
        {
            //this method adds the item into the menu Item table 
            string query = "INSERT INTO MenuItem(vatId, price, [name], CourseType,[Description], [menuType]) VALUES (@vat, @price, @name, @courseType, @description, @menuType);";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@vat", item.Vat);
            sqlParameters[1] = new SqlParameter("@price", item.Price);
            sqlParameters[2] = new SqlParameter("@name", item.Name.ToString());
            sqlParameters[3] = new SqlParameter("@courseType", item.CourseType.ToString());
            sqlParameters[4] = new SqlParameter("@description", item.Description.ToString());
            sqlParameters[5] = new SqlParameter("@menuType", item.MenuType.ToString());
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateItem(MenuItem item)
        {
            //this method updates existing items 
            string query = "UPDATE MenuItem SET [menuType] = @menuType, [Description] = @newDescription, courseType = @newcourseType, vatId = @newvat, [name] = @newname, [price] = @newprice WHERE menuItemid = @itemId;";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@newvat", item.Vat);
            sqlParameters[1] = new SqlParameter("@newprice", item.Price);
            sqlParameters[2] = new SqlParameter("@newname", item.Name);
            sqlParameters[3] = new SqlParameter("@newcourseType", item.CourseType.ToString());
            sqlParameters[4] = new SqlParameter("@itemId", item.MenuItemId);
            sqlParameters[5] = new SqlParameter("@newDescription", item.Description.ToString());
            sqlParameters[6] = new SqlParameter("@menuType", item.MenuType.ToString());
            ExecuteEditQuery(query, sqlParameters);
        }

        public MenuItem GetMenuItemById(int menuItemId)
        {
            string query = @"SELECT M.menuItemId, M.[name], M.[price], V.vat, M.courseType, M.menuType, M.description
                                FROM menuItem AS M JOIN Vat AS V on M.vatId = V.vatId
                                WHERE menuItemId = @MenuItemId"; 
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MenuItemId", menuItemId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0) // check if there are any rows returned, then reads the menu item
            {
                DataRow dataRow = dataTable.Rows[0];
                MenuItem menuItem = ReadMenuItem(dataRow);
                return menuItem;
            }
            throw new Exception($"Menu item with the {menuItemId} id was not found!");
    }

        private MenuItem ReadMenuItem(DataRow dataRow)
        {
            MenuItem menuItem = new MenuItem()
            {
                MenuItemId = (int)dataRow["menuItemId"],
                Name = (string)dataRow["name"],
                Description = dataRow["description"] == DBNull.Value ? string.Empty : (string)dataRow["description"], // if there's no description in the database, then makes it am empty string in nenuItem
                Price = (decimal)dataRow["price"],
                Vat = (float)(double)(dataRow)["vat"],
                CourseType = (FoodType)Enum.Parse(typeof(FoodType), dataRow["courseType"].ToString(), ignoreCase: true),
                MenuType = dataRow["menuType"] == DBNull.Value ? MenuType.AllDay : (MenuType)Enum.Parse(typeof(MenuType), dataRow["menuType"].ToString(), ignoreCase: true) // sets by default menuType to All Day
            };
            return menuItem;
        }
    }
}
