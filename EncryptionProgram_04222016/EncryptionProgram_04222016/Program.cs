using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionProgram_04222016
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "1";
            char someChar = '1';
            string answer;
            string encryptdline = "";

            Console.WriteLine("Please enter message:");
            answer = Console.ReadLine();

            char[] aCharArray;

            aCharArray = answer.ToCharArray();

            for (int i = 0; i < aCharArray.Length; i++)
            {
                Console.WriteLine("Character: " + (((int)aCharArray[i]) + 1));

                encryptdline = encryptdline + (char)(((int)aCharArray[i])+1);

            }

        //Console.WriteLine((char)110);
            Console.WriteLine(encryptdline);
            Console.ReadLine();


            aCharArray = encryptdline.ToCharArray();

            encryptdline = "";

            for (int i = 0; i < aCharArray.Length; i++)
            {
                Console.WriteLine("Character: " + (((int)aCharArray[i]) - 1));

                encryptdline = encryptdline + (char)(((int)aCharArray[i]) - 1);
            }

            //Console.WriteLine((char)110);
            Console.WriteLine(encryptdline);
            Console.ReadLine();
        }
    }
}
