using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    class Program
    {
        static void Main(string[] args)
        {
            enum response
            {
                EXIT = 0,
                SHOP = 1,
                CHECKOUT = 2,
                SAVECART = 3 
            };
            response = GetUserInput();
            while (response == SHOP)
            { 
                if (inventoryEmpty)
                {
                    Console.WriteLine("Thanks for visiting BNL today. Our shelves are empty! Please come again when the apocolypse is over!");
                }
            }
        }
    }
}
