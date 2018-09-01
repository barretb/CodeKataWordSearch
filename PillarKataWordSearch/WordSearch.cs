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
        private readonly int _blockSize;

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
            if (string.IsNullOrEmpty(searchword) || searchword.Length == 1) return $"{searchword}: "; //invalid word length
            var strCoords = "";

            //find a starting match
            var firstLetter = searchword[0];

            for (var startX = 0; startX < _blockSize; startX++)
            {
                for (var startY = 0; startY < _blockSize; startY++)
                {
                    if (LetterGrid[startX, startY] == firstLetter)
                    {
                        //found a start
                        var found = false;
                        var coords = new StringBuilder();
                        coords.Append($"({startY},{startX})"); //reverse coords to account for array vs math x,y grid thinking

                        for (var searchDirectionX = -1; searchDirectionX <= 1; searchDirectionX++)
                        {
                            if (found) break;
                            for (var searchDirectionY = -1; searchDirectionY <= 1; searchDirectionY++)
                            {
                                if (found) break;

                                if (searchDirectionX == 0 && searchDirectionY == 0) continue;
                                var currentX = startX;
                                var currentY = startY;

                                coords = new StringBuilder();
                                coords.Append($"({startY},{startX})"); //reverse coords to account for array vs math x,y grid thinking

                                for (var letter = 1; letter < searchword.Length; letter++)
                                {
                                    currentX = currentX + searchDirectionX;
                                    if (currentX < 0 || currentX >= _blockSize) break; //out of bounds
                                    currentY = currentY + searchDirectionY;
                                    if (currentY < 0 || currentY >= _blockSize) break; //out of bounds

                                    if (LetterGrid[currentX, currentY] != searchword[letter])
                                    {
                                        break;
                                    }

                                    coords.Append($",({currentY},{currentX})"); //reverse coords to account for array vs math x,y grid thinking

                                    if (letter == searchword.Length - 1)
                                    {
                                        found = true;
                                    }
                                }
                            }
                        }

                        if (found)
                        {
                            strCoords = coords.ToString();
                        }
                    }
                }
            }

            return $"{searchword}: {strCoords}";
        }

        public List<string> SearchWords(List<string> searchWords)
        {
            var results = new List<string>();
            foreach (var searchWord in searchWords)
            {
                results.Add(SearchWord(searchWord));
            }

            return results;
        }



    }
}
