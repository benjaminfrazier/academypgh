using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int typednum;
            bool keeplooping;
            string answer;

            Console.WriteLine("Enter a number?");
            typednum = Convert.ToInt16(Console.ReadLine());

            answer = "";
            keeplooping = true;

            while (keeplooping)
            {
                //I = 1
                //V = 5
                //X = 10
                //L = 50
                //C = 100
                //D = 500
                //M = 1000

                if (typednum>=1000)
                {
                    answer = answer + "M";
                    typednum = typednum - 1000;
                }
                else if (typednum>= 500)
                {
                    if (typednum >= 900)
                    {
                        answer = answer + "CM";
                        typednum = typednum - 900;
                    }
                    else
                    {
                        answer = answer + "D";
                        typednum = typednum - 500;
                    }
                }
                else if (typednum>= 100)
                {
                    if (typednum >= 400)
                    {
                        answer = answer + "CD";
                        typednum = typednum - 400;
                    }
                    else
                    {
                        answer = answer + "C";
                        typednum = typednum - 100;
                    }
                    
                }
                else if (typednum>= 50)
                {
                    if (typednum >= 90)
                    {
                        answer = answer + "XC";
                        typednum = typednum - 90;
                    }
                    else
                    {
                        answer = answer + "L";
                        typednum = typednum - 50;
                    }
                    
                }
                else if (typednum>= 10)
                {
                    if (typednum >= 40)
                    {
                        answer = answer + "XL";
                        typednum = typednum - 40;
                    }
                    else
                    {
                        answer = answer + "X";
                        typednum = typednum - 10;
                    }
                    
                }
                else if (typednum>= 5)
                {
                    if (typednum >= 9)
                    {
                        answer = answer + "IX";
                        typednum = typednum - 9;
                    }
                    else
                    {
                        answer = answer + "V";
                        typednum = typednum - 5;
                    }
                }
                else if (typednum>= 1)
                {
                    if (typednum >= 4)
                    {
                        answer = answer + "IV";
                        typednum = typednum - 4;
                    }
                    else
                    {
                        answer = answer + "I";
                        typednum = typednum - 1;
                    }
                }
                else
                {
                    keeplooping = false;
                }
            }

            Console.WriteLine("Number in roman numeral format: " + answer);
            Console.ReadLine();
        }
    }
}
