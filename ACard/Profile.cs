using System;
using System.Collections.Generic;
using System.Text;

namespace ACard
{
    class Profile
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Profile(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
