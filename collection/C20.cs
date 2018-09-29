using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class C20                                 // adding elements after specific node
    {
        public static void Main(string[] args)
        {
             
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

              
            LinkedListNode<String> node = names.Find("Peter");//insert new element before peter
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

             
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
