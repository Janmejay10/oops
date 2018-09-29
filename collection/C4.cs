using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class C4             // we can have array of elements having different datatypes
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); 
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add("Jay");
            al.Add(true);
            al.Add(25.6);
            Console.WriteLine(al.Capacity);
            al.Add('P');
            foreach (object obj in al)
                Console.Write(obj + " ");   // for priting the values
            Console.WriteLine();

            Console.Read();
        }
    }
}
