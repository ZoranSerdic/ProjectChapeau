using ChapeauModel;
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
            //gathering all employees from the table
            string query = "SELECT M.menuItemid, M.[name], M.[price], V.vat, M.CourseType FROM menuitem AS M JOIN Vat AS V on M.vatId = V.vatId;";
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
    }
}
