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
    public class InventoryItemdDAO : BaseDAO
    {
        public List<InventoryItem> GetAllInventoryItems()
        {
            //gathering all inventory items from the table
            string query = "SELECT I.inStock, I.inventoryItemId, M.[name] FROM InventoryItem AS I JOIN MenuItem AS M ON I.MenuItemKey = menuItemId;";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public void RemoveItem(InventoryItem item)
        {
            string query = "DELETE FROM InventoryItem WHERE inventoryItemId = @ItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemID", item.InventoryItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddItem(InventoryItem item)
        {
            //this method adds the item into the inventory Item table 
            string query = "INSERT INTO InventoryItem(inStock, menuItemKey) VALUES (@inStock, @menuItemKey);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@inStock", item.InStock);
            sqlParameters[1] = new SqlParameter("@menuItemKey", item.Name);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateItem(InventoryItem item)
        {
            //this method updates the existing item 
            string query = "UPDATE InventoryItem SET inStock = @inStock, [name] = @newName WHERE inventoryItemId = @ItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@inStock", item.InStock);
            sqlParameters[1] = new SqlParameter("@newName", item.Name.ToString());
            sqlParameters[2] = new SqlParameter("@ItemID", item.InventoryItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<InventoryItem> ReadTables(DataTable dataTable)
        {
            //this methods gets all the menuItems in a list from the database 
            List<InventoryItem> items = new List<InventoryItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //creates the new Item with all the information from the table
                InventoryItem item = new InventoryItem()
                {
                    InStock = (int)dr["inStock"],
                    InventoryItemId = (int)dr["inventoryItemId"],
                    Name = dr["name"].ToString(),
                };
                //adds the item to the list of all items 
                items.Add(item);
            }
            //finally all items are returned in a list 
            return items;
        }
    }
}
