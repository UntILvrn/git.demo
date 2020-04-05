using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utils
{
    public class IOUtils
    {
        public string InputFile { get; set; }
        public byte[] Number { get; set; }

        public IOUtils(string inputFile)
        {
            InputFile = inputFile;
            Number = File.ReadAllBytes(inputFile);
        }
    }
}
