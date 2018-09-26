using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class InBranch
    {
        int BCode;
        string BName;
        string BAddress;
        public void GetBranchData()
        {
            Console.WriteLine("enter Brach details");
            this.BCode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }

        public void DispBranchData()
        {
            Console.WriteLine("Branch details are:-");
            Console.WriteLine("Branch code is : " + this.BCode);
            Console.WriteLine("Branch name is : " + this.BName);
            Console.WriteLine("Branch address is : " + this.BAddress);
        }
    }
    class InChildemp : InBranch
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

        public void GetEmpData()
        {
            Console.WriteLine("Enter the employee details");
            this.EId = Convert.ToInt32(Console.ReadLine()); 
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public void DispEmpData()
        {
            Console.WriteLine(" Employee Details are");
            Console.WriteLine("Employee Id is: " + this.EId);
            Console.WriteLine("Employee Name is: " + this.EName);
            Console.WriteLine("Employee Address is: " + this.EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }
        

    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            InChildemp e1 = new InChildemp();
            e1.GetBranchData();
            e1.GetEmpData();
            e1.DispBranchData();
            e1.DispEmpData();
            Console.Read();
        }
    }


}
