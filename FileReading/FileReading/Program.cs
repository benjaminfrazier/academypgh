using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("./readme.txt");

            Console.WriteLine(text);
            Console.ReadLine();

            System.IO.StreamReader file = new System.IO.StreamReader(./readme.txt);
            string line;

            while ((line = file.ReadLine()) != null;
            {
                Console.WriteLine(line);
            }
        }
    }
}
