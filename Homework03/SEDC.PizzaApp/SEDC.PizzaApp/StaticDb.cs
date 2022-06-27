using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp
{
    public class StaticDb
    {
        public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Margherita",
                Price = 330m,
                IsOnPromotion = true,
                PizzaSize = PizzaSize.Normal,
                HasExtras = true,
            },
            new Pizza()
            {
                Id=2,
                Name = "Capricciosa",
                Price = 400m,
                IsOnPromotion = false,
                PizzaSize= PizzaSize.Family,
                HasExtras = true
            },
            new Pizza()
            {
                Id = 3,
                Name = "American Hot",
                Price = 400m,
                IsOnPromotion = true,
                PizzaSize = PizzaSize.Family,
                HasExtras = false                
            }
        };

        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Dejan",
                LastName = "Kostenarov",
                Address = "Partizanski odr. 22/2-2",
                PhoneNumber = "078 223 305"
            },
            new User()
            {
                Id = 2,
                FirstName = "Alek",
                LastName = "Kostenarov",
                Address = "Manapo 4-1",
                PhoneNumber = "077 455 704"
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x=> x.Id== 2),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethod.Cash
            },
            new Order()
            {
                Id = 2,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 3),
                User = Users.First(x => x.Id == 1),
                PaymentMethod = PaymentMethod.Card
            }
        };
    }
}
