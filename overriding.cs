using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    
        class BC
        {
            public void Display()
            {
                System.Console.WriteLine("BC::Display");
            }
        }

        class DC : BC
        {
            public void Display()
            {
                System.Console.WriteLine("DC::Display");
            }
        }

        class Demo
        {
            static void Main()
            {
                BC b;
                b = new BC();
                b.Display();
            Console.Read();
            }
        }
    }

