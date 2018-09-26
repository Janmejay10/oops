using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class encap1
    {
        
        
            int EId;
            string EName;
            string EAddress;
            int EAge;

            public void GetData()
            {
                Console.WriteLine("Enter the details");
                this.EId = Convert.ToInt32(Console.ReadLine()); // this is optional here
                this.EName = Console.ReadLine();
                this.EAddress = Console.ReadLine();
                this.EAge = Convert.ToInt32(Console.ReadLine());

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

    class clsEncapsulate
    {
        static void Main(string[] args)
        {
            encap1 obj1 = new encap1();
            obj1.GetData();
            obj1.DispData();
            Console.Read();
        }
    }

}
