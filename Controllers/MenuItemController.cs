using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

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

            new MenuItem{Id = 1, Name = "Pizza", freeDelivery = true, Price = 249, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true } ,
        new MenuItem{Id = 2, Name = "Chole Batore", freeDelivery = true, Price = 99, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true},
              new MenuItem{ Id = 3, Name = "Cold Coffee", freeDelivery = false, Price = 79, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true },
             new MenuItem{ Id = 4, Name = "Aloo Paratha", freeDelivery = true, Price = 69, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true },
              new MenuItem{Id = 5, Name = "Oreo Shake", freeDelivery = false, Price = 89, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = false } };
    
    
        

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


/*   

        List<MenuItem> menuItems = new List<MenuItem>();


       new MenuItemController(1, "Pizza", true, 249, Convert.ToDateTime("2020-05-05"), true);//{ 1, "Pizza",  true, 249,  Convert.ToDateTime("2020-05-05"),  true });
     menuItems.Add(new MenuItem() { Id = 2, Name = "Chole Batore", freeDelivery = true, Price = 99, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true });
     menuItems.Add(new MenuItem() { Id = 3, Name = "Cold Coffee", freeDelivery = false, Price = 79, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true });
     menuItems.Add(new MenuItem() { Id = 4, Name = "Aloo Paratha", freeDelivery = true, Price = 69, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = true });
     menuItems.Add(new MenuItem() { Id = 5, Name = "Oreo Shake", freeDelivery = false, Price = 89, dateOfLaunch = Convert.ToDateTime("2020-05-05"), Active = false });
     */
