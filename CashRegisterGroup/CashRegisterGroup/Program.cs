using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterGroup
{+
    class Program
    {
        static string Cost()
        {
            string answer = Console.ReadLine();
            return answer;
        }
        static double Amount(string line)
        {
            double costOfItem;
            if (double.TryParse(line, out costOfItem))
            {

            }
            else
            {
                Console.WriteLine("You entered an invalid number.");
                costOfItem = 0;
            }
            return costOfItem;
        }

        static string ChangeCount(double finalChange)
        {
            int hundred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int pennies = 0;
            string printout = "";
            int counter = 0;

            while (finalChange > 0)
            {
                if (finalChange >= 100)
                {
                    hundred++;
                    finalChange = finalChange - 100;
                }
                else if (finalChange >= 50)
                {
                    fifty++;
                    finalChange = finalChange - 50;
                }
                else if (finalChange >= 20)
                {
                    twenty++;
                    finalChange = finalChange - 20;
                }
                else if (finalChange >= 10)
                {
                    ten++;
                    finalChange = finalChange - 10;
                }
                else if (finalChange >= 5)
                {
                    five++;
                    finalChange = finalChange - 5;
                }
                else if (finalChange >= 1)
                {
                    one++;
                    finalChange = finalChange - 1;
                }
                else if (finalChange >= 0.25)
                {
                    quarters++;
                    finalChange = finalChange - 0.25;
                }
                else if (finalChange >= 0.10)
                {
                    dimes++;
                    finalChange = finalChange - 0.10;
                }
                else if (finalChange >= 0.05)
                {
                    nickles++;
                    finalChange = finalChange - 0.05;
                }
                else if (finalChange > 0.00)
                {
                    pennies++;
                    finalChange = finalChange - 0.01;
                }
            }

            if (hundred > 0)
            {
                printout = printout + hundred + " hundreds";
                counter++;
            }

            if (fifty > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + fifty + " fifties";
                    counter++;
                }
                else
                {
                    printout = printout + fifty + " fifties";
                    counter++;
                }
            }
            if (twenty > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + twenty + " twenties";
                    counter++;
                }
                else
                {
                    printout = printout + twenty + " twenties";
                    counter++;
                }
            }
            if (ten > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + ten + " ten";
                    counter++;
                }
                else
                {
                    printout = printout + ten + " ten";
                    counter++;
                }
            }
            if (five > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + five + " fives";
                    counter++;
                }
                else
                {
                    printout = printout + five + " fives";
                    counter++;
                }
            }
            if (one > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + one + " ones";
                    counter++;
                }
                else
                {
                    printout = printout + one + " ones";
                    counter++;
                }
            }
            if (quarters > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + quarters + " quarters";
                    counter++;
                }
                else
                {
                    printout = printout + quarters + " quarters";
                    counter++;
                }
            }
            if (dimes > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + dimes + " dimes";
                    counter++;
                }
                else
                {
                    printout = printout + dimes + " dimes";
                    counter++;
                }
            }
            if (nickles > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + nickles + " nickles";
                    counter++;
                }
                else
                {
                    printout = printout + nickles + " nickels";
                    counter++;
                }
            }
            if (pennies > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + pennies + " pennies";
                    counter++;
                }
                else
                {
                    printout = printout + pennies + " pennies";
                    counter++;
                }
            }
            return printout;

        }

        static string Randomchange(double finalChange)
        {
            int hundred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int pennies = 0;
            string printout = "";
            int counter = 0;
            int random = 0;
            Random randomnum = new Random();

            while (finalChange > 0)
            {
                random = randomnum.Next(11);
                if (random == 1)
                {
                    if (finalChange >= 100)
                    {
                        hundred++;
                        finalChange = finalChange - 100;
                    }
                }
                if (random == 2)
                {
                    if (finalChange >= 50)
                    {
                        fifty++;
                        finalChange = finalChange - 50;
                    }
                }
                if (random == 3)
                {
                    if (finalChange >= 20)
                    {
                        twenty++;
                        finalChange = finalChange - 20;
                    }
                }
                if (random == 4)
                {
                    if (finalChange >= 10)
                    {
                        ten++;
                        finalChange = finalChange - 10;
                    }
                }
                if (random == 5)
                {
                    if (finalChange >= 5)
                    {
                        five++;
                        finalChange = finalChange - 5;
                    }
                }
                if (random == 6)
                {
                    if (finalChange >= 1)
                    {
                        one++;
                        finalChange = finalChange - 1;
                    }
                }
                if (random == 7)
                {
                    if (finalChange >= 0.25)
                    {
                        quarters++;
                        finalChange = finalChange - 0.25;
                    }
                }
                if (random == 8)
                {
                    if (finalChange >= 0.10)
                    {
                        dimes++;
                        finalChange = finalChange - 0.10;
                    }
                }
                if (random == 9)
                {
                    if (finalChange >= 0.05)
                    {
                        nickles++;
                        finalChange = finalChange - 0.05;
                    }
                }
                if (random == 10)
                {
                    if (finalChange > 0.00)
                    {
                        pennies++;
                        finalChange = finalChange - 0.01;
                    }
                }
            }

            if (hundred > 0)
            {
                printout = printout + hundred + " hundreds";
                counter++;
            }

            if (fifty > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + fifty + " fifties";
                    counter++;
                }
                else
                {
                    printout = printout + fifty + " fifties";
                    counter++;
                }
            }
            if (twenty > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + twenty + " twenties";
                    counter++;
                }
                else
                {
                    printout = printout + twenty + " twenties";
                    counter++;
                }
            }
            if (ten > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + ten + " ten";
                    counter++;
                }
                else
                {
                    printout = printout + ten + " ten";
                    counter++;
                }
            }
            if (five > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + five + " fives";
                    counter++;
                }
                else
                {
                    printout = printout + five + " fives";
                    counter++;
                }
            }
            if (one > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + one + " ones";
                    counter++;
                }
                else
                {
                    printout = printout + one + " ones";
                    counter++;
                }
            }
            if (quarters > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + quarters + " quarters";
                    counter++;
                }
                else
                {
                    printout = printout + quarters + " quarters";
                    counter++;
                }
            }
            if (dimes > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + dimes + " dimes";
                    counter++;
                }
                else
                {
                    printout = printout + dimes + " dimes";
                    counter++;
                }
            }
            if (nickles > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + nickles + " nickles";
                    counter++;
                }
                else
                {
                    printout = printout + nickles + " nickels";
                    counter++;
                }
            }
            if (pennies > 0)
            {
                if (counter > 0)
                {
                    printout = printout + ", " + pennies + " pennies";
                    counter++;
                }
                else
                {
                    printout = printout + pennies + " pennies";
                    counter++;
                }
            }
            return printout;

        }


        static void Main(string[] args)
        {
            bool keepLooping = true;
            bool keepLoopingTwo = true;
            double money = 0;
            double paid = 0;
            double change = 0;
            string response = "";

            while (keepLooping)
            {
                Console.WriteLine("How much does your item cost?");
                string input = Cost();
                money = Amount(input);
                if (money != 0)
                {
                    keepLooping = false;
                }
            }

            while (keepLoopingTwo)
            {
                Console.WriteLine("How much did you pay?");
                string input = Cost();
                paid = Amount(input);
                if (paid != 0)
                {
                    keepLoopingTwo = false;
                }
            }

            int intChange = 0;

            change = paid - money;
            Console.WriteLine("Your change is: " + change + ".");
            intChange = Convert.ToInt16(change * 100);
            if (intChange % 3 == 0)
            {
                Console.WriteLine(Randomchange(change));
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine(ChangeCount(change));
                Console.ReadLine();
            }

        }

    }
