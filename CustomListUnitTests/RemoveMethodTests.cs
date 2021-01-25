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
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]

        public void RemoveItemFromCustomList_ItemNotInList_GetStatus1()
        {
            //Arrange

            //Act

            //Assert
        }


    }

    

}
