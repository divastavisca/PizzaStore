using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaShoppingCart : IPizzaShoppingCart
    {
        private List<Pizza> _cart;

        public PizzaShoppingCart()
        {
            _cart = new List<Pizza>();
        }

        public void Add(Pizza newPizza)
        {
            _cart.Add(newPizza);
        }

        public List<Pizza> GetCartItems()
        {
            return _cart;
        }

        public void Remove(Pizza item)
        {
            _cart.Remove(item);
        }
    }
}
