using System;

namespace Assignment2_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.Write("Write your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " welcome! You are " + age + " years old!");
        }
    }
}
