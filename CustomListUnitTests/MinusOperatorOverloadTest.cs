using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace CustomListUnitTests
{
    
    [TestClass]
    public class MinusOperatorOverloadTest
    {
        
        [TestMethod]
        public void OverloadMinusOperator_SubtractList_CheckIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;
            int num5 = 2;
            int num6 = 6;
            int expected = 3;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 - list2;
            actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_SubtractList_CheckIndex1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;
            int num5 = 5;
            int num6 = 6;
            int expected = 3;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 - list2;
            actual = list[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_SubtractListFromIdenticalList_CheckIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;
            int num5 = 2;
            int num6 = 3;
            int expected = null;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list2.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 - list2;
            actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_SubtractNonMatchingList_CheckCount()
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
            int expected = 3;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list2.Add(num3);
            list2.Add(num4);
            list3.Add(num5);
            list3.Add(num6);
            list = list1 - list2;
            actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_SubtractListWithDuplicates_CheckIndex0()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;
            int num5 = 1;
            int num6 = 1;
            int expected = 2;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list2.Add(num3);
            list2.Add(num4);
            list3.Add(num5);
            list3.Add(num6);
            list = list1 - list2;
            actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void OverloadMinusOperator_SubtractList_CheckCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 1;
            int num6 = 2;
            int expected = 4;
            //Act
            list1.Add(num1);
            list1.Add(num2);
            list1.Add(num3);
            list1.Add(num4);
            list2.Add(num5);
            list2.Add(num6);
            list = list1 - list2;
            actual = list.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
