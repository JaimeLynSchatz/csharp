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
            shirt1 = new Clothing("men's", "large", "white", Clothing.ClothingTypes.Shirt);
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
        public void CanParseShirt()
        {
            // Arrange
            var shirt = "Shirt";
            Clothing clothing = null;

            // Act
            try
            {
                clothing = new Clothing("men's", "large", "white", "Shirt");
            }
            catch (Exception x)
            {
                Assert.Fail("Exception x:" + x);
            }

            // Assert
            Assert.IsTrue(clothing != null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WillFailToParseIllegibleEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", "beer");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WillFailToParseNullEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WillFailToParseLowercaseEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", "shirt");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WillFailToParseUppercaseEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", "SHIRT");
        }


        [TestMethod]
        public void ClothingItemsAreSeparateObjects()
        {
            // Arrange
            Clothing dress1 = new Clothing("red", "women's", "large", "Dress");

            // Act

            // Assert
            Assert.AreNotEqual(shirt1.Description, dress1.Description);
        }

    }
}
