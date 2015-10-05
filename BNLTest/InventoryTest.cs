using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

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

    }
}
