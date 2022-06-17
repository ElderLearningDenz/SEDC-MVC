using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Margherita",
                Price = 330,
                IsOnPromotion = true,
            },
            new Pizza()
            {
                Id=2,
                Name = "Capricciosa",
                Price = 400,
                IsOnPromotion = false
            },
            new Pizza()
            {
                Id = 3,
                Name = "American Hot",
                Price = 400,
                IsOnPromotion = true
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                Name = "Bryce Jones",
                Address = "2314 Pallet Street",
                Email = "bryce@fakemail.com",
                PhoneNumber = "223-305"
            },
            new Order()
            {
                Id = 2,
                Name = "Hamdi Damdi",
                Address = "152 Sundown Lane",
                Email = "damdation@fakemail.com",
                PhoneNumber = "123456"
            },
            new Order()
            {
                Id = 3,
                Name = "Enola Holmes",
                Address = "1945 Victoria Court",
                Email = "foundaclue@fakemail.com",
                PhoneNumber = "2481632"
            }
        };
    }
}
