using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OXO_Tests
{
    [TestClass]
    public class PlayerTests
    {
        Player testSubject;

        public PlayerTests() {
            testSubject = new Player();
        }

        [TestMethod]
        public void testPlayerNameDefaultsToPlayer() {
            testSubject = new Player();
            Assert.AreEqual("Player", testSubject.getName());
        }

        [TestMethod]
        public void testPlayerNameStoredWhenSet() {
            testSubject = new Player();
            testSubject.setName("Tony Stark");
            Assert.AreEqual("Tony Stark", testSubject.getName());
        }

        [TestMethod]
        public void testMoveWithinBoardRange() {
            //Arbitrary value as this will be provided by the Game
            int maxTileId = 12;
            
            int chosenTile = testSubject.pickTile(maxTileId);
            Assert.IsTrue(chosenTile >= 0);
            Assert.IsTrue(chosenTile <= maxTileId);
        }
    }
}
