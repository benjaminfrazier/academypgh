using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Arrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keeplooping;
            int number=0;
            int[] someArray = new int[] { 2, 6, 3, 7, 1, 4, 8, 0, 3, 5 };
            int nextnumber;
            string response = "";
            string sortedarray = "";

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    number = someArray[i];
                }
                else if (number < someArray[i])
                {
                    number = someArray[i];
                }
            }
            Console.WriteLine("The highest number is " + number + ".");
            Console.ReadLine();

            Console.WriteLine("\nPlease enter ten numbers.");

            int[] NewArray = new int[10];

            for (int i = 0; i<10; i++)
            {
                keeplooping = true;

                while (keeplooping)
                {
                    Console.WriteLine("\nPlease enter the next number.");
                    response = Console.ReadLine();
                    if (int.TryParse(response, out someArray[i]))
                    {
                        keeplooping = false;
                    }
                    else
                    {
                        Console.WriteLine("An invalid number was entered.");
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    number = someArray[i];
                }
                else if (number < someArray[i])
                {
                    number = someArray[i];
                }
            }

            Console.WriteLine("The highest number is " + number + ".");
            Console.ReadLine();

            Array.Sort(someArray);

            for (i = 0; i < 10; i++)
            {

            }

            Console.WriteLine("The sorted version of the array entered: " + someArray);
            Console.ReadLine();
        }
    }
}
