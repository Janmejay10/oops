using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class C1                //using ArrayList as an Array
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); // ArrayList al = new ArrayList(10); also a parameter
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); 
            al.Add(500);
            al.Add(600);
            Console.WriteLine(al.Capacity);
            al.Add(400);

            Console.Read();
        }
    }
}
