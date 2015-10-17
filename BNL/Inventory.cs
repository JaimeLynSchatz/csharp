using System.Collections.Generic;

namespace BNL
{
    public class Inventory
    {
        public Inventory()
        {
            Categories = new List<string>();
        }

        public int PricePerItem
        {
            get;
            set;
        }

        public int ItemCount { get; set; }

        public string Name
        {
            get; set;
        }

        public virtual string Description
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
