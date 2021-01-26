using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace CustomListUnitTests
{
    [TestClass]
    public class AddMethodTests
    {

        // How do we know we've successfully added something to our CustomList?
        // Count goes up when we add?
        // test that the item was added to the right index (indexes outside of zero)
        // test for different types of data working correctly

        [TestMethod]
        public void AddItemToCustomList_CheckCountEquals1()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string shoe = "Jordans";
            int actual;
            int expected = 1;

            // Act
            list.Add(shoe);
            actual = list.Count;

            //Assert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Pippen";
            string actual;

            // Act
            list.Add(expected);
            actual = list[0];

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemsToCustomList_CheckForItemAtIndex3()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string name1 = "Stephon";
            string name2 = "Marbella";
            string name3 = "JT";
            string name4 = "Rob";
            string expected = "Rob";
            string actual;

            // Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);

            actual = list[3];

            // Assert

            Assert.AreEqual(expected, actual);

        }

        //Since our list is a modified array, we will need to change
        //the size of the array each time we add or remove an item
        //if the capacity equals the count.
        //This test will check that the capacity increases when
        //necessary.
        [TestMethod]

        public void AddItemsToCustomList_IncreaseCapacity()
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double price1 = 2.01;
            double price2 = 3.50;
            double price3 = 3.51;
            double price4 = 5.10;
            int expected = 8;
            int actual;

            //Act
            list.Add(price1);
            list.Add(price2);
            list.Add(price3);
            list.Add(price4);
            actual = list.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        //When we add an item to the list,
        //we need to check that the items previously
        //added to the list remain.

        [TestMethod]

        public void AddItemToCustomList_AddItemIndex3_CheckItemIndex2()
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

            actual = list[2];

            // Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
