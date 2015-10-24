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
            CartContents = new List<Inventory>();

        }

        public int ShopperID { get; set; }

        public List<Inventory> CartContents { get; set; }

        // TODO: write a method to display the contents of the cart --
        // not crazy about this here. It's a UI thing (kind of)

        public void DisplayCart()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Your Items\n");
            foreach(Inventory item in CartContents)
            {
                Console.WriteLine(item + "\n");
            }
            Console.WriteLine("**********************");
        }

        // TODO: Write a method to return the contents of the cart
        // how is this different from CartContents??? I don't think it is.

        // TODO: write a method to add items to the cart
        public void AddItem(Inventory item)
        {
            CartContents.Add(item);
        }
        // TODO: write a method to add items to the cart in such a way that
        // new items will be added as new entries 
        // but duplicates will be incremented

        public void RemoveItem(Inventory item)
        {
            CartContents.Remove(item);
        }
    }
}
