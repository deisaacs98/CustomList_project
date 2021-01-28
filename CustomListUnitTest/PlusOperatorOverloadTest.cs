using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList_proj;

namespace CustomListUnitTests
{

    [TestClass]
    public class PlusOperatorOverloadTest
    {
        [TestMethod]
        public void OverloadPlusOperator_AddTwoArrays_CheckIndex3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 4;
            int actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 + list2;
            actual = list[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddThreeLists_CheckIndex4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 5;
            int actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list2.Add(num3);
            list2.Add(num4);
            list3.Add(num5);
            list3.Add(num6);
            list = list1 + list2 + list3;
            actual = list[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //So far have only tested lists of equal size.
        //Let's test adding a larger list...
        [TestMethod]
        public void OverloadPlusOperator_AddLargerList_CheckIndex3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 4;
            int actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list2.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 + list2;
            actual = list[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddSmallerList_CheckIndex5()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> list3 = new CustomList<double>();
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;
            double num4 = 4;
            double num5 = 5;
            double num6 = 6;
            double expected = 6;
            double actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list1.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 + list2;
            actual = list[5];
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 6;
            int actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 + list2;
            actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int expected = 6;
            int actual;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 + list2;
            actual = list.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
