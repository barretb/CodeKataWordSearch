using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PillarKataWordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args[0];
            string searchWords;
                var searchGrid = new List<string>();
            int size;

            using (var stream = new StreamReader(file))
            {
                searchWords = stream.ReadLine();
                if (string.IsNullOrEmpty(searchWords))
                {
                    Console.WriteLine("INVALID DATA FILE - FIRST ROW EMPTY");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                var line = stream.ReadLine();
                while (null != line)
                {
                    searchGrid.Add(line);
                    line = stream.ReadLine();
                }

                var columns = searchGrid.First().Split(',').Length;
                var rows = searchGrid.Count;
                if (columns != rows)
                {
                    Console.WriteLine("INVALID DATA FILE - LETTER GRID IS NOT SQUARE");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                size = rows;
            }

            var search = new WordSearch(size, searchGrid);
            var wordList = searchWords.Split(',').ToList();
            var results = search.SearchWords(wordList);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }


            Console.ReadLine();
        }
    }
}
