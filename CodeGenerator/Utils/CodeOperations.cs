using CodeGenerator.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeGenerator.Utils
{
    public class CodeOperations
    {
        IConsole _console;

        public CodeOperations(IConsole console)
        {
            _console = console;
        }

        public void GenerateThousandCodes()
        {
            List<string> codes = GenerateCodes();

            TextFileOperations.WriteCodesToTextFile(codes);
            _console.WritelineToConsole("CODES ARE GENERATED!");
            _console.WritelineToConsole("You can find generated codes in -> " + Constants.TEXT_FILE_PATH);
        }

        public bool CheckIfCodeIsValid(string code)
        {
            return Validation(code);
        }

        public bool CheckIfCodeIsCreated(string code)
        {
            List<string> codes = TextFileOperations.ReadAllCodesFromTextFile();

            if (codes.Where(x => x == code).FirstOrDefault() != null)
                return true;

            return false;
        }

        private List<string> GenerateCodes()
        {
            List<string> codes = new List<string>();

            char[] letters = Constants.LETTER_STRING.ToCharArray();
            char[] numbers = Constants.NUMBER_STRING.ToCharArray();

            Random random = new Random();

            while (codes.Count < Constants.CODE_COUNT_TO_GENERATE)
            {
                List<char> aCodeChars = new List<char>();

                //First 2 letters
                for (int i = 0; i < 2; i++)
                {
                    int rand = random.Next(0, letters.Length);
                    aCodeChars.Add(letters[rand]);
                }

                //Then 4 numbers
                for (int i = 0; i < 4; i++)
                {
                    int rand = random.Next(0, numbers.Length);
                    aCodeChars.Add(numbers[rand]);
                }

                //Last 2 letters
                for (int i = 0; i < 2; i++)
                {
                    int rand = random.Next(0, letters.Length);
                    aCodeChars.Add(letters[rand]);
                }

                string code = new string(aCodeChars.ToArray());

                if (codes.Where(c => c == code).FirstOrDefault() == null)
                {
                    codes.Add(code);
                }
            }           

            return codes;
        }

        private bool Validation(string code)
        {
            var match = Regex.Match(code, Constants.REGEX_PATTERN);

            if (!match.Success)            
                return false;

            return true;
        }
    }
}
