using System;
using IOArray;

namespace TextFile1_1_3
{
    public class Work
    {
        public static string text = IOUtils.Input(1, null);
        public static string result;
        public void DeleteFirst()
        {
            //string result = "";
            int cut = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '\n')
                {
                    continue;
                }
                else
                {
                    cut = i;
                    break;
                }
            }
            for (int j = cut; j < text.Length; j++)
            {
                result += Convert.ToString(text[j]);
            } 
        }
    }
}
