using System;
using System.Linq;

namespace LINQ_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)// an array of games called games initialized with 10 games with one called minecraft
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action FPS"),
                new Game("ZombCube", 'E', "FPS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Action Racing")
            };

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";// linq method query  to find the game minecraft from the games array and assing it to a var called mineCraft

            foreach(var game in shortGames) // loop through and print each element in shortGames
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft") // prints all game properties of mineCraft to console using the FirstOrDefault method
                            .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games //var named tRated with selected titles where esrb rating is T
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games:"); //loop through trated and print each element to console
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games //var called eratedaction, esrb rating is e and genre is action
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E Rated Action Games:"); //Prints that to console
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}