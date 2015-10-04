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
            shirt1.Description
            // Act
            
            // Assert
        } // VS is using this bracket to close the bracket on ClothingTest, not TestMethod1
    }
}
