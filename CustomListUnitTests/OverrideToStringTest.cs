using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

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
            string expected = "2";
            string actual;


            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            list.ToString[1] = actual;


            //Assert

            Assert.AreEqual(expected,actual);
        }
    }
}
