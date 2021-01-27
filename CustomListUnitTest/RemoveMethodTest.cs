using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList_proj;

namespace CustomListUnitTests
{

    [TestClass]
    public class RemoveMethodTests
    {
        //How do we know if something has been remoed from the list?
        //Count goes down and all items with index greater than the
        //removed item will have its index decrease by 1.

        [TestMethod]
        public void RemoveItemFromCustomList_CheckCountEquals0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string shoe = "Jordans";
            int actual;
            int expected = 0;

            // Act
            list.Add(shoe);
            list.Remove(shoe);
            actual = list.Count;

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void RemoveItemFromCustomList_CheckForItemAtIndex0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string jersey = "Pippen";
            string expected = null;
            string actual;

            // Act
            list.Add(jersey);
            list.Remove(jersey);
            actual = list[0];

            //Assert

            Assert.AreEqual(expected, actual);
        }

        public void RemoveItemFromCustomList_CheckForItemAtIndex1()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string jersey1 = "Pippen";
            string jersey2 = "Jordan";
            string jersey3 = "Rodman";
            string expected = jersey3;
            string actual;

            // Act
            list.Add(jersey1);
            list.Add(jersey2);
            list.Add(jersey3);
            list.Remove(jersey2);
            actual = list[1];

            //Assert

            Assert.AreEqual(expected, actual);
        }

        //When the list goes from 4 items to 3 items, the capacity should
        //decrease from 8 to 4.
        [TestMethod]

        public void RemoveItemsFromCustomList_DecreaseCapacity()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double price1 = 2.01;
            double price2 = 3.50;
            double price3 = 3.51;
            double price4 = 5.10;
            int expected = 4;
            int actual;

            //Act
            list.Add(price1);
            list.Add(price2);
            list.Add(price3);
            list.Add(price4);
            list.Remove(price1);
            actual = list.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void RemoveItemFromCustomList_RemoveItemIndex1_CheckItemIndex1()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string name1 = "John";
            string name2 = "Paul";
            string name3 = "George";
            string name4 = "Ringo";
            string expected = "George";
            string actual;

            // Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);
            list.Remove(name2);

            actual = list[1];

            // Assert

            Assert.AreEqual(expected, actual);

        }


    }



}