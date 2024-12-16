using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Words = new Dictionary<string, string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Add a word. ");
                Console.WriteLine("2. Remove a word. ");
                Console.WriteLine("3. Show all words.");
                Console.WriteLine("4. Exit.");
                Console.Write("Choose an option 1-4: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddWord(Words);
                        break;
                    case "2":
                        RemoveWord(Words);
                        break;
                    case "3":
                        ShowAllWords(Words);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input, enter a number between 1-4. ");
                        break;
                }
            }           
        }
        static void AddWord(Dictionary<string, string> words) //add word method
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter the definition: ");
            string definition = Console.ReadLine();

            if (words.ContainsKey(word))
            {
                Console.Write("Word already exists. Do you want to overwrite it (yes/no)? ");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    words[word] = definition;
                    Console.WriteLine("Word updated");
                }
                else
                {
                    Console.WriteLine("Update declined");
                }
            }
            else 
            {
            words.Add(word, definition);
                Console.WriteLine("Word added. ");
            }
        }
        static void RemoveWord(Dictionary<string, string> words) //remove word method
        {
            Console.Write("Enter the word to remove: ");
            string word = Console.ReadLine();

            if (words.Remove(word))
            {
                Console.WriteLine("Word removed successfully");
            }
            else 
            {
                Console.WriteLine("Word not found. ");
            }
        
        }
        static void ShowAllWords(Dictionary<string, string> words) //show all words method
        {
            if (words.Count == 0)
            {
                Console.WriteLine("No words in the dictionary");
                return;
            }
            Console.WriteLine("\nWords and definitions: ");
            foreach (var pair in words) 
            {
                Console.WriteLine($"Word: {pair.Key}, Definition: {pair.Value}");
            }
        }
    }
}
