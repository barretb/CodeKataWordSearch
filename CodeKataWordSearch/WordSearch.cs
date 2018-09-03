using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodeKataWordSearch
{
    public class WordSearch
    {
        public char[,] LetterGrid { get; }
        private readonly int _blockSize;

        public WordSearch(int blockSize, IReadOnlyList<string> letterGridList)
        {
            _blockSize = blockSize;
            LetterGrid = new char[blockSize, blockSize];
            for (var x = 0; x < blockSize; x++)
            {
                var listRow = letterGridList[x].Split(',');
                for (var y = 0; y < blockSize; y++)
                {
                    LetterGrid[x, y] = listRow[y].FirstOrDefault();
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
                    if (LetterGrid[startX, startY] != firstLetter) continue;

                    //found a start
                    var foundFullWordMatch = false;
                    var resultCoordinates = new StringBuilder();
                    resultCoordinates.Append($"({startY},{startX})"); //reverse coords to account for array vs math x,y grid thinking

                    // once we've found a matching start letter, search the grid in each direction for the full word
                    for (var searchDirectionX = -1; searchDirectionX <= 1; searchDirectionX++)
                    {
                        if (foundFullWordMatch) break;
                        for (var searchDirectionY = -1; searchDirectionY <= 1; searchDirectionY++)
                        {
                            if (foundFullWordMatch) break;

                            if (searchDirectionX == 0 && searchDirectionY == 0) continue;
                            var currentX = startX;
                            var currentY = startY;

                            resultCoordinates = new StringBuilder();
                            resultCoordinates.Append($"({startY},{startX})"); //reverse coords to account for array vs math x,y grid thinking

                            for (var wordLetterPosition = 1; wordLetterPosition < searchword.Length; wordLetterPosition++)
                            {
                                currentX = currentX + searchDirectionX;
                                if (currentX < 0 || currentX >= _blockSize) break; //out of bounds
                                currentY = currentY + searchDirectionY;
                                if (currentY < 0 || currentY >= _blockSize) break; //out of bounds

                                if (LetterGrid[currentX, currentY] != searchword[wordLetterPosition])
                                {
                                    break;
                                }

                                resultCoordinates.Append($",({currentY},{currentX})"); //reverse coords to account for array vs math x,y grid thinking

                                if (wordLetterPosition == searchword.Length - 1)
                                {
                                    foundFullWordMatch = true;
                                }
                            }
                        }
                    }
                    
                    if (foundFullWordMatch)
                    {
                        strCoords = resultCoordinates.ToString();
                    }
                }
            }

            return $"{searchword}: {strCoords}";
        }

        public List<string> SearchWords(IEnumerable<string> searchWords)
        {
            return searchWords.Select(SearchWord).ToList();
        }
    }
}
