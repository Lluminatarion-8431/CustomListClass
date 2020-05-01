using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    { 
        /// <summary>
        /// Adding An Object Test Methods
        /// </summary>
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexThree()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);

            // act
            testList.Add(40);

            //assert
            Assert.AreEqual(40, testList[3]);

        }

        [TestMethod]
        public void Add_AddingValueToCustomListThatAlreadyHasValue_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 40;
            int expected = 4;
            int actual;
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddingValueToCustomListThatAlreadyHasValue_AddedValueGoesToLastIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 50;
            int expected = 8;
            int actual;
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);

            // act
            testList.Add(itemToAdd);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Removing An Object Test Methods
        /// </summary>
        [TestMethod]
        public void Remove_RemovingOneValueFromTheCustomList_RemovingAddedValueAtTheIndexOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            int itemToRemove = 20;
            int expected = 30;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingFirstValueFromTheCustomList_CountOfCustomListDecrement()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            int itemToRemove = 10;
            int expected = 2;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingFirstValueFromTheCustomList_ChecksForNextListItem()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            testList.Add(50);
            int itemToRemove = 10;
            int expected = 20;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingLastValueFromTheCustomList_ChecksForNewCapacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            testList.Add(50);
            testList.Add(60);
            int itemToRemove = 50;
            int expected = 8;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);

        }
  
        [TestMethod]
        public void Remove_RemovingLastValueFromTheCustomList_CountOfCustomListDecrement()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            testList.Add(50);
            testList.Add(60);
            int itemToRemove = 60;
            int expected = 5;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList.Count;
             
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingValueNotInTheCustomList_CountOfCustomListStaysTheSame()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            testList.Add(50);
            testList.Add(60);
            int itemToRemove = 1000;
            int expected = 6;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingValueNotInTheCustomList_ListIndexOfCustomListStaysTheSame()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            testList.Add(40);
            int itemToRemove = 1000;
            int expected = 40;
            int actual;

            // act
            testList.Remove(itemToRemove);
            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Overloading +Operator Test Methods
        /// 
        /// </summary>
        [TestMethod]
        public void Add_AddingTwoInstancesOfTheCustomListClass_OverLoadingPlusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> addOperator = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            string expected = "135246";

            // act
            addOperator = testList1 + testList2;
            string actual = addOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Overloading -Operator Test Method
        /// </summary>
        [TestMethod]
        public void Subract_SubtractingTwoInstancesOfTheCustomListClass_OverLoadingMinusOperator()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> minusOperator = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            string expected = "";

            // act
            minusOperator = testList1 - testList2;
            string actual = minusOperator.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Overriding ToString Test Method
        /// </summary>
        [TestMethod]
        public void Override_OverridingToStringMethod_ConvertingCustomListToString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 4;
            int value6 = 6;
            string expected = "135246";
            string actual;
            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Add(value6);
            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Adding Two Instances To A Zipper
        /// </summary>
        [TestMethod]
        public void Zip_ZippingTwoInstancesTogether_OddAndEvenZipper()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> zipList;
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            string expected = "123456";


            // act
            zipList = CustomList<int>.Zip(odd, even);
            // assert
            Assert.AreEqual(expected, zipList.ToString());
        }
    }

}
