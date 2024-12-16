using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
    class Games //properties
    {
        public string Name 
        { get; set; }
        public string Publisher 
        { get; set; }
        public int Year 
        { get; set; }
        public string Genre 
        { get; set; }

        //constructor
        public Games(string name, string publisher, int year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
        public void DisplayGameInfo()
        {
            Console.WriteLine($"Name: {Name}, \nPublisher: {Publisher}, \nYear: {Year}, \nGenre: {Genre}");
        }
        static void Main(string[] args)
        {
            List<Games> gameList = new List<Games>();
            //default game
            Games game1 = new Games("Bloons 6", "Ninja Kiwi", 2018, "Tower Defense");
            gameList.Add(game1);
            //added game
            Games game2 = new Games("Farming Simulator 25", "GIANTS Software", 2024, "Simulator");
            gameList.Add(game2);
            
            foreach (var game in gameList) //loop through list and display info
            { 
                game.DisplayGameInfo(); 
            }

        }
    }
    }
}
