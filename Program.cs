using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int intValue = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a double: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a float: ");
            float floatValue = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter a string: ");
            string stringValue = Console.ReadLine();

            Console.WriteLine("\nYour values: ");
            Console.WriteLine($"Integer: {intValue}");
            Console.WriteLine($"Double: {doubleValue}");
            Console.WriteLine($"Float: {floatValue}");
            Console.WriteLine($"String: {stringValue}");

            Console.WriteLine("\nExplanations: ");
            Console.WriteLine("Int: Heltal utan decimaler");
            Console.WriteLine("Double: 64-bit decimal tal, mer precis än float");
            Console.WriteLine("Float: 32-bit decimal tal");
            Console.WriteLine("String: text");

            
            Console.ReadLine();
        }
    }
}
