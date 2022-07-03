using System;
using BurgerAppDemo.Models.Domain;

namespace BurgerAppDemo
{
    public static class StaticDb
    {
        public static List<Burger> Burgers = new List<Burger>()
        {
            new Burger
            {
                Id = 1,
                Name = "Double Cheese",
                Price = 350,
                IsVegan = false,
                IsVegeterian = false,
                HasFries = true
            },

            new Burger
            {
                Id = 2,
                Name = "Big Mac",
                Price = 380,
                IsVegan = false,
                IsVegeterian = false,
                HasFries = true
            },

            new Burger
            {
                Id = 3,
                Name = "Veggie Grill Burger",
                Price = 450,
                IsVegan = true,
                IsVegeterian = true,
                HasFries = true
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order
            {
                Id = 1,
                BurgerId = 1,
                Burger = Burgers.First(),
                FullName = "Dejan Kostenarov",
                Location = "Vlae",
                IsDelivered = true
            },

            new Order
            {
                Id = 2,
                BurgerId = 2,                
                Burger = Burgers.First(x=>x.Id == 2),
                FullName = "Alek Kostenarov",
                Location = "Centar",
                IsDelivered = false
            },

            new Order
            {
                Id = 3,
                BurgerId = 3,                
                Burger = Burgers.First(x=>x.Id == 3),
                FullName = "Viktor Karevski",
                Location = "Chento",
                IsDelivered = true
            }
        };
    }
}

