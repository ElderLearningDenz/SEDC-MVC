using System;
namespace BurgerAppDemo.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public string BurgerName { get; set; }
        public object UserName { get; set; }
        public double Price { get; set; }
        public bool IsDelivered { get; set; }
        public string Location { get; set; }
    }
}

