using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarKataWordSearch;

namespace PillarKataWordSearchTest
{
    [TestClass]
    public class WordSearchTest
    {
        private WordSearch search;

        [TestInitialize]
        public void TestSetup()
        {
            var blockSize = 15;
            var letterblocks = new List<string>();
            letterblocks.Add("U,M,K,H,U,L,K,I,N,V,J,O,C,W,E");
            letterblocks.Add("L,L,S,H,K,Z,Z,W,Z,C,G,J,U,Y,G");
            letterblocks.Add("H,S,U,P,J,P,R,J,D,H,S,B,X,T,G");
            letterblocks.Add("B,R,J,S,O,E,Q,E,T,I,K,K,G,L,E");
            letterblocks.Add("A,Y,O,A,G,C,I,R,D,Q,H,R,T,C,D");
            letterblocks.Add("S,C,O,T,T,Y,K,Z,R,E,P,P,X,P,F");
            letterblocks.Add("B,L,Q,S,L,N,E,E,E,V,U,L,F,M,Z");
            letterblocks.Add("O,K,R,I,K,A,M,M,R,M,F,B,A,P,P");
            letterblocks.Add("N,U,I,I,Y,H,Q,M,E,M,Q,R,Y,F,S");
            letterblocks.Add("E,Y,Z,Y,G,K,Q,J,P,C,Q,W,Y,A,K");
            letterblocks.Add("S,J,F,Z,M,Q,I,B,D,B,E,M,K,W,D");
            letterblocks.Add("T,G,L,B,H,C,B,E,C,H,T,O,Y,I,K");
            letterblocks.Add("O,J,Y,E,U,L,N,C,C,L,Y,B,Z,U,H");
            letterblocks.Add("W,Z,M,I,S,U,K,U,R,B,I,D,U,X,S");
            letterblocks.Add("K,Y,L,B,Q,Q,P,M,D,F,C,K,E,A,B");

            search = new WordSearch(blockSize, letterblocks);
        }


        [TestMethod]
        public void TestGridSuccessfullySetup()
        {
            search.
            return ;
        }
    }
}
