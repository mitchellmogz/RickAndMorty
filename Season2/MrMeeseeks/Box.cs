using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrMeeseeks
{
    class Box
    {
        static void Main(string[] args)
        {

            //Add Box Here
            Console.WriteLine("Rick's Box o' Fun! Enter any key to summon a Mr. Meeseeks!");
            string anyKey = Console.ReadLine();

            Console.WriteLine("I'm Mr. Meeseeks! Look at me!");
            string input = Console.ReadLine();

            if (input == "I want to be popular aat school" || input == "popular" || input == "popular at school")
            {
                Console.WriteLine("Ooh, okay!");
            }

            if (input == "I want to be a more complete woman" || input == "complete" || input == "complete woman")
            {
                Console.WriteLine("Oh, yeah! Yes, ma'am!");
            }

            if (input == "I would like to take two strokes off my golf game" || input == "two strokes" || input == "golf")
            {

                Console.WriteLine("Ooh yeah! Can do!");

                Console.WriteLine("Enter any key to swing.");
                anyKey = Console.ReadLine();

                Console.WriteLine("Remeber to square your shoulders, Jerry.");

                Console.WriteLine("Enter any key to swing.");
                anyKey = Console.ReadLine();

                Console.WriteLine("Try again and keep your head down.");

            }



        }
    }
}
