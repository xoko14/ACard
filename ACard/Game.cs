using Newtonsoft.Json;
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

        [JsonConstructor]
        public Game(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            Profiles = new List<Profile>();
        }

        public Game(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Game;

            if (item == null)
            {
                return false;
            }

            return this.Name.Equals(item.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
