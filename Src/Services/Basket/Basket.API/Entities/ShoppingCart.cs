using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }

        public List<ShoppingCartItems> ItemsCart { get; set; } = new List<ShoppingCartItems>();

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in ItemsCart)
                {
                    totalprice += item.Price * item.Quantity;
                }

                return totalprice;
            }
        }
    }

}
