using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci ededi daxil edin");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci eded: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test1(x,y));







        }
        static string Test1(int x, int y)
        {

            string k = ($"{x} and {y} ededlerinin toplami {x+y}, hasili {x*y}");
            return k;



        }
    } 
}
