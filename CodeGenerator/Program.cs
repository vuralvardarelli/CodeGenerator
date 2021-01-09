using CodeGenerator.Log;
using CodeGenerator.Utils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //To implement Dependency Injection on .Net Core Console App
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddSingleton<IConsole, ConsoleActions>()
                                           .BuildServiceProvider();

            //To get console interface for actions
            IConsole console = serviceProvider.GetRequiredService<IConsole>();

            console.WritelineToConsole("There are 4 options you can choose.\n");
            console.WritelineToConsole("1. Generate 1000 unique* codes to a text file under debug folder.");
            console.WritelineToConsole("2. Check if a code is valid by the algorithm.");
            console.WritelineToConsole("3. Check if a code exists in generated 1000 codes. (First you must generate with option 1)");
            console.WritelineToConsole("4. Exit Application\n");
            console.WritelineToConsole("**Note: If text file already exists, option 1 deletes it and creates new file to add codes.");
            console.WritelineToConsole("**Note: Algorithm makes first 2 chars from letters then 4 chars from numbers, last 2 chars from letters.\n");
            console.WritelineToConsole("Please just hit 1 or 2 or 3 or 4.\n");

            CodeOperations co = new CodeOperations(console);

            string readedKey = "";

            while (readedKey != "4")
            {
                ConsoleKeyInfo cki = console.ReadKey();
                readedKey = cki.KeyChar.ToString();

                if (readedKey == "1")
                {
                    co.GenerateThousandCodes();
                }
                else if (readedKey == "2")
                {
                    console.WritelineToConsole("\nPlease type a code to check if it is just valid :\n");
                    string triedCode =console.ReadLine();

                    bool isValid = co.CheckIfCodeIsValid(triedCode);

                    if (isValid)
                    {
                        console.WritelineToConsole("Code is VALID!\n");
                    }
                    else
                    {
                        console.WritelineToConsole("Code is NOT VALID!\n");
                    }
                }
                else if (readedKey == "3")
                {
                    console.WritelineToConsole("\nPlease type a code to check if it is inside generated codes :\n");
                    string triedCode = console.ReadLine();

                    bool isGenerated = co.CheckIfCodeIsCreated(triedCode);

                    if (isGenerated)
                    {
                        console.WritelineToConsole("Code is GENERATED!\n");
                    }
                    else
                    {
                        console.WritelineToConsole("Code is NOT GENERATED!\n");
                    }
                }
                else if (readedKey == "4")
                {
                    break;
                }
                else
                {
                    console.WritelineToConsole("\nWrong input option. Try again!");
                }

                console.WritelineToConsole("\nNow you are back to selecting from options.\n");

            }

            console.WritelineToConsole("\nApplication is closing..\n");
            console.ExitConsole();



        }
    }
}
