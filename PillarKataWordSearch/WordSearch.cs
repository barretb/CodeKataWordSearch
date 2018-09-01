﻿using System;
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
            if (string.IsNullOrEmpty(searchword) || searchword.Length == 1) return ""; //invalid word length

            //find a starting match
            var firstLetter = searchword[0];
            var secondLetter = searchword[1];

            for (var startX = 0; startX < _blockSize; startX++)
            {
                for (var startY = 0; startY < _blockSize; startY++)
                {
                    if (LetterGrid[startX, startY] == firstLetter)
                    {
                        //found a start
                        int xChange = 0;
                        int yChange = 0;

                        for (var searchX = -1; searchX <= 1; searchX++)
                        {
                            for (var searchY = -1; searchY <= 1; searchY++)
                            {
                                var currentX = startX + searchX;
                                if(currentX < 0 || currentX >= _blockSize) continue; //out of bounds
                                var currentY = startY + searchY;
                                if(currentY < 0 || currentY >= _blockSize) continue; //out of bounds

                                if (LetterGrid[currentX, currentY] == secondLetter)
                                {
                                    //found a direction to check

                                } 
                            }
                        }

                    }
                }
            }

            return "";
        }


    }
}
