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

        public T this[int index]
        {
            get
            {
                if (index < count && index >=0)
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
       
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public override string ToString()
        {
            //CustomList<T> list = new CustomList<T>();
            string value = "";

            for (int i = 0; i < count; i++)
            {
                value += items[i].ToString();
            }
            return value;
        }

    }
}
