using System;
public class evtap2
{
    public static void Main()
    {
        int a, sum = 0;

        Console.Write("Find the sum of first 10 natural numbers:\n");
        Console.Write("\n\n");

        Console.Write("The first 10 natural number are :\n");
        for (a = 1; a <= 10; a++)
        {
            sum = sum + a;
            Console.Write("{0} ", a);
        }
        Console.Write("The Sum is : {0}", sum);
    }
}