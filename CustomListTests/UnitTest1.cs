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
        public void Creation()
            //should check the size of the stack is 0 at the beginning
        {
            // arrange
            Stack<int> s = new Stack<int>(3);

            // act

            // assert
            Assert.AreEqual(0, s.Size);
        }
        //should take the last expected element out and decrease the size of the stack
        [TestMethod]
        public void Push_Pop()
        {
            // arrange
            Stack<int> s = new Stack<int>(3);

            // act
            s.Push(1);
            s.Push(2);
            s.Push(3);

            // assert
            int value = s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }

        // error when trying to access an empty list
        [TestMethod]
        public void Too_Much_Pop()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
        }

        // error when list is full and attempt to add to it
        [TestMethod]
        public void Too_much_Push()
        {
            // arrange
            Stack<int> s = new Stack<int>(3);

            // act
            s.Push(1);
            s.Push(2);
            s.Push(3);
            // assert
            Assert.Throws<ExceededSizeException>(() => s.Push(4));
        }
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?


    }
}
