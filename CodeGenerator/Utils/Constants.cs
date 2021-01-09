using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeGenerator.Utils
{
    public static class Constants
    {
        public const string LETTER_STRING = "ACDEFGHKLMNPRTXYZ";
        public const string NUMBER_STRING = "234579";
        public const int CODE_COUNT_TO_GENERATE = 1000;
        public static string TEXT_FILE_PATH = Directory.GetCurrentDirectory() + "\\codes.txt";
        public static string REGEX_PATTERN = @"^[ACDEFGHKLMNPRTXYZ]{2}[234579]{4}[ACDEFGHKLMNPRTXYZ]{2}$";
    }
}
