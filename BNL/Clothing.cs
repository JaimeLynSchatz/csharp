using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    public class Clothing : Inventory
    {
        // Do I want an enum here? It's really for building a dictionary of valid responses
        // There are no magic numbers involved here
        // May need to refactor this -- it's not really doing what I want it to do
        // but I'm not very clear on *what* exactly I want it to do
        public enum ClothingTypes
        {
            None        = 0,
            BathingSuit = 1,
            Pants       = 2,
            TShirt      = 3,
            Shirt       = 4,
            Socks       = 5,
            Robe        = 6,
            Dress       = 7,
            Shoes       = 8
        }

        public ClothingTypes ClothingType { get; set; }

        // why isn't this working???
        public Clothing(String g, String s, String c, ClothingTypes t)
        {
            try
            {
                Gender = g;
                Size = s;
                Color = c;
                ClothingType = t;
            }
            catch (ArgumentNullException e)
            {
                System.Console.WriteLine("Please try again, invalid values entered for clothing inventory item at:\n", e);
                throw e;
            }
        }

        public Clothing(String g, String s, String c, String t)
            : this(g, s, c, Parse(t))
        {
        }

        private static ClothingTypes Parse(String ct)
        {
            if (String.IsNullOrEmpty(ct))
            {
                return 0;
            }

            ClothingTypes clothingType;
            if (Enum.TryParse<ClothingTypes>(ct, out clothingType)) {
                return (ClothingTypes)Enum.Parse(typeof(ClothingTypes), ct);
            }
            ct = (ct[0].ToString()).ToUpper() + ct.Substring(1);
            return (ClothingTypes)Enum.Parse(typeof(ClothingTypes), ct);
        }

        public String Gender { get; set; }
        public String Size { get; set; }
        public String Color { get; set; }
        public override string Description
        {
            get
            {
                return Gender + " " + Size + " " + Color + " " + ClothingType.ToString();
            }
        }
    }
}
