﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeGenerator.Utils
{
    public static class TextFileOperations
    {
        public static void WriteCodesToTextFile(List<string> codes)
        {
            if (File.Exists(Constants.TEXT_FILE_PATH))
            {
                File.Delete(Constants.TEXT_FILE_PATH);
            }

            File.AppendAllLines(Constants.TEXT_FILE_PATH, codes);
        }

        public static List<string> ReadAllCodesFromTextFile()
        {
            return File.ReadAllLines(Constants.TEXT_FILE_PATH).ToList();
        }
    }
}
