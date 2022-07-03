using System;
namespace BurgerAppDemo.Models.Domain
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
    }
}

