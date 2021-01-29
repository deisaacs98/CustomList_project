using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList_proj;

namespace CustomListUnitTests
{
    [TestClass]
    public class SortMethodTest
    {
        [TestMethod]
<<<<<<< HEAD
        public void SortList_Integer_CheckOrder()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number1 = 3;
            int number2 = 1;
            int number3 = 6;
            int number4 = 2;
            int number5 = 4;
            int number6 = 7;
            int number7 = 5;

            string expected = "1 2 3 4 5 6 7 ";
            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            list.Add(number5);
            list.Add(number6);
            list.Add(number7);

            list.Sort();
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortList_Double_CheckOrder()
=======
        public void SortList_Integer()
        {

        }
        [TestMethod]
        public void SortList_Double()
>>>>>>> 576a25577522da541dfb022f6787417586837070
        {
            //Arrange
            CustomList<double> list = new CustomList<double>();
            double number1 = 3;
            double number2 = 6.34;
            double number3 = 6.33;
            double number4 = 2.3;
            double number5 = 32.3;
            double number6 = 23.321;
            double number7 = 10.09;
            double number8 = 9.3;
            double number9 = 6.35;
<<<<<<< HEAD
            string expected = "2.3 3 6.33 6.34 6.35 9.3 10.09 23.321 32.3 ";
=======
            string expected ="2.3 3 6.33 6.34 6.35 9.3 10.09 23.321 32.3";
>>>>>>> 576a25577522da541dfb022f6787417586837070
            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            list.Add(number5);
            list.Add(number6);
            list.Add(number7);
            list.Add(number8);
            list.Add(number9);
            list.Sort();
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
<<<<<<< HEAD
        public void SortList_String_CheckOrder()
=======
        public void SortList_String()
>>>>>>> 576a25577522da541dfb022f6787417586837070
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string name1 = "Homer";
            string name2 = "Marge";
            string name3 = "Bart";
            string name4 = "Lisa";
            string name5 = "Maggie";

            string expected = "Bart Homer Lisa Maggie Marge ";
            //Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);
            list.Add(name5);
            list.Sort();
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
<<<<<<< HEAD
        public void SortList_Integer_CheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int number1 = 3;
            int number2 = 1;
            int number3 = 6;
            int number4 = 2;
            int number5 = 4;
            int number6 = 7;
            int number7 = 5;

            int expected = 7;
            //Act
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            list.Add(number5);
            list.Add(number6);
            list.Add(number7);

            list.Sort();
            int actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
=======
        public void SortList()
        {
            //Arrange

            //Act

            //Assert

>>>>>>> 576a25577522da541dfb022f6787417586837070
        }
    }
}
