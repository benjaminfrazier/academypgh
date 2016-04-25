using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revised_Battleship
{
    class Program
    {
        static void CheckShipLoc()
        {
            string[,] strShipLoc;

            strShipLoc = new string[8, 8];

            //C - Cruiser 2 Squares
            strShipLoc[0, 0] = "*";
            strShipLoc[0, 1] = "*";

            //D - Destroyer Three Squares
            strShipLoc[4, 0] = "*";
            strShipLoc[5, 0] = "*";
            strShipLoc[6, 0] = "*";

            //S - Sub Three Squares
            strShipLoc[7, 1] = "*";
            strShipLoc[7, 2] = "*";
            strShipLoc[7, 3] = "*";

            //C - Battleship Four Squares
            strShipLoc[2, 4] = "*";
            strShipLoc[3, 4] = "*";
            strShipLoc[4, 4] = "*";
            strShipLoc[5, 4] = "*";

            //A - Aircraft Carrier - Five Squares
            strShipLoc[3, 6] = "*";
            strShipLoc[4, 6] = "*";
            strShipLoc[5, 6] = "*";
            strShipLoc[6, 6] = "*";
            strShipLoc[7, 6] = "*";
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

            //Build Battleship Grid


            //Check ship loaction mapping
            CheckShipLoc();
            
        }
    }
}
