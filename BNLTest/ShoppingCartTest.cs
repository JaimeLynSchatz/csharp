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
            cart = new ShoppingCart("empty");
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

        [TestMethod]
        public void CanAddItemsToShoppingCart()
        {
            cart.Add("inventory item here");

        }
    }
}
