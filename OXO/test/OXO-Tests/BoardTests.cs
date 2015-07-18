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
        public void testBoardFullBoardSetsFinishedFlag()
        {
            setBoardFinishedNoWinner();

            Assert.IsTrue(testSubject.isFinished());
            Assert.IsFalse(testSubject.hasWinner());
        }
        
        [TestMethod]
        public void testBoardHorizontalLines()
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
        public void testBoardVerticalLines()
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
        public void testBoardDiagonalLines()
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

        [TestMethod]
        public void testBoardWillNotSetAlreadySetTile()
        {
            testSubject.resetBoard();
            testSubject.setTile(0, 'X');
            Assert.IsFalse(testSubject.setTile(0, 'O'));
        }

        [TestMethod]
        public void testBoardResetClearsAllTiles()
        {
            testSubject.resetBoard();
            setBoardFinishedNoWinner();
            for (int i = 0; i < testSubject.getTiles().GetLength(0); i++)
            {
                Assert.IsFalse(testSubject.isTileFree(i));
            }
            testSubject.resetBoard();
            for (int i = 0; i < testSubject.getTiles().GetLength(0); i++)
            {
                Assert.IsTrue(testSubject.isTileFree(i));
            }
        }
    }
}
