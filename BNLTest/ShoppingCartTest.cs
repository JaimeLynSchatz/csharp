using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

namespace BNLTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        ShoppingCart cart = new ShoppingCart(123);

        [ClassInitialize]
        static public void SetupOnce(TestContext testContext)
        {
            // Create database connection or other resource we'll need throughout
            
        }

        [TestInitialize]
        public void Setup()
        {
            // fetch data from database connection, initialize instances, etc.
            
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
            int itemCounter = 0;

            // Act
            cart.AddItem(shirt1);
            itemCounter++;
            cart.AddItem(dress1);
            itemCounter++;
            cart.AddItem(robe1);
            itemCounter++;

            // Assert
            Assert.AreEqual(cart.CartContents.Count, itemCounter);
        }

        public void CanRemoveItemsFromShoppingCart(Inventory itemToRemove)
        {
            // Arrange
            Clothing shirt1 = new Clothing("men's", "large", "white", "TShirt");
            Clothing dress1 = new Clothing("women's", "large", "red", "Dress");
            Clothing robe1 = new Clothing("women's", "medium", "purple", "Robe");

            // Act
            cart.RemoveItem(shirt1);

            // Assert
            Assert.AreEqual(true, !cart.CartContents.Contains(shirt1));
        }
    }
}
