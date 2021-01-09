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
        public static  string TEXT_FILE_PATH = Directory.GetCurrentDirectory() + "\\codes.txt";
    }
}
