using System;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] gameNameArray = { "Phantom Brave", "Pac-Man", "Kirby", "Super Mario 64", "Castlevania: Aria of Sorrow" };

            Console.WriteLine("-------Unsorted--------");

            foreach (string gameName in gameNameArray)
            {
                Console.WriteLine(gameName);
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("---------Sorted--------");

            string[] sortedGameNameArray = gameNameArray.OrderBy(x => x.Length).ToArray();

            foreach(string gameName in sortedGameNameArray) 
            { 
                Console.WriteLine(gameName); 
            }
            Console.WriteLine("-----------------------");
        }
    }
}
