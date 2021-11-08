using System;

namespace ClassLibraryProject
{
    public class ClassLibraryTasks
    {
        public void Method1()
        {
            Console.WriteLine("Ededin sade ve ya murekkeb oldughunu tapan proqram");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("--------------------");
            }

            Console.Write("Ededi daxil edin: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int control = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    control++;
                }
            }
            if (control > 1)
            {
                Console.WriteLine("Eded Murekkebdir");
            }
            else
            {
                Console.WriteLine("Eded Sadedir");
            }
        }
        public void Method2()
        {
            Console.WriteLine("Enter correct result");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("--------------------");
            }
            Random random1 = new Random();
            Random random2 = new Random();


            
            
            int eded1 = random1.Next(1, 50);
            int eded2 = random2.Next(1, 50);
            int result = eded1 + eded2;

            Console.Write($"{eded1}+{eded2}= ");
            int z = Convert.ToInt32(Console.ReadLine());
            if (eded1 + eded2 == z)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
