using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OXO_Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void testGameShouldQuitReturnsTrueWhenYEnteredAtPrompt() {
            Game game = new Game();
            Assert.IsFalse(game.shouldPlayAgain("N") );
        }
        [TestMethod]
        public void testGameShouldQuitReturnsTrueWhenYesEnteredAtPrompt() {
            Game game = new Game();
            Assert.IsFalse(game.shouldPlayAgain("No"));
        }
    }
}
