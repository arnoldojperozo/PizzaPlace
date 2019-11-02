using System;
using System.Collections.Generic;
namespace PizzaPlace.Shared
{
    public class Basket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;

        private void AddToBasket(Pizza pizza)
        {
            Console.WriteLine($"Added pizza {pizza.Name}");
            State.Basket.Add(pizza.Id);
        }

        public void Add(int pizzaId)
        {
            Orders.Add(pizzaId);
        }
    }
}