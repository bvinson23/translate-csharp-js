using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> getGuests()
            {
                Dictionary<string, List<Guest>> tableset = new Dictionary<string, List<Guest>>();
                List<Guest> guestList = new List<Guest>
                {
                    new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962 American actress, singer, model"),
                    new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"),
                    new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner"),
                    new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist"),
                    new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"),
                    new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"),
                    new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"),
                    new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977"),
                };

                return guestList;
            }
            Table room = new Table();

            foreach (Guest guest in getGuests())
            {
                if (room.table1.Contains(guest))
                {
                    room.table2.Add(guest);
                }
            }
        }
    }
}