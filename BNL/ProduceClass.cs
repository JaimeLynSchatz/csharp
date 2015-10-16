using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    class ProduceClass : InventoryClass
    {
        private int _pricePerPound;

        public int PricePerPound
        {
            get
            {
                return _pricePerPound;
            }

            set
            {
                _pricePerPound = value;
            }
        }

    }
}
