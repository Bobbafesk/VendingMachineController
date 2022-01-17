using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineController.Model;

namespace VendingMachineController.Tests.Model
{
    public class DrinkTests
    {
        //[Fact]
        //public void DrinkNameNullOrEmpthyTest()
        //{
        //    //Arrange
        //    string nullString = null;
        //    Product sut = new Drink(1, 12, "Cola", "Open can -> drink it", true);
        //    string expectedText = "Cola";


        //    //Act 
        //    // System.ArgumentException : typeName (Parameter 'Null, emty or whitespace')
        //    // string result = sut.TypeName;
        //    var result = Assert.Throws<ArgumentException>(() => sut.TypeName = nullString);
        //    //(() => numberArray[99]);

        //    // Assert "typeName", "Null, emty or whitespace"
        //    Assert.Equal("typeName", result.ParamName);
        //    Assert.Contains("Null, emty or whitespace", result.Message);
        //    Assert.Equal(expectedText, sut.TypeName); // Check oiginal is still intact
        //}

        [Theory]
        [InlineData(null , )]
        public void DrinkNameNullOrEmpthyTest(string strIn, string expectedText )
        {
            //Arrange
            string nullString = null;
            Product sut = new Drink(1, 12, "Cola", "Open can -> drink it", true);
            string expectedText = "Cola";


            //Act 
            // System.ArgumentException : typeName (Parameter 'Null, emty or whitespace')
            // string result = sut.TypeName;
            var result = Assert.Throws<ArgumentException>(() => sut.TypeName = nullString);
            //(() => numberArray[99]);

            // Assert "typeName", "Null, emty or whitespace"
            Assert.Equal("typeName", result.ParamName);
            Assert.Contains("Null, emty or whitespace", result.Message);
            Assert.Equal(expectedText, sut.TypeName); // Check oiginal is still intact
        }

        [Fact]
        public void DrinkNameTest()
        {
            //Arrange
            Product  sut = new Drink(1, 12, "Cola", "Open can -> drink it", true);
            string expectedText = "Cola";

            //Act
            string result = sut.TypeName;

            // Assert
            Assert.Equal(expectedText, result);
        }
        [Fact]
        public void DrinkExamineTest()
        {
            //Arrange
            string prodName = "Pripps";
            int prodPrice = 12;
            string prodUseText = "Open can -> drink it"; 
            bool prodCarb = true;
            string prodCarbExpected = "is carbonated";
            Product sut = new Drink(1, prodPrice, prodName , prodUseText, prodCarb);

            //Act
            string result = sut.Examine();

            // Assert
            Assert.Contains(prodName, result);
            // Assert.Contains(prodUseText, result); Use is out in this eversion
            Assert.Contains(prodPrice.ToString(), result);
            Assert.Contains(prodCarbExpected, result);
        }
        [Fact]
        public void DrinkUseTest()
        {
            //Arrange
            Product sut = new Drink(1, 12, "Pripps", "Open can -> drink it", true);
            string expectedText = "How to use Pripps: Open can -> drink it.";

            //Act
            string result = sut.Use();

            // Assert
            Assert.Contains(expectedText, result);
        }

        [Fact]
        public void DrinkIdTest()
        {
            //Arrange
            Product sut = new Drink(1, 12, "Pripps", "Open can -> drink it", true);
            int expectedText = 1;

            //Act
            int result = sut.IdProduct;

            // Assert
            Assert.Equal(expectedText, result);
        }

    }
}
