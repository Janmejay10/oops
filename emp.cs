using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

        public emp()
        {
            this.EId = 10;
            this.EName = "Jay";
            this.EAddress = "BTM";
            this.EAge = 23;
        }

        public void DispData()
        {
            Console.WriteLine("Details are");
            Console.WriteLine("Employee Id is: " + this.EId);
            Console.WriteLine("Employee Name is: " + this.EName);
            Console.WriteLine("Employee Address is: " + this.EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }
    }

    class empUDconstructor
    {
        static void Main(string[] args)
    {
            emp e1 = new emp();
          //  emp e2 = new emp();
          //  emp e3 = new emp();
            e1.DispData();
            //e2.DispData();
            //e3.DispData();
            Console.Read();
    }
    }
}
