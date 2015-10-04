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

            // Act
            // working this part out still

            // Assert
            Assert.AreEqual("men's white large ClothingType here", shirt1.Description);
        }
    }
}
