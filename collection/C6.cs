using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class C6
    {
        public bool compare(object a, object b)// used object bcz if i want to compare a float value
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
            C6 obj = new C6();
          //  bool result = obj.compare(10, 20); it is also possible
           // bool result = obj.compare(10.5, 20.5); its is also possible
            //  bool result = obj.compare(true, true); it is also possible
            //  bool result = obj.compare(true, false); it is also possible
            bool result = obj.compare(10.5f, 20.5); // here it will be allowed so it is not type safe
            Console.WriteLine(result);
            Console.Read();
          //  solution of this problem don in next progam
                
        }
    }
}
