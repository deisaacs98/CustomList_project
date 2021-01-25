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

        //When we add an item to our, we can assume the data type stays the same.
        //However, it may be wise to double check this.
        //For example, we don't want to add an integer to a list and have it
        //convert to a double.
        //This test should verify that if an integer is added, the item at the
        //corresponding index should also be an integer.
        [TestMethod]

        public void AddItemsToCustomList_CheckDataTypeOfInteger()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 10;
            int actual;
            string expected = "Int 32";
            // Act
            list.Add(value);
            actual = list[0].GetType().Name;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        //Get an error code saying that the data type conflicts with others in list.
        //Will need to add list of status codes that can be returned.
        //Method will not need to return value to function, but may be used for testing.
        [TestMethod]

        public void AddItemsToCustomList_AddConflictingDataType_GetStatus1()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int value= 91;
            string name = "Rodman";
            int actual;
            int expected = 1;
            // Act
            list.Add(value);
            actual = list.Add(name);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemsToCustomList_IncreaseCapacity
        {

        }
    }
}
