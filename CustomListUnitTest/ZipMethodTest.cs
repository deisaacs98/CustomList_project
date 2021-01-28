using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList_proj;

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
            CustomList<int> zipList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 1;
            int actual;
            //Act
            list.Add(firstNumber);
            zipList.Add(secondNumber);
            list.Zip(zipList);
            actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);

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
            list.Add(firstNumber);
            zipList.Add(secondNumber);
            list.Zip(zipList);
            actual = list[1];
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ZipLists_DifferentSizeLists_CheckItemAtIndex3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int fourthNumber = 4;
            int fifthNumber = 5;
            int expected = 4;
            int actual;
            //Act
            list.Add(firstNumber);
            list.Add(secondNumber);
            zipList.Add(thirdNumber);
            zipList.Add(fourthNumber);
            zipList.Add(fifthNumber);
            list.Zip(zipList);
            actual = list[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipLists_DifferentSizeLists_CheckItemAtIndex2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            CustomList<string> zipList = new CustomList<string>();
            string name1 = "John";
            string name2 = "Eric";
            string name3 = "Terry";
            string name4 = "Graham";
            string name5 = "Michael";
            string expected = "Terry";
            string actual;
            //Act
            list.Add(name1);
            zipList.Add(name2);
            list.Add(name3);
            zipList.Add(name4);
            zipList.Add(name5);
            list.Zip(zipList);
            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipLists_DifferentSizeLists_CheckCount()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            CustomList<string> zipList = new CustomList<string>();
            string name1 = "John";
            string name2 = "Eric";
            string name3 = "Terry";
            string name4 = "Graham";
            string name5 = "Michael";
            int expected = 5;
            int actual;
            //Act
            list.Add(name1);
            zipList.Add(name2);
            list.Add(name3);
            zipList.Add(name4);
            zipList.Add(name5);
            list.Zip(zipList);
            actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipLists_SameSizeLists_CheckCapacity()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            CustomList<double> zipList = new CustomList<double>();
            double price1 = 1.01;
            double price2 = 1.20;
            double price3 = 2.01;
            double price4 = 100.30;
            double price5 = 1251.13;
            double price6 = 17.24;
            double price7 = 19.99;
            double price8 = 12.40;
            double expected = 8;
            //Expected to be 16 here. This is because each list has a count of 4,
            //which requires that each capacity must equal 8.
            double actual;
            //Act
            list.Add(price1);
            zipList.Add(price2);
            list.Add(price3);
            zipList.Add(price4);
            list.Add(price5);
            zipList.Add(price6);
            list.Add(price7);
            zipList.Add(price8);
            list.Zip(zipList);
            actual = list.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
