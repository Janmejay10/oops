using System;
public class Calculation
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static float add(float a, int b)
    {
        return a + b;
    }
}
public class MemberOverloading
{
    static void Main()
    {
        Console.WriteLine(Calculation.add(12, 23));
        Console.WriteLine(Calculation.add(12.8f,25));
        Console.Read();
    }
}