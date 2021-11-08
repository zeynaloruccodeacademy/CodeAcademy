using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            
            Console.Write("Enter dog name: ");
            string DogName = Console.ReadLine();
            dog1.SetName(DogName);
            Console.WriteLine(dog1.GetName());
            dog1.Eat();
        }
    }

    public abstract class Animal
    {
        public string _Name { get; set; }
        public string SetName(string name)
        {
           return this._Name = name;
        }
        public string GetName()
        {
            return this._Name;
        }
        abstract public void Eat();
    } 
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    
}
