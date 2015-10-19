using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    public class ShoppingCart
    {

        public ShoppingCart(int shopperID)
        {
            ShopperID = shopperID;
        }

        public int ShopperID { get; set; }

        public List<Inventory> CartContents { get; set; }

        // TODO: write a method to display the contents of the cart

        // TODO: write a method to add items to the cart in such a way that
        // new items will be added as new entries 
        // but duplicates will be incremented
    }
}
