using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int count;
        private int capacity;

        // constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // member methods (CAN DO)

        //I want the ability to add an object//
        //to an instance of my custom-built list//
        //class by imitating the C# Add() method.//
        public void Add(T item)
        {
            items[count] = item;
            count++;
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
        }
        //I want the ability to remove an object from an//
        //instance of my custom-built list class by//
        //imitating the C# Remove() method.//
        public void Remove(T item)
        {
            T[] tempArray = new T[capacity];
            bool hasFound = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) && hasFound == false)
                {
                    hasFound = true;
                    count--;
                }

                if (hasFound == true)
                {

                    tempArray[i] = items[i + 1];
                }
                else
                {
                    tempArray[i] = items[i];
                }
            }
            items = tempArray;
        }
        
        //I want to create a C# indexer so that I can make the//
        //objects in my list accessible via index. I want to properly//
        //ensure that a user cannot access an out-of-bounds index.//
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }
        //I want a Capacity property implemented on the custom-built//
        //list class, so that I can publicly see the size of my private array.//
        public int Count
        {
            get
            {
                return count;
            }
        }
        //I want a Capacity property implemented on the custom-built list class,//
        //so that I can publicly see the size of my private array.//
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        
        
    }
}

