using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            double number;

            if (double.TryParse(input, out number))
            {
                if (number > 0) //checks if input is positive
                {
                    Console.WriteLine("The number is positive. ");
                }
                else if (number < 0) // checks if input is negative
                {
                    Console.WriteLine("The number is negative. ");
                }
                else // checks if input is zero
                {
                    Console.WriteLine("The number is zero. ");
                }
            }
            else // invalid input message
            {
                Console.WriteLine("Invalid input. ");
            }





            Console.ReadLine();
        }
    }
}
