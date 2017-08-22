using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        public string Name { get; private set; }
        public bool IsVeg { get; private set; }
        public string Size { get; private set; }
        public List<string> Toppings { get; private set; }
        public int Price { get; private set; }

        /// <summary>
        /// Initializes values for a pizza object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isVeg"></param>
        /// <param name="size"></param>
        /// <param name="toppings"></param>
        public Pizza(string name,bool isVeg,string size,List<string> toppings,int price)
        {
            Name = name;
            IsVeg = isVeg;
            Size = size;
            Toppings = toppings;
            Price = price;
        }
    }
}
