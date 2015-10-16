using System.Collections.Generic;

namespace BNL
{
    public class Inventory
    {
        public Inventory()
        {
            Categories = new List<string>();
        }

        public int Price
        {
            get;
            set;
        }

        public string Name
        {
            get; set;
        }

        public string Description
        {
            get;
            set;
        }

        public List<string> Categories
        {
            get;
            set;
        }
    }
}


/* Ideas for Structures

*/
