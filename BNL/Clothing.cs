﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    public class Clothing : Inventory
    {
        public enum ClothingTypes
        {
            BathingSuit = 0,
            Pants       = 1,
            TShirt      = 2,
            Shirt       = 3,
            Socks       = 4,
            Robe        = 5,
            Dress       = 6,
            Shoes       = 7
        }

        public String ClothingType { get; set; }

        public Clothing(String g, String s, String c, String t)
        {
            Gender = g;
            Size = s;
            Color = c;
            // what do I do here?
            ClothingType = ClothingTypes.
            
        }

        public String Gender { get; set; }
        public String Size { get; set; }
        public String Color { get; set; }
        public override string Description
        {
            get
            {
                return Gender + " " + Size + " " + Color + " ";
            }
        }
    }
}
