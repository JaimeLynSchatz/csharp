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
        [ExpectedException(typeof(ArgumentNullException))]
        public void WillFailIfGenderIsNull()
        {
            Clothing clothing = new Clothing(null, "large", "white", "Shirt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WillFailIfSizeIsNull()
        {
            Clothing clothing = new Clothing("men's", null, "white", "Shirt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WillFaillIfColorIsNull()
        {
            Clothing clothing = new Clothing("men's", "large", null, "Shirt");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WillFailToParseIllegibleEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", "beer");
        }
        [TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        // Instead, will accept a null clothing type and set it to None
        public void WillParseNullEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", null);
            Assert.IsNotNull(clothing);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void WillParseLowercaseEnums()
        {
            Clothing clothing = new Clothing("men's", "large", "white", "shirt");
            Assert.IsNotNull(clothing);
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
