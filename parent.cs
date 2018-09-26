using System;

namespace oops
{
    class parent
    {
        public void weight()
        {
            Console.WriteLine("knowing about parent's weight");
        }
    }

    class child : parent
    {
        public void weight()
        {
            base.weight();
            Console.WriteLine("knowing about child's weight");
        }
    }
    class priority2Base
    {
        static void Main(string[] args)
        {
            child d1 = new child();
            d1.weight();
            Console.Read();
        }
    }
}
