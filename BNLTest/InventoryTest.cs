using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;
using System.Collections.Generic;

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
            // Arrange
            Inventory inventoryItem = new Inventory();
            List<string> categoryList = new List<string>();
            categoryList.Add("socks");
            categoryList.Add("tights");
            categoryList.Add("accessories");

            // Act
            inventoryItem.Categories.Add("socks");
            inventoryItem.Categories.Add("tights");
            inventoryItem.Categories.Add("accessories");

            // Assert
            // Assert.IsNotNull(inventoryItem.Categories); -- passes
            Assert.IsInstanceOfType(inventoryItem.Categories, List<string>);
            //Assert.AreEqual(inventoryItem.Categories, categoryList);
        }

    }
}
