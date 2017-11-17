using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface IPizzaShoppingCart
    {
        void Add(Pizza newPizza);
        void Remove(Pizza item);
        List<Pizza> GetCartItems();
    }
}
