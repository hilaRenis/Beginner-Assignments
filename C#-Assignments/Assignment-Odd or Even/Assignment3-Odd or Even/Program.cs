using System;

namespace Assignment3_Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Put the number here: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
