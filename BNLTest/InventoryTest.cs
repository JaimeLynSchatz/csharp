using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

namespace BNLTest
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void CanCreateInventory()
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
    }
}
