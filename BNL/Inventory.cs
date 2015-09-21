using System.Collections.Generic;

namespace BNL
{
    class Inventory
    {
        public Inventory()
        {
            Department = "";
            Categories = new List<string>();
        }

        public int PricePerItem
        {
            get;
            set;
        }

        public int ItemSize
        {
            get;
            set;
        }

        public string Department
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
