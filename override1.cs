using System;


namespace oops
{
    class override1
    {
      public  void test(int i)
        {
            Console.WriteLine("from parent class");
        }
    }

    class override2 : override1
    {
	void test(int i)

    {
            Console.WriteLine("from child class");
        }


    static void main(String[] args)
    {
        override2 obj = new override2();
        obj.test(10);
        Console.WriteLine("done");
        Console.Read();
    }
}

}
