using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class C15
    {
        public static void Main(string[] args)
        {
             
            var names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");    //will not be added because it doesnot allow duplicates 
             /* could hav been  done by var names =
              * new HashSet<string>(){"Sonoo", "Ankit", "Peter", "Irfan"}; also*/

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
