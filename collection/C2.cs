using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class C2               
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); 
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(500);
            al.Add(600);
            Console.WriteLine(al.Capacity);
            al.Add(400);
            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
                Console.Write(obj + " ");   // for priting the values
            Console.WriteLine();
            al.Insert(3, 350);               // for inserting the values in middle

            foreach (object obj in al)
                Console.Write(obj + " ");   // for priting the new  values list
            Console.WriteLine();

            al.Remove(400);               // for removing value/item
            foreach (object obj in al)
                Console.Write(obj + " ");   // for priting the new  values list
            Console.WriteLine();

            al.RemoveAt(1);               // for removing value/item by index
            foreach (object obj in al)   // sp the value at index 1 will be removed
                Console.Write(obj + " ");   // for priting the new  values list
            Console.WriteLine();




            Console.Read();
        }
    }
}
