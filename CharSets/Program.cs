using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] files)
        {
            HashSet<char>[] filesList = new HashSet<char>[files.Length];
            string s = "";

            for(int i=0; i < filesList.Length; i++)
            {
                filesList[i] = new HashSet<char>();
            }

            for(int i=0; i < filesList.Length; i++)
            {
                string path = Path.Combine("CharSets", files[i]);
                using StreamReader sr = new StreamReader(path);

                while (( s = sr.ReadLine()) != null )
                {
                    if( s.Length > 1)
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                    else
                    {
                        filesList[i].Add(char.Parse(s));
                    }
                    
                }
            }

            foreach (HashSet<char> chars in filesList)
            {
                filesList[0].IntersectWith(chars);
            }

            List<char> finalList = new List<char>();

            foreach(char c in filesList[0])
            {
                finalList.Add(c);
            }

            finalList.Sort();

            foreach(char c in finalList)
            {
                Console.WriteLine(c);
            }
        }
    }
}
