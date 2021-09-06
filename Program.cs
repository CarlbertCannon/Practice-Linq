using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Linq
{
    class Program
    {
        static void Main(string[] args)
        {


            var videoGames = new List<string>() { "Halo", "Duke Nukum", "Final Fantasy 7", "Super Mario Bros" };

            var sorted = videoGames.Where(word => word.Contains(""));

            //var sorted = videoGames.OrderBy(word => word.Contains(""));


            videoGames.Sort();

            foreach(var item in videoGames)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}