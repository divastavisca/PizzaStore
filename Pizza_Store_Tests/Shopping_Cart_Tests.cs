using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore;
using System.Collections.Generic;

namespace Pizza_Store_Tests
{
    [TestClass]
    public class Shopping_Cart_Tests
    {
        PizzaShoppingCart pizzaCart;
        Pizza margherita;

        public Shopping_Cart_Tests()
        {
            pizzaCart = new PizzaShoppingCart();
            margherita= new Pizza(
                    "Margherita",
                    true,
                    "Medium 10/2",
                    new List<string>()
                    {
                        {"Pepperoni" },
                        {"Mushrooms" },
                        {"Onions" }
                    },
                    120
                );
        }

        [TestMethod]
        public void Cart_should_add_a_pizza_to_its_list_when_add_function_is_invoked()
        {
            pizzaCart.Add(margherita);
            List<Pizza> cartItems = pizzaCart.GetCartItems();
            Assert.IsTrue(cartItems.Contains(margherita));
        }

        [TestMethod]
        public void Cart_should_remove_the_specified_pizza_if_present_when_remove_function_is_invoked()
        {
            pizzaCart.Add(margherita);
            List<Pizza> cartItems = pizzaCart.GetCartItems();
            Assert.IsTrue(cartItems.Contains(margherita));
            pizzaCart.Remove(margherita);
            cartItems = pizzaCart.GetCartItems();
            Assert.IsFalse(cartItems.Contains(margherita));
        }
    }
}
