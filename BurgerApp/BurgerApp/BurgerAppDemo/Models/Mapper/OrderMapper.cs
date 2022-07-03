using System;
using BurgerAppDemo.Models.Domain;
using BurgerAppDemo.Models.ViewModels;

namespace BurgerAppDemo.Models.Mapper
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel ToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                Id = order.Id,
                BurgerName = order.Burger.Name,
                UserName = order.FullName,
                Price = order.Burger.Price,
                IsDelivered = order.IsDelivered,
                Location = order.Location
            };
        }
    }
}

