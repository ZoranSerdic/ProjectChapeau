using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class InventoryItemService
    {
        InventoryItemdDAO inventoryItemdDAO;
        public InventoryItemService()
        {
            inventoryItemdDAO = new InventoryItemdDAO();
        }

        public List<InventoryItem> GetInventoryItems()
        {
            //gets all the items from the DAL 
            return inventoryItemdDAO.GetAllInventoryItems();
        }
        public void AddInventoryItem(InventoryItem inventoryItem)
        {
            //adds an Item via DAL 
            inventoryItemdDAO.AddItem(inventoryItem);
        }
        public void RemoveInventoryItem(InventoryItem inventoryItem)
        {
            //Removes Item via DAL 
            inventoryItemdDAO.RemoveItem(inventoryItem); 
        }
        public void UpdateInventoryItem(InventoryItem inventoryItem)
        {
            inventoryItemdDAO.UpdateItem(inventoryItem);
        }
        public void DecreaseInventoryItemStock(int menuItemId, int amount)
        {
            inventoryItemdDAO.DecreaseInventoryItemStock(menuItemId, amount);
        }
    }
}
