using System;
using System.IO;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are 3 options you can choose.\n");
            Console.WriteLine("1. Generate 1000 unique* codes to a text file under debug folder.");
            Console.WriteLine("2. Check if a code is valid by the algorithm.");
            Console.WriteLine("3. Check if a code exists in generated 1000 codes. (First you must generate with option 1)\n");
            Console.WriteLine("**Note: If text file already exists, option 1 deletes it and creates new file to add codes.\n");
            Console.ReadKey();


        }
    }
}
