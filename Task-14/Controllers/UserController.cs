using Microsoft.AspNetCore.Mvc;
using Task_14.Models.Customers.Entities;

namespace Task_14.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.Title = "User";
            List<User> users = new List<User>()
            {
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-1"  , SurName="surname-1" , Age=12 , Country="country-1" ,   PhoneNumber="+994123456789"},
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-2"  , SurName="surname-2" , Age=12 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-3"  , SurName="surname-3" , Age=32 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-4"  , SurName="surname-4" , Age=22 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-5"  , SurName="surname-5" , Age=17 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-7"  , SurName="surname-7" , Age=12 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-8"  , SurName="surname-8" , Age=12 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-9"  , SurName="surname-9" , Age=12 , Country="country-1" ,   PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-10"  , SurName="surname-10" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-11"  , SurName="surname-11" , Age=12 , Country="country-1" , PhoneNumber="+994123456789"},
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-12"  , SurName="surname-12" , Age=52 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-13"  , SurName="surname-13" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-14"  , SurName="surname-14" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-15"  , SurName="surname-15" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-16"  , SurName="surname-16" , Age=62 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-17"  , SurName="surname-17" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-17"  , SurName="surname-17" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-18"  , SurName="surname-18" , Age=92 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-19"  , SurName="surname-19" , Age=12 , Country="country-1" , PhoneNumber="+994123456789" },
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-20"  , SurName="surname-20" , Age=42 , Country="country-1" , PhoneNumber="+994123456789"},
              new User(){Id=Guid.NewGuid() ,CreatedDate=DateTime.UtcNow, Name="name-21"  , SurName="surname-21" , Age=32 , Country="country-1" , PhoneNumber="+994123456789"},


            };
        
            return View(users);
        }
        [Area("Details")]
         public IActionResult UsersDetails(string userId)
        {
            List<User> users = new List<User>();  
            
         var data =    users.Find(user=>user.Id==Guid.Parse(userId)); 
            return View(data);
        }
    }
}
