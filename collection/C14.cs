using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class C14
    {
        public static void Main(string[] args)
        {
              
            var names = new List<string>();  // // Creating a list of strings
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            //// itereation could have been done by iterating list like this also
            //var names = new List<string>() { "sonu", "Vimal", "Ratan", "Rama" };


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
