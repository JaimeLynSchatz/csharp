using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = args[0];
            }
            catch
            {
                // no idea what to do here
            }
            else
            {
                string name = "Super Secret User";
            }
            string response = "";
            Console.WriteLine("Hello, " + name + "! Today is " + DateTime.Now);
            Console.WriteLine("Would you like to play a game?\nY\\N");
            response = Console.ReadLine();
            if (response == "Y")
            {
                Console.WriteLine("That's great! Me, too! What shall we play?");
            }
            Console.ReadLine();

        }
    }
}
