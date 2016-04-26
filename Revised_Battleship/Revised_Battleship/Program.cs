using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revised_Battleship
{
    class Program
    {
        static void CheckShipLoc(int x, int y)
        {
            string line;
            string text = File.ReadAllText("../../ShipLocation.txt");
            int i = 0;

            //Console.WriteLine(text);
            //Console.ReadLine();


            char[] aCharArray;

            System.IO.StreamReader file = new System.IO.StreamReader("../../ShipLocation.txt");

            while ((line = file.ReadLine()) != null)
            {
                aCharArray = line.ToCharArray();

                if (i == y)
                {
                    if (Convert.ToString(aCharArray[x]) == "X")
                    {
                        Console.WriteLine("It is a hit!");
                    }
                    else
                    {
                        Console.WriteLine("It is a miss.");
                    }
                }

                i++;
            }

            Console.ReadLine();

        }
        static void BuildGrid()
        {
            string[,] strGrid;

            strGrid = new string[8, 8];


        }
        static void Main(string[] args)
        {
            //Create a grid(an array with two dimensions) that is 8 by 8.

            //This grid will hold whether there is a ship in a given square or not.You can use a bool or an int for this.
            //You will need to be able to display this grid, with
            //00000000
            //0000*000
            //00**0000
            //00000000
            //000**000
            //*0*00000
            //00000**0
            //00****00

            //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

            //When users shoot an enemy, clear the ship in that cell

            //When all enemies are gone, make the "game" end.

            // Bonus:

            // If user picks a cell next to a ship, say "close!"

            bool keeplooping;
            int x = 0;
            int y = 0;
            int z = 0;
            string line = "";
            string[,] strShip;
            string response;

            strShip = new string[8, 8];

            //Build Battleship Grid

            Console.Clear();
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine("\n");

            x = 0;
            y = 0;

            Console.Write("     X     0     1     2     3     4     5     6     7" + "\n");
            Console.Write("\n");
            Console.Write("Y\n");
            Console.Write("\n");

            z = 0;

            while (y <= 7)
            {
                while (x <= 7)
                {
                    if (strShip[x, y] == null)
                    {
                        line = line + "      ";
                        x = x + 1;
                    }
                    else
                    {
                        line = line + "     " + strShip[y, x];
                        x = x + 1;
                    }

                }
                Console.Write(z + "     " + line + "\n");
                Console.Write("\n");
                line = "";
                y = y + 1;
                x = 0;
                z = z + 1;
            }

            Console.Write("\n");

            MissingXCoord:
            Console.WriteLine("Please enter x coordinate to attack ship!");
            response = Console.ReadLine();

            keeplooping = true;

            while (keeplooping)
            {
                if (int.TryParse(response, out x))
                {
                    if (x >=8)
                    {
                        Console.WriteLine("A number between 0 and 8 must be entered.");
                    }
                    else
                    {
                        keeplooping = false;
                    }
                }
                else
                {
                    Console.WriteLine("A valid number was not entered.");
                    goto MissingXCoord;
                }
            }

            MissingYCoord:
            Console.WriteLine("Please enter y coordinate to attack ship!");
            response = Console.ReadLine();

            keeplooping = true;

            while (keeplooping)
            {
                if (int.TryParse(response, out y))
                {
                    if (y >= 8)
                    {
                        Console.WriteLine("A number between 0 and 8 must be entered.");
                    }
                    else
                    {
                        keeplooping = false;
                    }
                }
                else
                {
                    Console.WriteLine("A valid number was not entered.");
                    goto MissingYCoord;
                }
            }

            //Check ship location mapping
            CheckShipLoc(x, y);


            
        }
    }
}
