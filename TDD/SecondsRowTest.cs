using BerlinClock.BusinessLogic;
using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public class SecondsRowTest
    {
        private SecondsRow SecondsRow = new SecondsRow();

        [TestMethod]
        public void SecondsRowIn0OutYellow()
        {
            var expected = Constants.SecondsYellow;
            
            var actual = SecondsRow.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondsRowIn1OutNone()
        {
            var expected = Constants.SecondsNone;

            var actual = SecondsRow.Get(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondsRowIn59OutNone()
        {
            var expected = Constants.SecondsNone;

            var actual = SecondsRow.Get(59);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondsRowIn8OutY()
        {
            var expected = Constants.SecondsYellow;

            var actual = SecondsRow.Get(8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondsRowIn60OutExpection()
        {
            Exception expectedExcetpion = null;

            try
            {
                SecondsRow.Get(60);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
