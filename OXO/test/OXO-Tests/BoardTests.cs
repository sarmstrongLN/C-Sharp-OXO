using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OXO_Tests
{
    [TestClass]
    public class BoardTests
    {
        Board testSubject;

        public BoardTests()
        {
            testSubject = new Board();
        }

        public void setBoardFinishedNoWinner()
        {
            testSubject.resetBoard();
            testSubject.setTile(0, 'O');
            testSubject.setTile(1, 'O');
            testSubject.setTile(2, 'X');
            testSubject.setTile(3, 'X');
            testSubject.setTile(4, 'X');
            testSubject.setTile(5, 'O');
            testSubject.setTile(6, 'O');
            testSubject.setTile(7, 'O');
            testSubject.setTile(8, 'X');
        }

        [TestMethod]
        public void testFullBoardSetsFinishedFlag()
        {
            setBoardFinishedNoWinner();

            Assert.IsTrue(testSubject.isFinished());
            Assert.IsFalse(testSubject.hasWinner());
        }
        
        [TestMethod]
        public void testHorizontalLines()
        {
            for (int i = 0; i < 3; i++)
            {
                int tileOffset = i * 3;
                testSubject.resetBoard();
                testSubject.setTile(tileOffset, 'X');
                testSubject.setTile(tileOffset + 1, 'X');
                testSubject.setTile(tileOffset + 2, 'X');
                Assert.IsTrue(testSubject.isFinished());
                Assert.IsTrue(testSubject.hasWinner());
            }
        }

        [TestMethod]
        public void testVerticalLines()
        {
            for (int i = 0; i < 3; i++)
            {
                testSubject.resetBoard();
                testSubject.setTile(i, 'X');
                testSubject.setTile(i + 3, 'X');
                testSubject.setTile(i + 6, 'X');
                Assert.IsTrue(testSubject.isFinished());
                Assert.IsTrue(testSubject.hasWinner());
            }
        }

        [TestMethod]
        public void testDiagonalLines()
        {
            testSubject.resetBoard();
            testSubject.setTile(0, 'X');
            testSubject.setTile(4, 'X');
            testSubject.setTile(8, 'X');
            Assert.IsTrue(testSubject.isFinished());
            Assert.IsTrue(testSubject.hasWinner());

            testSubject.resetBoard();
            testSubject.setTile(2, 'X');
            testSubject.setTile(4, 'X');
            testSubject.setTile(6, 'X');
            Assert.IsTrue(testSubject.isFinished());
            Assert.IsTrue(testSubject.hasWinner());

        }
    }
}
