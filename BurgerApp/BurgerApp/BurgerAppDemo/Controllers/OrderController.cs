using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerAppDemo.Models.Domain;
using BurgerAppDemo.Models.Mapper;
using BurgerAppDemo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BurgerAppDemo.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListOrders()
        {
            List<Order> orders = StaticDb.Orders;

            List<OrderDetailsViewModel> orderViewModel = orders.Select(x => OrderMapper.ToOrderDetailsViewModel(x)).ToList();
            return View(orderViewModel);
        }
    }
}

