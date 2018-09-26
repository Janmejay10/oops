﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor fired");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor fired");
        }
    }
    class TestDestructor
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.Read();
        }
    }
}
