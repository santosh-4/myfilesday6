
using System;
class sa
{
    public static Tuple <int, int, int, int> calci(int a, int b) 
    {
        return new Tuple<int, int, int, int>((a+b), (a*b), (a-b),(a%b));
    }
    static void Main()
    {
        Console.WriteLine("enter the value 1 :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value 2 :");
        int b = Convert.ToInt32(Console.ReadLine());
        Tuple<int, int, int, int> c = sa.calci(a,b);
        Console.WriteLine("------Calculation Operations----");
        Console.WriteLine(" (a)Sum :"+c.Item1+" (b) Multiplication :"+c.Item2+" (c)Division :"+c.Item4+" (d)Sub :"+c.Item3);
    }
}

