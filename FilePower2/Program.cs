using System;
using System.IO;

namespace FilePower2
{
    class Program
    {
        public static void Main(string[] fileName)
        {
            string content = null;

            using StreamWriter sw = new StreamWriter("FilePower2/"+fileName[0]);

            while ((content = Console.ReadLine()) != "")
            {
                Console.WriteLine(content);
                sw.WriteLine(content);
            }
        }
    }
}