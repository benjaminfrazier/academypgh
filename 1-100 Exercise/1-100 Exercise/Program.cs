using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will play a guessing game
            // The program will pick a number from 1-100 then ask the user
            // to guess the number. If they guess the wrong number
            // the computer will tell them to guess higher or lower.
            // When the user gets the number, the program should congratulate them
            // and tell them how many guesses it took

            // I have picked a number. Try to guess it!
            // 20
            // Higher.
            // 30
            // Lower.
            // 25
            // Higher.
            // 27
            // Right. It took you 4 guesses!

DoAgain:
            bool keeplooping = true;
            int guessnum = 0;
            int rndmnm = 0;
            int x;
            string response;

            Random randomnum = new Random();

            rndmnm = randomnum.Next(100);

            while (keeplooping)
            {
                Console.WriteLine("I have picked a number from 1 - 100.  Please try to guess it.");
                response = Console.ReadLine();

                guessnum++;

                if (int.TryParse(response, out x))
                {
                    if (x < 1 || x > 100)
                    {
                        Console.WriteLine("Number must be any from 1 - 100.");
                    }
                    else if (rndmnm > x)
                    {
                        Console.WriteLine("Higher.  Please guess again.");
                    }
                    else if (rndmnm < x)
                    {
                        Console.WriteLine("Lower.  Please guess again.");
                    }
                    else
                    {
                        Console.WriteLine("You have guessed my number!  It took you " + guessnum + " guesses.");
                        Console.ReadLine();
                        keeplooping = false;
                    }
                }
            }

            Console.WriteLine("Would you like to play again?  (Yes or any other key to exit.)");
            response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.Clear();
                goto DoAgain;
            }
        }
    }
}
