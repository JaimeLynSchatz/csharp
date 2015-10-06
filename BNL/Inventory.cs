using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    public class Inventory
    {
        private int _pricePerItem;
        public virtual String Description { get; set; }
        private List<string> _categories = new List<string>();
        public int itemCount { get; set; }

        public int PricePerItem
        {
            get
            {
                return _pricePerItem;
            }

            set
            {
                _pricePerItem = value;
            }
        }

        public List<string> Categories
        {
            get
            {
                return _categories;
            }

            set
            {
                _categories = value;
            }
        }
    }
}

