using System;

namespace evtap55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int u = b;
            for (int r = 0; r < u; r++)
            {
                for (int t = 0; t < b; t++)
                {
                    Console.Write(a);
                }

                Console.WriteLine();
                b--;
            }

        }    
    }
}
