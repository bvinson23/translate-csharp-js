using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Insult> insults = new List<Insult>
            {
                new Insult() {
                    InsultText = "You look like what morning breath smells like."
                },
                new Insult() {
                    InsultText = "If you tried to give me cpr I would probably throw myself back under water"
                },
                new Insult() {
                    InsultText = "I am not a fan of you"
                },
                new Insult() {
                    InsultText = "You think you're so special...and you are. The fact of your existence is nearly impossible to believe"
                },
                new Insult() {
                    InsultText = "I'd rather walk than be on the same plane as you"
                },
                new Insult() {
                    InsultText = "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy"
                },
                new Insult() {
                    InsultText = "Do you have to be so...like that?"
                },
            };

            Random i = new Random();
            List<int> indexes = new List<int> { };
            while (indexes.Count < 3)
            {
                int candidate = i.Next(0, insults.Count);
                if (!indexes.Contains(candidate)) {
                    indexes.Add(candidate);
                }
            }

            for (int x = 0; x < indexes.Count; x++)
            {
                int index = indexes[x];
                Console.WriteLine(insults[index].InsultText);
            }
        }
    }
}
