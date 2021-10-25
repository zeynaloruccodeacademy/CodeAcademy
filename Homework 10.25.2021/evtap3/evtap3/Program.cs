using System;

namespace cevreperimetr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cevrenin radisunu daxil edin:");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;

            Console.WriteLine("Perimetr - P, Sahe - S");
            string emeliyyat = Console.ReadLine();
            switch (emeliyyat)
            {
                case "P":

                    double perimetr = 2 * pi * r;

                    Console.WriteLine("Cevrenin perimetri: " + perimetr);
                    break;

                case "S":

                    double sahe = pi * (r * r);
                    Console.WriteLine("Cevrenin sahesi: " + sahe);
                    break;


            }

        }
    }
}
