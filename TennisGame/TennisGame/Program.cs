using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    class Program
    {
        static bool funcScore(string name1, int x, string name2, int y)
        {
            if (x >= 4 && x >= y + 2)
            {
                Console.WriteLine("Player " + name1 + " has won the game!!!!" + name1 + " " + x + " " + name2 + " " + y);
                return false;
            }
            else if (y >= 4 && y >= x + 2)
            {
                Console.WriteLine("Player " + name2 + " has won the game!!!!" + name1 + " " + x + " " + name2 + " " + y);
                return false;
            }
            else if (x >= 3 && y >= 3 && x == y)
            {
                Console.WriteLine("Duece ");
            }
            else if ((x >= 3 || y >= 3) && x > y)
            {
                Console.WriteLine("Advantage " + name1);
            }
            else if ((x >= 3 || y >= 3) && x < y)
            {
                Console.WriteLine("Advantage " + name2);
            }
            else if (x == 0 && y != 0)

            {
                Console.WriteLine("Love " + name1 + " " + x + " " + name2 + " " + y);
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine(name1 + " " + x + " Love " + name2 + " " + y);
            }
            return true;

        }
        static void DrawGrid(bool[,] grid, int xSize, int ySize)
        {
            // Console.WriteLine("xsize:" + xSize);
            // Console.WriteLine("gridx" + grid);
            for (int i = 0; i < ySize; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < xSize; j++)
                {
                    if (grid[i, j] == true)
                    {
                        Console.Write((char)219);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Tennis Game
            //*You can never remember how to say the score in tennis
            //* So now you are writing yourself a program that will tell you how to say a tennis score.

            //*You will enter the score for player 1 and player 2
            //* Then the program will output how to say the score ex 2, 0 = "thirty love" ex 5, 4 = "advantage player 1"

            //*Here are the exact rules for tennis scoring: *Scores from zero to three points are described as “love”, “fifteen”, “thirty”, and “forty” respectively.

            //*If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “advantage” for the player in the lead.

            //*If at least three points have been scored by each player, and the scores are equal, the score is “deuce”.

            //A game is won by the first player to have won at least four points in total and at least two points more than the opponent.

            //declaring players
            int player1 = 0;
            int player2 = 0;
            int x = 0;
            int y = 0;
            string name1;
            string name2;
            bool keeplooping;

            Random rnd = new Random();

            Console.WriteLine("Welcome to the Tennis Game");
            Console.WriteLine("Please enter player 1's name:");
            name1 = Console.ReadLine();

            Console.WriteLine("\nPlease enter player 2's name:");
            name2 = Console.ReadLine();

            Console.WriteLine("Tennis Match:  Erin versus Jesse (Hit the enter key to begin.)");
            Console.ReadLine();

            keeplooping = true;

            while ((keeplooping))
            {
                player1 = rnd.Next(100) + 1;
                player2 = rnd.Next(100) + 1;

                if (player1 > player2)
                {
                    x++;
                }
                else if (player2 > player1)
                {
                    y++;
                }

                keeplooping = funcScore(name1, x, name2, y);
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
