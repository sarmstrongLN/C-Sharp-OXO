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
            game.promptForQuit("Y");
            Assert.IsTrue(game.shouldQuit());
        }
        [TestMethod]
        public void testShouldQuitReturnsTrueWhenYesEnteredAtPrompt()
        {
            Game game = new Game();
            game.promptForQuit("Yes");
            Assert.IsTrue(game.shouldQuit());
        }
    }
}
