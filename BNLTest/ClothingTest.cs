using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNL;

namespace BNLTest
{
    [TestClass]
    public class ClothingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Clothing shirt1 = new Clothing();
            shirt1.Color = "white";
            shirt1.Gender = "men's";
            shirt1.Size = "large";
            shirt1.Description = shirt1.Gender + " " + shirt1.Color + " " + shirt1.Size + " ClothingType here";

            Clothing dress1 = new Clothing();
            dress1.Color = "red";
            dress1.Gender = "women's";
            dress1.Size = "large";
            dress1.Description = dress1.Gender + " " + dress1.Color + " " + dress1.Size + " ClothingType here";

            // Act
            // working this part out still

            // Assert
            Assert.AreEqual("men's white large ClothingType here", shirt1.Description);
            Assert.AreEqual("women's red large ClothingType here", dress1.Description);
            Assert.AreNotEqual(shirt1.Description, dress1.Description);
        }
    }
}
