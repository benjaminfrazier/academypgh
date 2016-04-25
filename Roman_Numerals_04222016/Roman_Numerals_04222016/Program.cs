using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_04222016
{
    class Program
    {
        static void Main(string[] args)
        {
            //I = 1
            //V = 5
            //X = 10
            //L = 50
            //C = 100
            //D = 500
            //M = 1000

            string answer;
            int number="";
            bool keeplooping = true;
            string RomanNum="";

            while (keeplooping)
            {
                Console.WriteLine("Enter a number:");
                answer = Console.ReadLine();

                if (int.TryParse(answer, out number));
                {
                    keeplooping = false;
                }
            }

            while (number > 0)
            {
                if (number >= 1000)
                {
                    number = number - 1000;
                    RomanNum = RomanNum + "M";
                }
            }
        }
    }
}
