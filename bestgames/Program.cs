namespace bestgames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader SR = new StreamReader("bestgames.csv");

            List<Game> Games = new List<Game>();

            string line;

            while ((line = SR.ReadLine()) != null)
            {
                Games.Add(new Game(line));
            }
            SR.Close();

            /*
            foreach (var Game in Games)
            {
                Console.WriteLine(Game.Name);
            }
            */

            //F1
            Console.WriteLine($"f1: összesen {Games.Count()} játék szerepel a listában!");

            //F2
            var grp = Games.GroupBy(g => g.Date)
                .Where(g => g.Count() > 10)
                .OrderByDescending(g => g.Count())
                .ToDictionary(x => x.Key, x => x.Count());

            Console.WriteLine($"f2: ezekben az években került ki több, mint 10 cím listára");
            foreach (var kvp in grp)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}db");
            }
        }
    }
}