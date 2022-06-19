using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
        public static class OrderDb
        {
            public static List<Order> Orders = new List<Order> {
                new Order()
                {
                    OrderId = 1,
                    Price = 10,
                    CustomerName = "Vlatko"
                },
                new Order()
                {
                    OrderId = 2,
                    Price = 12,
                    CustomerName = "Mario"
                },
                new Order()
                {
                    OrderId = 3,
                    Price = 15,
                    CustomerName = "Bob"
                },
                new Order()
                {
                    OrderId = 4,
                    Price = 8,
                    CustomerName = "John"
                },
        };
    }
}
