using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BNL;
using System.Collections.Generic;

namespace BNLExplorationTests
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void SimpleClothing()
        {
            var c = new Clothing("M", Clothing.Type.TShirt, "XL");
        }

        [TestMethod]
        public void SampleGroceryCart()
        {
            // This used to say:
            // Inventory items = [
            //      new Clothing("M", Clothing.Type.Dress, "S"));
            //      new Clothing("M", Clothing.Type.TShirt, "XL");
            //
            // But I got the red squiggles under the opening bracket and all the Googling
            // in the world wasn't revealing what I had done wrong

            List<Inventory> items = new List<Inventory>();
            items.Add(new Clothing("M", Clothing.Type.Dress, "5"));
            items.Add(new Clothing("M", Clothing.Type.TShirt, "XL"));
            ;
        }
    }
}
