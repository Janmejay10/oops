using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp3
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

        public emp3(int id, string s1, string s2, int age)
        {
            this.EId = id;
            this.EName = s1;
            this.EAddress = s2;
            this.EAge = age;
        }
        public emp3()
        {
            this.EId = 14;
            this.EName = "Janmejay";
            this.EAddress = "BTM";
            this.EAge = 23;
        }
        public emp3(int id, string s1)
        {
            this.EId = 12;
            this.EName = "Janmejay";
            
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

    class empParaconstructor
    {
        static void Main(string[] args)
        {
            emp3 e1 = new emp3(10, "Jay", "BTM", 23 );
            emp3 e2 = new emp3(15, "Saurabh", "White Field", 23);
            emp3 e3 = new emp3();
            emp3 e4 = new emp3(18, "Janmejay");
            e1.DispData();
            e2.DispData();
            e3.DispData();
            e4.DispData();
            Console.Read();         // this is a perfect example of constructor overloading
        }
    }
}
