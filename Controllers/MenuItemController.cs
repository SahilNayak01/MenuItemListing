using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemListing.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {

        // public List<MenuItem> menuItems = new List<MenuItem>();
        //enuItem a=new MenuItem();

        /*
        public MenuItemController(int id,string name,Boolean delivery, double price,DateTime date , Boolean active)
        {
            a.Id = id;
            a.Name = name;
            a.freeDelivery = delivery;
            a.Price = price;
            a.dateOfLaunch = date;
            a.Active = active;
                   
                       menuItems.Add(a);

        }
        */

        public List<MenuItem> menuItems = new List<MenuItem>()
        {

            new MenuItem{Id = 1, Name = "Sandwitch", freeDelivery = true, Price = 100, dateOfLaunch = Convert.ToDateTime("2020-05-22"), Active = true } ,
        new MenuItem{Id = 2, Name = "Burger", freeDelivery = true, Price = 99, dateOfLaunch = Convert.ToDateTime("2020-05-22"), Active = true},
              new MenuItem{ Id = 3, Name = "Pizza", freeDelivery = false, Price = 279, dateOfLaunch = Convert.ToDateTime("2020-05-22"), Active = true },
             new MenuItem{ Id = 4, Name = "Fries", freeDelivery = true, Price = 69, dateOfLaunch = Convert.ToDateTime("2020-05-22"), Active = true },
              new MenuItem{Id = 5, Name = "Coke", freeDelivery = false, Price = 61, dateOfLaunch = Convert.ToDateTime("2020-05-22"), Active = false } };




        [HttpGet]
        [Route("api/MenuItem")]
        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        [HttpGet]
        [Route("api/MenuItem/{Id}")]
        public string GetByIdMenuItem(int id)
        {
            MenuItem item = menuItems.Where(x => x.Id == id).FirstOrDefault();
            return Convert.ToString(item.Name);
        }
    }
}