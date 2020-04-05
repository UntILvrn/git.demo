using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FormsUtils;

namespace IOArray
{
    public class IOUtils
    {
        public static readonly string
            ExeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName),
            ExeDir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);


        public static void NumberFormatInit()
        {
            // чтобы вещественные числа разделялись точкой, а не запятой
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        public static void WriteArray(string path, int[,] array)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    string[] line = new string[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        line[j] = array[i, j].ToString();
                    }
                    sw.WriteLine(String.Join(" ", line));
                }
            }
        }
        public static int[,] FileToArray(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath);
            int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    num[i, j] = Int32.Parse(temp[j]);
            }
            return num;
        }
        public static void WriteResult(string WritePath, string output)
        {
            using (StreamWriter sw = new StreamWriter(WritePath, false))
            {
                sw.WriteLine(output);
            }
        }
        public static string Input(object sender, EventArgs e)
        {
            string res = "";
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            res = File.ReadAllText(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            return res;
        }
    }
}
