using System;

namespace ConsoleApp5
{
    #region Task 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stu1 = new Student();
    //        Student stu2 = new Student();
    //        Student stu3 = new Student();
    //        Student stu4 = new Student();
    //        Student stu5 = new Student();
    //        Student stu6 = new Student();

    //        Student.ShowInstanceCount();

    //    }
    //}
    // class Student
    //{
    //    private static int InstanceCount { get; set; }

    //    public Student()
    //    {
    //        InstanceCount++;
    //    }

    //    public static void ShowInstanceCount()
    //    {
    //        Console.WriteLine("Instance Count: " + InstanceCount);
    //    }
    //}
    #endregion

    #region Task1
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleas enter the number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b.Cub());
        }

    }
    static class Extension
    {
        public static int Cub(this int a)
        {
            if (a == 1) return a;
            for (int i = 0; i <= a / 3; i++)
            {
                if (i * i * i == a)
                {
                    return i;
                }
            }
            return 0;
        }
    }
    #endregion
}
