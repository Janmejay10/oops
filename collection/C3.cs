using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class C3        // using hashtable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 101);
            ht.Add("Eadd", "btm");
            ht.Add("Ename", "Jay");
            ht.Add("Dname", "software developing");
            ht.Add("location", "white field");
            ht.Add("floor", 3);

            Console.WriteLine(ht["Eadd"]); // only object key will tell you the info
            

            foreach (object key in ht.Keys)    // by this we will get all the keys 
                Console.WriteLine(key);

            Console.WriteLine();

            foreach (object key in ht.Values)
                Console.WriteLine(key);

            foreach (object key in ht.Values)
                Console.WriteLine(key + ":" + ht[key]);
            Console.Read();

        }
    }
}
