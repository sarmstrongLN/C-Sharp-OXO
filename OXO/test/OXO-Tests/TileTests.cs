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

        public TileTests()
        {
            testSubject = new Tile();    
        }

        [TestMethod]
        public void TestDefaultValueIsASpace()
        {
            Assert.AreEqual(' ', testSubject.getValue());
        }

        [TestMethod]
        public void TestValueIsAnOAfterSet()
        {
            testSubject.setValue('O');
            Assert.AreEqual('O', testSubject.getValue());
        }
    }
}
