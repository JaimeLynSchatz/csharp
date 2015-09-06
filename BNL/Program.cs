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
            String response = "No User Input Yet";
            bool inventoryEmpty = false;

            response = StoreFront.GetUserInput();
            while (response == "shop")
            { 
                if (inventoryEmpty)
                {
                    Console.WriteLine("Thanks for visiting BNL today. Our shelves are empty! Please come again when the apocolypse is over!");
                    return;
                }
                else
                {
                    StoreFront.AskUser();
                }
            }

            Console.WriteLine("Thanks for visiting BNL today. See you later!");
        }
    }
}

