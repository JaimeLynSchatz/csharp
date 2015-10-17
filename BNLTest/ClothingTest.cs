using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

namespace BNLTest
{
    [TestClass]
    public class ClothingTest
    {
        Clothing shirt1;

        [ClassInitialize]
        public void SetupOnce()
        {
            // Create database connection
        }

        [TestInitialize]
        public void Setup()
        {
            // fetch data from database connection
            shirt1 = new Clothing("men's", "large", "white");
        }

        [TestCleanup]
        public void TearDown()
        {

        }

        [ClassCleanup]
        public void TearDownOnce()
        {

        }

        [TestMethod]
        public void CanCreateClothingItem()
        {
            // Arrange
            
            // Act

            // Assert
            Assert.AreEqual("men's white large", shirt1.Description);
        }

        [TestMethod]
        public void ClothingItemsAreSeparateObjects()
        {
            // Arrange

            Clothing dress1 = new Clothing("red", "women's", "large");

            // Act

            // Assert
            Assert.AreNotEqual(shirt1.Description, dress1.Description);
        }

    }
}
