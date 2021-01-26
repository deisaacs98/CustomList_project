using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace CustomListUnitTests
{
    [TestClass]
    public class ZipMethodTest
    {
        //The Zip method will eventually take in another list and
        //"zip" the two together as follows:
        //List 1: 1 , 3 , 5
        //List 2: 2 , 4 , 6
        //List 1 Zipped With List 2: 1, 2, 3, 4, 5, 6

        //Will need to check that the first two values are accurate.
        //First number should equal first item in list.
        //Second number should equal second item in
        //list that has been passed through
        [TestMethod]
        public void ZipLists_CheckItemAtIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 
            //Act
            list.Zip(zipList)
            //Assert


        }
        [TestMethod]
        public void ZipLists_CheckItemAtIndex1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 2;
            int actual;
            //Act
            list.Add()
            list.Zip(zipList);
            actual = list[1];
            //Assert
            Assert.AreEqual(expected,actual);

        }
    }
}
