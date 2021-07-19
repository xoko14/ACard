using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACard
{
    class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }

        [JsonConstructor]
        public Profile(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Profile(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Profile;

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
