using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    class InventoryClass
    {
        private int _pricePerItem;
        private int _itemSize;
        private String _department;
        private List<String> _categories = new List<String>();

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

        public int ItemSize
        {
            get
            {
                return _itemSize;
            }

            set
            {
                _itemSize = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
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


/* Ideas for Structures

*/
