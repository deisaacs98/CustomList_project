using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList_proj;

namespace CustomListUnitTests
{
    //This method will convert the items in the list to a string.
    //This string can be printed to the console, stored in another list, etc..
    //
    [TestClass]
    public class OverrideToStringTest
    {
        [TestMethod]
        public void OverrideToString_CheckIntegerConversion()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            string expected = "1, 2";
            string actual;
            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverrideToString_CheckDoubleConversion()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double firstNumber = 1.5;
            double secondNumber = 2.9;
            string expected = "1.5, 2.9";
            string actual;
            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //This list will check to see that 
        public void OverrideToString_ConvertLargerList_CheckString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string item1 = "Headphones";
            string item2 = "Cup";
            string item3 = "Book";
            string item4 = "Pencil";
            string item5 = "Glasses";
            string expected = "Headphones, Cup, Book, Pencil, Glasses";
            string actual;
            //Act
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Add(item5);
            actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //I'm sure there are other tests I can put here, but
        //I'm not completely sure it is necessary.
        //Will almost certainly write more once I begin
        //writing the ToString overload method.
        //As for now, checking that lists with different
        //data types, counts, and capacities should
        //be sufficient.
    }
}
