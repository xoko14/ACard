using System;
using System.Collections.Generic;
using System.Text;

namespace ACard
{
    class Game
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Profile> Profiles { get; set; }

        public Game(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            Profiles = new List<Profile>();
        }
    }
}
