using System;
using System.Security.Permissions;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKata
{
    [TestClass]
    public class Bowling
    {
        internal Game g = new Game();

        [TestMethod]
        public void testAllOne()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, g.totalscore());
        }

        [TestMethod]
        public void testAllZero()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, g.totalscore());
        }

        private void RollMany(int times, int pins)
        {
            for (int i = 1; i <= times; i++)
            {
                g.roll(pins);
            }
        }
    }
}