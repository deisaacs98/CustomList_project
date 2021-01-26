using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

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

        [TestMethod]

        public void RemoveItemsFromCustomList_DecreaseCapacity()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double price1 = 2.01;
            double price2 = 3.50;
            double price3 = 3.51;
            double price4 = 5.10;
            double price5 = 
            int capacity1;
            int actual;

            //Act
            list.Add(price1);
            list.Add(price2);
            list.Add(price3);
            list.Add(price4);


            //Assert

        }

    }



}
