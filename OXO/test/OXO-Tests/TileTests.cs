using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OXO_Tests
{
    [TestClass]
    public class TileTests
    {
        Tile testSubject;

        public TileTests() {
            testSubject = new Tile();    
        }

        [TestMethod]
        public void testDefaultValueIsASpace() {
            Assert.AreEqual(' ', testSubject.getValue());
        }

        [TestMethod]
        public void testValueIsAnOAfterSet() {
            testSubject.setValue('O');
            Assert.AreEqual('O', testSubject.getValue());
        }
    }
}
