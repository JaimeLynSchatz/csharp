using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    static class StoreFront
    {
        // get user input here and put it in response
        static public String GetUserInput()
        {
            return Console.ReadLine();
        }

        static public String AskUser()
        {
            Console.WriteLine("What would you like today?");
            return GetUserInput();
        }
    }
}
