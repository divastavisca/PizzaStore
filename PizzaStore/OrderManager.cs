using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class OrderManager
    {
        private IBookingEngine _bookingEngine;
        private IPizzaShoppingCart _shoppingCart;

        public void AddToCart(Pizza selectedPizza)
        {
            _shoppingCart.Add(selectedPizza);
        }

        public List<Pizza> ViewCart()
        {
            return _shoppingCart.GetCartItems();
        }

        private bool CanOrder()
        {
            return _shoppingCart.GetCartItems().Count > 1;
        }

        public void ConfirmOrder()
        {
            if (this.CanOrder())
                _bookingEngine.CompleteTransaction(_shoppingCart);
        }

        public OrderManager()
        {
            _bookingEngine = new BookingEngine();
            _shoppingCart = new PizzaShoppingCart();
        }
    }
}
