using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{


    public class Clothing : Inventory
    {
        public enum Type
        {
            Pants,
            TShirt,
            Shirt,
            Socks,
            Robe,
            Dress,
            Shoes
        }

        public Clothing(string g, Type t, string s)
        {
            Gender = g;
            ClothingType = t;
            Size = s;
        }

        public string Gender
        {
            get;
            set;
        }

        public Type ClothingType
        {
            get; set;
        }

        public string Size
        {
            get;
            set;
        }
    }
}
