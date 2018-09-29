using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    
    
        public class C10
        {
            public int CustId { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public double Balance { get; set; }
        }
    
    class TestCustomer
    {
        static void Main()
        {
            List<C10> Customers = new List<C10>(); // C10 is a ew user defined type
            C10 c1 = new C10 { CustId = 101, Name = "jay", City = "Hydrabad", Balance = 25000 };
            C10 c2 = new C10 { CustId = 102, Name = "sanjay", City = "banngalore", Balance = 30000 };
            C10 c3 = new C10 { CustId = 105, Name = "rudra", City = "delhi", Balance = 50000 };
            C10 c4 = new C10 { CustId = 106, Name = "shekhar", City = "patna", Balance = 20000 };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);
            
            foreach(C10 obj in Customers)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.City +
                                  " " + obj.Balance + " " );
            }
            Console.Read();
        }
    }
}
