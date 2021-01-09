using CodeGenerator.Log;
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

            console.WritelineToConsole("There are 3 options you can choose.\n");
            console.WritelineToConsole("1. Generate 1000 unique* codes to a text file under debug folder.");
            console.WritelineToConsole("2. Check if a code is valid by the algorithm.");
            console.WritelineToConsole("3. Check if a code exists in generated 1000 codes. (First you must generate with option 1)\n");
            console.WritelineToConsole("**Note: If text file already exists, option 1 deletes it and creates new file to add codes.\n");
            console.ReadKey();


        }
    }
}
