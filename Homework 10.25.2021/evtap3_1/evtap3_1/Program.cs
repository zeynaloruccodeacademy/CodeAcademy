using System;

namespace _2misli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2mislini tapmaq ucun ededi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            int misli = a * 2;

            Console.Write("Ededin misli:  " + misli);


        }
    }
}