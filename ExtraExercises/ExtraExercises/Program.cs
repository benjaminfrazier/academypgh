using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercises
{
    class Program
    {
        static int checkVowels(string response)
        {
            char[] aCharArray;

            aCharArray = response.ToLower().ToCharArray();

            for (int i = 0; i < response.Length; i++)
            {
                if (aCharArray[i] == 'a')
                {
                    Console.
                }
            }

            return x;
        }
        static void Main(string[] args)
        {
            // Ask the user for a sentence/word
            // Print out the sentence/word in reverse
            // ex "Hello"  prints out "olleH"

            // Ask the user for their name
            // tell them how many vowels they have in their name

            // Ask the user for a sentence
            // Tell them how many words were in their sentence
            // ex "This is a sentence with many words" prints out "7 words"

            // Ask the user for a number
            // Use this number as the widest point when drawing a diamond to the
            // console
            // ex: 5
            //   *
            //  ***  
            // *****
            //  ***
            //   *

            string response = "";
            string reversestring = "";

            Console.WriteLine("Please prvide a sentence or word that needs to be reversed.");
            response = Console.ReadLine();

            char[] aCharArray;

            aCharArray = response.ToCharArray();

            for (int i = 0; i < response.Length; i++)
            {
                reversestring = aCharArray[i] + reversestring;
            }

            Console.WriteLine(reversestring);
            Console.ReadLine();

            Console.WriteLine("\nWhat is your name?");
            response = Console.ReadLine();

            checkVowels(response);
        }
    }
}
