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
        private int _blockSize;

        public WordSearch(int blockSize, List<string> letterGridList)
        {
            _blockSize = blockSize;
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

        public string SearchWord(string searchword)
        {
            if (string.IsNullOrEmpty(searchword)) return "";

            //find a starting match
            var firstLetter = searchword.First();
            for (var startX = 0; startX < _blockSize; startX++)
            {
                for (var startY = 0; startY < _blockSize; startY++)
                {
                    if (LetterGrid[startX, startY] == firstLetter)
                    {
                        //found a start

                    }
                }
            }
        }

    }
}
