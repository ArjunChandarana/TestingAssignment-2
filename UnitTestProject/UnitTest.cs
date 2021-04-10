using System;
/*using Microsoft.VisualStudio.TestTools.UnitTesting;*/
using Testing_Assignment_2;
using Xunit;

namespace UnitTestProject
{
   
    public class UnitTest
    {
        string inputString = "";
        string expected = "";
        [Fact]
        public void UppartoLower()
        {
            //Arrange
            inputString = "Unit Test";
            expected = "uNIT tEST";
            //Act
            string output = inputString.ViceVersaConverter();

            //Assert
            Assert.Equal(expected ,output);
        }

        [Fact]
        public void TitleCase()
        {
            //Arrange
            inputString = "unit test";
            expected = "Unit Test";
            //Act
            string output = inputString.TitleCaseConversion();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Capitalized()
        {
            //Arrange
            inputString = "unit test";
            expected = "Unit Test";
            //Act
            string output =inputString.CapitalizedCaseConverter();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void CheckLower()
        {
            //Arrange
            inputString = "unit test";
            expected = "lowerCase";
            //Act
            string output = inputString.LowerCaseChecker();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void CheckUppar()
        {
            //Arrange
            inputString = "UNIT";
            expected = "upparCase";
            //Act
            string output = inputString.UpperCaseChecker();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void CheckforInt()
        {
            //Arrange
            inputString = "100";
            expected = "Success";
            //Act
            string output = inputString.ConverterCheck();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void RemoveLastChar()
        {
            //Arrange
            inputString = "Unit Test";
            expected = "Unit Tes";
            //Act
            string output = inputString.CharacterRemoval();

            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void WordCount()
        {
            //Arrange
            inputString = "Unit Test";
            expected = "2";
            //Act
            string output = inputString.WordCount();

            //Assert
            Assert.Equal(expected, output);
        }


        [Fact]
        public void StringToInt()
        {
            //Arrange
            inputString = "100";
            expected = "100";
            //Act
            string output = inputString.IntegerConverter();

            //Assert
            Assert.Equal(expected, output);
        }
    }
}
