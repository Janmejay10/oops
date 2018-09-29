using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class C5             // using system.collection.generic
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20);
            li.Add(30); li.Add(40); li.Add(25);
            li.Sort();

            for (int i = 0; i < li.Count; i++)
                Console.Write(li[i] + " ");
            Console.WriteLine();

            li.Insert(3, 45); // at 4th place(index=3) value 45 will be added
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            li.RemoveAt(3); // at 4th place(index=3) will be removed
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.Read();


        }
    }
}
