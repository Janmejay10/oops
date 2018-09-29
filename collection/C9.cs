using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class C9
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 101);
            dt.Add("Eadd", "btm");
            dt.Add("Ename", "Jay");
            dt.Add("Dname", "software developing");
            dt.Add("location", "white field");
            dt.Add("floor", 3);

            foreach (string key in dt.Keys)
                Console.WriteLine(key +" :" + dt[key]);
            Console.Read();
        }
    }
}
