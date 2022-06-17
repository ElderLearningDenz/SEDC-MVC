using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult JsonData()
        {
            Order orderOne = new Order()
            {
                Id = 1,
                Name = "Bryce Jones",
                Address = "2314 Pallet Street",
                Email = "bryce@fakemail.com",
                PhoneNumber = "223-305"
            };
            Order orderTwo = new Order()
            {
                Id = 2,
                Name = "Hamdi Damdi",
                Address = "152 Sundown Lane",
                Email = "damdation@fakemail.com",
                PhoneNumber = "123456"
            };
            Order orderThree = new Order()
            {
                Id = 3,
                Name = "Enola Holmes",
                Address = "1945 Victoria Court",
                Email = "foundaclue@fakemail.com",
                PhoneNumber = "2481632"
            };
            return Json(new {OrderOne = orderOne, OrderTwo = orderTwo,OrderThree = orderThree });
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return RedirectToAction("Error");
            }
            return View(order);
        }

        public IActionResult PrintOrders()
        {
            List<Order> dbOrders = StaticDb.Orders;
            return View(dbOrders);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
