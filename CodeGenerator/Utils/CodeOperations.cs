using CodeGenerator.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            TextFileOperations.CreateTextFile();
            TextFileOperations.WriteCodesToTextFile(codes);
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

            

            return codes;
        }

        private bool Validation(string code)
        {
            return false;
        }
    }
}
