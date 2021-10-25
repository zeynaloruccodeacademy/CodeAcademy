using System;

namespace evtap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emeliyyati daxil edin  +,-,*,/");
            string emeliyyat = Console.ReadLine();

            Console.WriteLine("Birinci ededi daxil edin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin: ");
            int y = Convert.ToInt32(Console.ReadLine());
   
            
            if (emeliyyat == "+")
            {
                int z = x + y;

                Console.Write("Ededlerin cemi:"  + z);

            }

            else if (emeliyyat == "/")
            {
                int z = x / y;

                Console.WriteLine("Ededlerin qismeti", z);
            }
            else if (emeliyyat == "-")
            {
                int z = x - y;

                Console.Write("Ededlerin ferqi:"  + z);
            }

            

            else if (emeliyyat== "*")
            {
                int z = x * y;

                Console.Write("Ededlerin hasili:"  + z);

            
                
            } 

        }   

    }
}
