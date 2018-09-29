using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class C19
    {
        public static void Main(string[] args)
        {
              
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");       // here we are addeing value to first index  

              
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
