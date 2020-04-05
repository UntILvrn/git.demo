using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Utils;

namespace BL
{
    public class WorkWF
    {
        public string InputFile { get; set; }
        public List<string> Lines { get; set; }

        public WorkWF(string inputFile)
        {
            InputFile = inputFile;
            Lines = File.ReadAllLines(inputFile, Encoding.Default).ToList();
        }

        public void SaveFile()
        {
            File.WriteAllLines(InputFile, Lines);
        }

        public string[] DeleteString (int n)
        {
            Lines.RemoveAt(n);
            SaveFile();
            return Lines.ToArray();
        }
       
        public int HowMuch()
        {
            IOUtils input = new IOUtils(InputFile);
            string number = Encoding.Default.GetString(input.Number);
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ' ')
                {
                    continue;
                }
                else result++;
            }
            return result;
        }
    }
}
