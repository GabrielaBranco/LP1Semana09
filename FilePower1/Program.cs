using System;
using System.Collections.Generic;
using System.IO;


namespace FilePower1
{
    class Program
    {
        public static void Main(string[] file)
        {
            string path = Path.Combine(file[0]);
            string contents = "";

            Queue<string> queue = new Queue<string>();
            string line = null;

            while ((line = Console.ReadLine()) != "")
            {
                queue.Enqueue(line);
            }

            foreach (string element in queue)
            {
                contents += $"{element}\n";
            }

            File.WriteAllText(path, contents);
        }
    }
}