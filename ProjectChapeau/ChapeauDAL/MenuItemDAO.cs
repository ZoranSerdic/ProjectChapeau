﻿using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class MenuItemDAO : BaseDAO
    {
        
        public List<MenuItem> GetAllMenuItems()
        {
            //gathering all menu items from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllDrinks()
        {
            //gathering all drinks from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Drink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllStarters()
        {
            //gathering all starters from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Starter';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllMainDishes()
        {
            //gathering all main courses from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'MainCourse';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllDesserts()
        {
            //gathering all desserts from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId WHERE courseType = 'Dessert';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            //this methods gets all the menuItems in a list from the database 
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //gets the courseType firstly as a string (starter, main, dessert, drink)
                string foodType = dr["courseType"].ToString();

                //creates the new Item with all the information from the table
                MenuItem item = new MenuItem()
                {
                    CourseType = (FoodType)Enum.Parse(typeof(FoodType), foodType),
                    MenuItemId = (int)dr["menuitemId"],
                    Price = (decimal)dr["price"],
                    Name = dr["Name"].ToString(),
                    //converts first into double, then a float
                    Vat = (float)(double)dr["vat"],
                };
                //adds the item to the list of all items 
                items.Add(item);
            }
            //finally all items are returned in a list 
            return items;
        }

        public void RemoveItem(MenuItem item)
        {
            string query = "DELETE FROM MenuItem WHERE MenuItemID = @ItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[1] = new SqlParameter("@ItemID", item.MenuItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddItem(MenuItem item)
        {
            //this method adds the item into the menu Item table 
            string query = "INSERT INTO MenuItem(vatId, price, [name], CourseType) VALUES (@vat, @price, '@name','@courseType');";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@vat", item.Vat);
            sqlParameters[1] = new SqlParameter("@price", item.Price);
            sqlParameters[2] = new SqlParameter("@name", item.Name);
            sqlParameters[3] = new SqlParameter("@courseType", item.CourseType);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
