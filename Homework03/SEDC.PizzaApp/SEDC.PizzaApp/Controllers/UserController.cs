using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<User> usersDb = StaticDb.Users;
            return View(usersDb);
        }
    }
}
