using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] files)
        {
            List<char>[] filesList = new List<char>[files.Length];
            for(int i=0; i < files.Length; i++)
            {
                StreamReader sr = new StreamReader(files[i]);

            }
        }
    }
}
