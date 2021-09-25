using System.Collections.Generic;

namespace ACard
{
    internal class Saves
    {
        public List<Game> Games { get; set; }
        public string Path { get; set; }

        public Saves()
        {
            Games = new List<Game>();
            Path = ".\\saves.json";
        }
    }
}
