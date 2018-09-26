using System;
public class BaseUsing
{
   public string UrName = "Janmejay";
}
public class child : BaseUsing
{
   string UrName = "Rudra";
    public void show()
    {
        Console.WriteLine(base.UrName);
        Console.WriteLine(UrName);
    }

}
public class TestBase
{
    static void Main()
    {
        child d = new child();
        d.show();
        Console.Read();
    }
}