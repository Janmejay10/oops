// private constructor
using System;
namespace oops
{
    class emp4
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

        private emp4()
        { 
            this.EId = 10;
            this.EName = "Jay";
            this.EAddress = "BTM";
            this.EAge = 23;
        }
        

        private void DispData()
        {
            Console.WriteLine("Details are");
            Console.WriteLine("Employee Id is: " + this.EId);
            Console.WriteLine("Employee Name is: " + this.EName);
            Console.WriteLine("Employee Address is: " + this.EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }

        static void Main(string[] args)
        {
            emp4 e1 = new emp4();
            e1.DispData();
            Console.Read();
        }
    }

    
}
