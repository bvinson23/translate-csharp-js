using System.Collections.Generic;

namespace csharp
{
    public class Guest
    {
        public string name { get; set; }
        public string occupation { get; set; }
        public string bio { get; set; }

        public Guest(string name, string occupation, string bio)
        {
            this.name = name;
            this.occupation = occupation;
            this.bio = bio;
        }
    }
}