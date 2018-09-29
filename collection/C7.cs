using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class C7
    {
        public bool compare<T>(T a, T b) // using generics here
                                               // then again i have to define one more method for float
        {
            if (a.Equals(b))               // == can be performed because T is unknown.
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static void Main(string[] args)
        {
            C7 obj = new C7();

            //  bool result1 = obj.compare<float>(10.5f, 20.5); // here it is showing the error immediately
            bool result1 = obj.compare<float>(10.5f, 20.5f); // hence it is type safe
            Console.WriteLine(result1);                     
            bool result2 = obj.compare<int>(10, 20);
            Console.WriteLine(result2);
            Console.Read();
            // second this doesn't require boxing and unboxing
            

        }
    }
}
