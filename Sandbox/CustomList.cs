using System;
using System.IO;
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

        //As a developer, I want to be able to override the ToString() method//
        // that converts the contents of the custom list to a string.//
        public override string ToString()
        {
            
            string value = "";

            for (int i = 0; i < count; i++)
            {
                value += items[i].ToString();
            }
            return value;
        }
        //As a developer, I want to be able to overload the + operator,//
        //so that I can add two instances of the custom list class together.//
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                list.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                list.Add(list2[i]);
            }
            return list;
        }
        //I want to be able to overload the – operator, so that I can subtract one instance//
        //of a custom list class from another instance of a custom list class.//
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();
            list = list1 + list2;

            for (int i = 0; i < list1.count; i++)
            {
                list.Remove(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                list.Remove(list2[i]);
            }
            return list;
        }
        // what if the list is not the same size
        public static CustomList<T> Zip(CustomList<T>odd, CustomList<T>even)
        {
            int i = 0;
            CustomList<T> zipList = new CustomList<T>();

            do
            {
                if (i + 1 <= odd.count)
                {
                    zipList.Add(odd[i]);
                }
                if (i + 1 <= even.count)
                {
                    zipList.Add(even[i]);
                }
                i++;
            }
            while ((i + 1 <= odd.count) || (i + 1 <= even.count));

            return zipList;
        }
        //static async Task WriteFileAsync(string dir, string file, string content)
        //{
        //    Console.WriteLine("Async Write File has started");
        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(dir, file)) )
        //    {
        //        await outputFile.WriteAsync(content);
        //    }
        //    Console.WriteLine("Async Write File has completed");
        //}
        
    }
}

