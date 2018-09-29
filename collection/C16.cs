using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class C16
    {
        public static void Main(string[] args)
        {
             
            var numbers = new SortedSet<int>();
            numbers.Add(87);
            numbers.Add(54);
            numbers.Add(68);
            numbers.Add(78);
            numbers.Add(12); 

             
            foreach (var name in numbers)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
