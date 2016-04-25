using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "1";
            char someChar = '1';

            string aLongString = "Extra Long String";
            char[] aCharArray;

            aCharArray = aLongString.ToCharArray();

            for (int i = 0; i < aCharArray.Length; i++)
            {
                Console.WriteLine("Character: " + aCharArray[i]);
                Console.WriteLine("value: " + (int)aCharArray[i]);
            }

            //Console.WriteLine((char)110);

            Console.ReadLine();
        }
    }
}
