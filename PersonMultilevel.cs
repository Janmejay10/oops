using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Man
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
        public class Father : Man
        {
            public void watch()
            {
                Console.WriteLine("Barking...watching T.V");
            }
            public class Child : Father
            {
                public void sleep()
                {
                    Console.WriteLine("sleeping");
                }
            }
            class MultilevelInheritance
            {
                static void Main(string[] args)
                {
                    Child d1 = new Child();
                    d1.eat();
                    d1.watch();
                    d1.sleep();
                    Console.Read();
                }
            }
        }
    }
}
