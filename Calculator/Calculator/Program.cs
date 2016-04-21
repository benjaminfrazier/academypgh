using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("+) Add");
            Console.WriteLine("-) Subtract");
            Console.WriteLine("*) Multiply");
            Console.WriteLine("/) Divide");
            Console.WriteLine("c) Clear");
            Console.WriteLine("q) Quit");
            Console.WriteLine("Please select an option +, -, *, /, c, q.");
        }
        static int Calc(int x, int y, string mathtype)
        {
            if (mathtype == "+")
            {
                y = y + x;
            }
            if (mathtype == "-")
            {
                y = y - x;
            }
            if (mathtype == "*")
            {
                y = y * x;
            }
            if (mathtype == "/")
            {
                y = y / x;
            }
            if (mathtype == "c")
            {
                y = 0;
            }
            return y;
        }
        static void Main(string[] args)
        {
            //What would you like to do?
            //a) Add
            //b) Subtract
            //c) Multiply
            //d) Divide

            //Ask for first number and then ask for the second.

            int x;
            int y = 0;
            string answer;
            string math;
            bool keepcalc = true;
            bool firstnumber;

            Clear:
            firstnumber = true;
            while (firstnumber)
            {
                Console.WriteLine("Please enter the first number.");
                answer = Console.ReadLine();
                if (int.TryParse(answer, out x))
                {
                    y = x;
                    firstnumber = false;
                }
            }

            keepcalc = true;
            while (keepcalc)
            {
                Menu();
                math = Console.ReadLine();
                if (math == "c")
                {
                    goto Clear;
                }
                Console.WriteLine("Please enter the next number.");
                answer = Console.ReadLine();

                if (int.TryParse(answer, out x))
                {
                    y = Calc(x, y, math);

                    Console.WriteLine("\nCurrent value is: " + y + ".");

                    if (math == "q")
                    {
                        Console.WriteLine("Exiting the calculator.");
                        keepcalc = false;
                    }
                }
            }
        }
    }
}
