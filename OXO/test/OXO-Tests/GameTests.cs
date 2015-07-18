using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OXO_Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void testShouldQuitReturnsFalseIfUserNotPrompted()
        {
            Game game = new Game();
            Assert.IsFalse(game.shouldQuit());
        }
        [TestMethod]
        public void testShouldQuitReturnsTrueWhenYEnteredAtPrompt()
        {
            Game game = new Game();
            Assert.IsFalse(game.shouldPlayAgain("N") );
        }
        [TestMethod]
        public void testShouldQuitReturnsTrueWhenYesEnteredAtPrompt()
        {
            Game game = new Game();
            Assert.IsFalse(game.shouldPlayAgain("No"));
        }
    }
}
