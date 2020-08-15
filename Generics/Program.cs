using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> type = new GenericList<int>();
            type.AddItem(3);
            type.AddItem(2);
            type.AddItem(0);
            type.AddItem(1);
            Console.WriteLine(type.GetItem(2));
            foreach(int item in type.GetSortedList())
            {
                Console.WriteLine(item);
            }
        }
    }

    class GenericList<T> where T:struct
    {
        private List<T> list;
        public GenericList()
        {
            list = new List<T>();
        }
        public void AddItem(T t)
        {
            list.Add(t);
        }

        public T GetItem(int pos)
        {
           return list[pos];
        }
        public List<T> GetSortedList()
        {
            return list.OrderByDescending(t => t)
                .ToList();
        }
    }
}
