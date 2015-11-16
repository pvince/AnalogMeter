using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
namespace AnalogGauges
{
    class AGTools
    {

        public static int averageArray(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            return total / array.Length;
        }

        public static long getDirectorySize(string p)
        {
            // 1
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*", System.IO.SearchOption.AllDirectories);

            // 2
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4
            // Return total size
            return b;
        }

        public static int getFileLineCount(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);


            return lines.Length;
        }

    }
}
