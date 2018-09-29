using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class C8<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);  // + can not be performed because T is unknown rightnow
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    class testGenerics
    { 
        static void Main()
        {
            C8<T> obj = new C8<T>();
            obj.Add(10, 20);
            obj.sub(10, 20);
            obj.mul(10, 20);
            obj.div(10, 20);
            Console.Read();
            //here we are calling 4 times so another solution is to pass the T type to class
            // make the class generic
        }
    }
}
