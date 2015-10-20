using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

namespace BNLTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        ShoppingCart cart;

        [ClassInitialize]
        static public void SetupOnce(TestContext testContext)
        {
            // Create database connection or other resource we'll need throughout
        }

        [TestInitialize]
        public void Setup()
        {
            // fetch data from database connection, initialize instances, etc.
            cart = new ShoppingCart(123);
        }

        [TestCleanup]
        public void TearDown()
        {
            // awesome stuff, close the file, etc.
        }

        [ClassCleanup]
        static public void TearDownOnce()
        {
            // teardown the temp DB, etc.
        }
         // TODO test for nulls in all constructors, better exeception catching with the parser
        [TestMethod]
        public void CanAddItemsToShoppingCart()
        {
            // Arrange
            Clothing shirt1 = new Clothing("men's", "large", "white", "TShirt");
            Clothing dress1 = new Clothing("women's", "large", "red", "Dress");
            Clothing robe1 = new Clothing("women's", "medium", "purple", "Robe");

            // Act
            cart.AddItem(shirt1);
            cart.AddItem(dress1);
            cart.AddItem(robe1);

            // Assert
            cart.Equals(cart);
        }
    }
}
