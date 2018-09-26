using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp6
    {
        int i;
        static int j;

        public emp6()
        {
            i = 10;
            j = 20;     // it is allowed but it will looose its static nature here.
        }

        static emp6()
        {
       //     i = 30;     this is not allowed because static cannot in initialize data into non- static fields.
            j = 40;

        }

        public void DispData()
        {
            Console.WriteLine("the value of i is: " + i);
            i++;
            Console.WriteLine("the value of j is: " + j);
            j++;
        }
        class StaticConstructor
        {
            static void Main(string[] args)
            {
                emp6 e1 = new emp6();
                emp6 e2 = new emp6();
                emp6 e3 = new emp6();
                e1.DispData();
                e2.DispData();
                e3.DispData();
                Console.Read();
            }

                
        }
    }
}
