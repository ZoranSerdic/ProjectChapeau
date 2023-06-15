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
            string query = "SELECT I.inStock, I.inventoryItemId, I.MenuItemKey, M.[name] FROM InventoryItem AS I JOIN MenuItem AS M ON I.MenuItemKey = menuItemId;";
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
            try
            {
                //this method adds the item into the inventory Item table 
                string query = "INSERT INTO InventoryItem(inStock, menuItemKey) VALUES (@inStock, @menuItemKey);";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@inStock", item.InStock);
                sqlParameters[1] = new SqlParameter("@menuItemKey", item.MenuItemID);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Stock Item ID", ex);
            }
        }
        public void UpdateItem(InventoryItem item)
        {
            //this method updates the existing item 
            string query = "UPDATE InventoryItem SET inStock = @inStock WHERE inventoryItemId = @ItemID;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@inStock", item.InStock);
            sqlParameters[1] = new SqlParameter("@ItemID", item.InventoryItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DecreaseInventoryItemStock(int menuItemId, int amount)
        {
            try
            {
                // Update dbo.InventoryItem to decrease the inStock value
                string query = "UPDATE dbo.InventoryItem " +
                    "SET inStock = inStock - @amount " +
                    "WHERE MenuItemKey = @MenuItemKey;";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@amount", amount);
                sqlParameters[1] = new SqlParameter("@MenuItemKey", menuItemId);
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
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
                    MenuItemID = (int)dr["MenuItemKey"],
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
