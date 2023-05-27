using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
