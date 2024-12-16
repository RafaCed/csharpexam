using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bob", "Steve", "Nina" }; // first array
            int[] numbers = { 5, 57, 87, 1, 150, 32, 14 }; // second array
            // loops through the names and adds "Goodbye" before the name
            foreach (string name in names)
            {
                Console.WriteLine($"Goodbye {name}"); //goodbye message
            }
            // number array sorting
            Array.Sort( numbers );
            int[] newNumbers = new int[numbers.Length - 1];
            Array.Copy(numbers, newNumbers, newNumbers.Length);

            Console.WriteLine("\nSorted numbers: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
            
            Console.ReadLine();
        }
    }
}
