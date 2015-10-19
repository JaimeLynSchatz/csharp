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
        static public void SetupOnce(TestContext testContext)
        {
            // Create database connection
        }

        [TestInitialize]
        public void Setup()
        {
            // fetch data from database connection
            shirt1 = new Clothing("men's", "large", "white", "Shirt");
        }

        [TestCleanup]
        public void TearDown()
        {

        }

        [ClassCleanup]
        static public void TearDownOnce()
        {

        }

        [TestMethod]
        public void CanCreateClothingItem()
        {
            // Arrange

            // Act

            // Assert
            //Assert.AreEqual("yes", "yes");
            //Assert.AreEqual(shirt1.Description, shirt1.Description);
            Assert.AreEqual("men's large white Shirt", shirt1.Description);
        }

        [TestMethod]
        public void ClothingItemsAreSeparateObjects()
        {
            // Arrange

            Clothing dress1 = new Clothing("red", "women's", "large", "Dress");
            // TODO: Make the "ClothingType" work properly. Part of constructor???

            // Act

            // Assert
            Assert.AreNotEqual(shirt1.Description, dress1.Description);
        }

    }
}
