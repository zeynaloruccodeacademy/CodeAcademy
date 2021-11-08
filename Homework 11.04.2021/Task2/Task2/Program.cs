using System;

namespace Task2
{
    class Program
    {
        #region Task2
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.MethodCar();
        }

    }
    public interface IVehicle
    {
        void MethodCar();
    }
    public class Car : IVehicle
    {
        public void MethodCar()
        {
            Console.WriteLine("Car is driving...");
        }
        #endregion
    }


}
