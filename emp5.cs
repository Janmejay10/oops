using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class emp5
    {
        int EId;
        string EName;
        string EAddress;
        int EAge;

        public emp5()
        {
            this.EId = 10;
            this.EName = "Jay";
            this.EAddress = "BTM";
            this.EAge = 23;
        }

        public emp5(emp5 e)
        {
            this.EId = e.EId;
            this.EName = e.EName;
            this.EAddress = e.EAddress;
            this.EAge = e.EAge;
        }

        private void DispData()
        {
            Console.WriteLine("Details are");
            Console.WriteLine("Employee Id is: " + this.EId);
            Console.WriteLine("Employee Name is: " + this.EName);
            Console.WriteLine("Employee Address is: " + this.EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }

        class encapCopyConstructor
        {
            static void Main(string[] args)
            {
                emp5 e1 = new emp5();
                emp5 e2 = new emp5(e1);
                e1.DispData();
                e2.DispData();
                Console.Read();

            }
        }
    }
}
