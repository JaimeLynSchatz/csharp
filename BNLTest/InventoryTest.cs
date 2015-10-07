using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;
using System.Collections.Generic;
using System.Linq;

namespace BNLTest
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void CanCreateItem()
        {
            // I think I should create a basic test that the other class tests can inherit from
            // What am I trying to achieve here, though?

            // Arrange
            Inventory inventoryItem = new Inventory();
            inventoryItem.Description = "This is a basic inventory item";

            // Act

            // Assert
            Assert.AreEqual(inventoryItem.Description, "This is a basic inventory item");
            
        }

        [TestMethod]
        public void CanSetPrice()
        {
            // Arrange
            Inventory inventoryItem = new Inventory();
            inventoryItem.PricePerItem = 500;
            inventoryItem.itemCount = 3;

            // Act
            int extendedPrice = inventoryItem.PricePerItem * inventoryItem.itemCount;

            // Assert
            Assert.AreEqual(extendedPrice, 500 * 3);
        }

        [TestMethod]
        public void CanSetCategories()
        {
            var list = new List<string>() {
                "socks",
                "tights",
                "accessories"
            };

            // Arrange
            // Act
            Inventory inventoryItem = new Inventory();
            inventoryItem.Categories.AddRange(list);

            // Assert
            Assert.IsNotNull(inventoryItem.Categories); // passes
            Assert.AreEqual(list.Length, inventoryItem.Categories.Count);
            Assert.AreEqual(list[0], inventoryItem.Categories[0]);
            Assert.AreEqual(list[1], inventoryItem.Categories[1]);
            Assert.AreEqual(list[2], inventoryItem.Categories[2]);
        }
    }
}
