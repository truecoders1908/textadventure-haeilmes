using System;

namespace Beer_bar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the taproom!");
            Console.WriteLine("We have many types of beer to choose from.");


            Console.WriteLine("We have many different styles of beer to choose from");
            Console.WriteLine("red ale");
            Console.WriteLine("pale ale");
            Console.WriteLine("ipa");
            Console.WriteLine("stout");
            Console.WriteLine("lager");
            Console.WriteLine("domestic");
            Console.WriteLine();
            Console.WriteLine("Which would you like?");

            string beerChoice = Console.ReadLine();

            if (beerChoice.ToLower() == "domestic")
            {
                Console.WriteLine("get out");
            }

            else if (beerChoice.ToLower() == "pale ale")
            {
                Console.WriteLine("*you enjoy its a nice light but still filling drink with a mild bitterness*");
                Console.WriteLine("what's next?");
            }

            else if (beerChoice.ToLower() == "ipa")
            {
                Console.WriteLine("*you smell flowers and enjoy a lasting resiny feel yet also very bitter drink*");
                Console.WriteLine("what's next?");
            }

            else if (beerChoice.ToLower() == "stout")
            {
                Console.WriteLine("*you get a very rich syrupy drink that smells of coffee and chocolate but still finishes very smooth*");
                Console.WriteLine("what's next?");

            }

            else if (beerChoice.ToLower() == "lager")
            {
                Console.WriteLine("*the beer you get is ver crisp and clear with a clean taste and a hint of breadiness*");
                Console.WriteLine("what's next?");
            }
            else
            {
                Console.WriteLine("we dont serve that here");
            }

        }
    }
}
