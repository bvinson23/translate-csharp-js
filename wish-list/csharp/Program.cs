using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Wish> iWishFor = new List<Wish>
           {
               new Wish() {
                   WishName = "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'"
               },
               new Wish() {
                   WishName = "The ability to think of interesting wishes on short notice"
               },
               new Wish() {
                   WishName = "A washtub of Skittles"
               },
               new Wish() {
                   WishName = "World peace, but not the kind of world peace where all the humans are removed from existencee"
               },
               new Wish() {
                   WishName = "A TV that is NOT internet-capable"
               },
               new Wish() {
                   WishName = "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
               }
           };

           Console.WriteLine("My wishes...");
           foreach(Wish wish in iWishFor)
           {
               Console.WriteLine($"{wish.WishName}");
           }
        }
    }
}
