using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp2
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

      /*  public emp2()
        {
            this.EId = 10;
            this.EName = "Jay";
            this.EAddress = "BTM";
            this.EAge = 23;
        }
        */
        public void DispData()
        {
            Console.WriteLine("Details are");
            Console.WriteLine("Employee Id is: " + this.EId);
            Console.WriteLine("Employee Name is: " + this.EName);
            Console.WriteLine("Employee Address is: " + this.EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }
    }

    class empSDconstructor
    {
        static void Main(string[] args)
        {
            emp2 e1 = new emp2();
            //  emp2 e2 = new emp2();
            //  emp2 e3 = new emp2();
            e1.DispData();
            //e2.DispData();
            //e3.DispData();           it will give same output due its object to holding same reference
            Console.Read();
        }
    }
}
