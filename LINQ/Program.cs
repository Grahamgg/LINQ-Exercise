namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videogames = new List<string>() { "OoT", "MM", "WW" };
            Console.WriteLine("Original Video Game List");
            foreach (string game in videogames)
            {
                Console.WriteLine(game);
            }
            

            var gameLength = videogames.OrderBy(x => x.Length);
            Console.WriteLine("Video Game List organized by Length" );
            foreach (string game in videogames)
            {
                Console.WriteLine(game);
            }

            var addGame = videogames.Append("Botw");
            Console.WriteLine("Video Game List with a new addition" );
            foreach ( string game in addGame)
            {
                Console.WriteLine(game);
            }

            var twoLettergames = videogames.Where(game => game.Length == 2);
            Console.WriteLine("Video Game List with only 2 letter games");
            foreach (string game in twoLettergames)
            {
                Console.WriteLine(game);
            }

            var onlyCaps = videogames.Select(game => game.ToUpper());
            Console.WriteLine("Video Game List with all capital letters");
            foreach (string game in onlyCaps)
            {
                Console.WriteLine(game);
            }

            var totalgameLength = videogames.Sum(game => game.Length);
            Console.WriteLine($"\nTotal Length of all game names combined: {totalgameLength}");

            var averagegameLength = videogames.Average(game => game.Length);
            Console.WriteLine($"\nAverage Length of all game names combined: {averagegameLength}");

            var gameCount = videogames.Count();
            Console.WriteLine($"\nNumber of games in the list: {gameCount}");

            var firstGame = videogames.Min();
            Console.WriteLine($"\nThe first game is: {firstGame}");

            var lastGame = videogames.Max();
            Console.WriteLine($"\nThe last game is: {lastGame}");

            var twoGames = videogames.Take(2);
            Console.WriteLine($"\nThe first two games are:");
            foreach (string game in twoGames)
            {
                Console.WriteLine(game);
            }

            var lengthandAlpha = videogames.OrderBy(x => x.Length).ThenBy(x => x);
            Console.WriteLine($"\nVideo game list ordered by Length, then aphabetically:");
            foreach (string game in lengthandAlpha)
            {
                Console.WriteLine(game);
            }

        }
    }
}
