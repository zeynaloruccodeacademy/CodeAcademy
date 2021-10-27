using System;

namespace metod_2
{
    class Program
    {
        
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Write("1-ci eded : ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2-ci eded : ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (x < y)
                    {
                        Console.WriteLine($"{x} ve {y} araliqdaki ededlerin cemi {ara(x, y)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nbirinci eded ikinci ededden kicik olmalidir\n");
                    }
                }


            }
            static int ara(int x, int y)
            {
                int sum = 0;
                for (; x <= y; x++)
                {
                    sum = sum + x;
                }
                return sum;
            }
       
    }
}
