using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter a second number: ");
            string input2 = Console.ReadLine();
            //convert input to double
            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            double sum = Add(num1, num2);
            double difference = Subtract(num1, num2);
            double product = Multiply(num1, num2);
            double quotient = Divide(num1, num2);
            
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is {difference}");
            Console.WriteLine($"The product of the numbers is {product}");
            Console.WriteLine($"The quotient of the numbers is {quotient}");

            Console.ReadLine();

        }
        static double Add(double num1, double num2) //addition method
        { return num1 + num2; }
        static double Subtract(double num1, double num2) //subtraction method
        { return num1 - num2; }
        static double Multiply(double num1, double num2) //multiplication method
        { return num1 * num2; }
        static double Divide(double num1, double num2) //division method
        {
            if (num2 == 0) //can't divide with 0
            {
                Console.WriteLine("Can't divide by zero.");
                return 0;
            }
            return num1 / num2; }
        
    }
}
