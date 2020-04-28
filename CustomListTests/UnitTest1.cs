using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
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
        [TestMethod]
        public void Remove_RemovingOneValueFromTheCustomList_RemovingAddedValueInTheIndex()
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
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?
    }

}
