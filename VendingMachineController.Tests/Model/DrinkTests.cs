using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineController.Model;

namespace VendingMachineController.Tests.Model
{
    public class DrinkTests
    {
        [Fact]
        public void DrinkNameNullOrEmpthyTest()
        {
            //Arrange
            string x = null;
            //Act
            // Assert
        }
        [Fact]
        public void DrinkNameTest()
        {
            //Arrange
            Product  sut = new Drink(1, 12, "Cola", "Open can -> drink it", "it is carbonated");
            string expectedText = "Cola";

            //Act
            string result = sut.TypeName;

            // Assert
            Assert.Equal(expectedText, result);
        }
        [Fact]
        public void DrinkExamineAndUseTest()
        {
            //Arrange
            Product sut = new Drink(1, 12, "Pripps", "Open can -> drink it", "carbonated");
            string expectedText = "12 sek.\r\nHow to use Pripps: Open can -> drink it.";

            //Act
            string result = sut.Examine();

            // Assert
            Assert.Equal(expectedText, result);
        }
        [Fact]
        public void DrinkUseTest()
        {
            //Arrange
            Product sut = new Drink(1, 12, "Pripps", "Open can -> drink it", "carbonated");
            string expectedText = "How to use Pripps: Open can -> drink it.";

            //Act
            string result = sut.Use();

            // Assert
            Assert.Equal(expectedText, result);
        }

        [Fact]
        public void DrinkIdTest()
        {
            //Arrange
            Product sut = new Drink(1, 12, "Pripps", "Open can -> drink it", "carbonated");
            int expectedText = 1;

            //Act
            int result = sut.IdProduct;

            // Assert
            Assert.Equal(expectedText, result);
        }

    }
}
