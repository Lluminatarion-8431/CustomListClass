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
        List<testList> testLists;

        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
            items.add();
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            return 10;
        }
    }
}
