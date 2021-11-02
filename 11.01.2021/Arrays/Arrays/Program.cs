using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        #region Task 1 Array Resize
        //static void Main(string[] args)
        //{
        //    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    MethodReverseArray(array);

        //}

        //public static void MethodReverseArray(int[] array)
        //{
        //    Array.Reverse(array);
        //    foreach (int item in array)
        //    {
        //        Console.WriteLine(item);
        //    }


        //}
        #endregion

        #region Task 2
        //static void Main(string[] args)
        //{
        //    int[] array_1 = new int[5] { 1, 2, 3, 4, 5 };
        //    int[] array_2 = new int[5] { 6, 7, 8, 9, 0 };

        //    int[] resultArray = new int [array_1.Length + array_2.Length];
        //    array_1.CopyTo(resultArray, 0);
        //    array_2.CopyTo(resultArray, array_1.Length);
        //    Array.Sort(resultArray);
        //    Array.Reverse(resultArray);
        //    foreach (var item in resultArray)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.ReadKey();
        //    

        //}
        #endregion

        #region Task 3

        //static void Main(string[] args)
        //{
        //    int[] a = { 1, 2, 3, 4, 5 };

        //    Console.WriteLine(a.Max());
        //    Console.WriteLine(a.Min());



        //}
        #endregion

        #region Task 4
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] single = Array.FindAll(numbers, item => item % 2 == 1);
            int[] pair = Array.FindAll(numbers, item => item % 2 == 0);
            foreach (var item in single)
            {
               
                Console.Write(item+" ");

            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            foreach (var item in pair)
            {

                Console.Write(item+" ");

            }
        }
        #endregion


    }
}



