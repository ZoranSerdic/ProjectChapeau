using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDAO;
        public MenuItemService()
        {
            menuItemDAO = new MenuItemDAO();  
        }

        //passes on all the menu Items 
        public List<MenuItem> GetAllMenuItems()
        {
            return menuItemDAO.GetAllMenuItems();
        }
        //passes on all the drinks 
        public List<MenuItem> GetAllDrinks()
        {
            return menuItemDAO.GetAllDrinks();
        }
        //passes on all the starters 
        public List<MenuItem> GetAllStarters()
        {
            return menuItemDAO.GetAllStarters();
        }
        //passes on all the main courses 
        public List<MenuItem> GetAllMains()
        {
            return menuItemDAO.GetAllMainDishes();
        }
        //passes on all the desserts 
        public List<MenuItem> GetAllDesserts()
        {
            return menuItemDAO.GetAllDesserts();
        }
        //passes specific courseType and menuType
        public List<MenuItem> GetCourseMenuType(FoodType courseType, MenuType menuType)
        {
            return menuItemDAO.GetCourseMenuType(courseType, menuType);
        }

        public void RemoveItem(MenuItem item)
        {
            menuItemDAO.RemoveItem(item);
        }
        public void AddItem(MenuItem item)
        {
            menuItemDAO.AddItem(item);
        }
        public void UpdateItem (MenuItem item)
        {
            menuItemDAO.UpdateItem(item);
        }
    }
}
