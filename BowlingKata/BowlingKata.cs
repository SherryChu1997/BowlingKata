using System;
using System.Security.Permissions;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKata
{
    [TestClass]
    public class Bowling
    {
        [TestMethod]
        public void testAllOne()
        {
            Game g = new Game();
            for (int i = 1; i <= 20; i++)
            {
                g.roll(1);
            }
            Assert.AreEqual(20, g.totalscore());
        }

        [TestMethod]
        public void testAllZero()
        {
            Game g = new Game();
            for (int i = 1; i <= 20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.totalscore());
        }
    }
}