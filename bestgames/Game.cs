using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestgames
{
    internal class Game
    {
        public int Date { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public List<string> Platforms { get; set; } = new();

        public Game(string row)
        {
            string[] v = row.Split(';');
            Date = int.Parse(v[0]);
            Name = v[1];
            Genre = v[2];
            Publisher = v[3];
            Platforms = v[4].Replace(", ", ",").Split(",").ToList();
        }
    }
}
