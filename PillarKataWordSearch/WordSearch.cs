using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PillarKataWordSearch
{
    public class WordSearch
    {
        private readonly char[,] _letterGrid;
        public char[,] LetterGrid => _letterGrid;

        public WordSearch(int blockSize, List<string> letterGridList)
        {
            _letterGrid = new char[blockSize, blockSize];
            for (var x = 0; x < blockSize; x++)
            {
                var listRow = letterGridList[x].Split(',');
                for (var y = 0; y < blockSize; y++)
                {
                    _letterGrid[x, y] = listRow[y].FirstOrDefault();
                }
            }
        }

    }
}
