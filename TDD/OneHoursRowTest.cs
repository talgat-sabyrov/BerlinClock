using BerlinClock.BusinessLogic;
using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public class OneHoursRowTest
    {
        private OneHoursRow oneHoursRow = new OneHoursRow();

        [TestMethod]
        public void OneHoursRowTestIn0OutOOOO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneHoursNone,
                                            Constants.OneHoursNone,
                                            Constants.OneHoursNone,
                                            Constants.OneHoursNone);

            var actual = oneHoursRow.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHoursRowTestIn17OutRRRO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursNone,
                                            Constants.OneHoursNone);

            var actual = oneHoursRow.Get(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHoursRowTestIn13OutRRRO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursNone);

            var actual = oneHoursRow.Get(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHoursRowTestIn23OutRRRO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursNone);

            var actual = oneHoursRow.Get(23);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHoursRowTestIn24OutRRRR()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed,
                                            Constants.OneHoursRed);

            var actual = oneHoursRow.Get(24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHoursRowTestIn25OutException()
        {
            Exception expectedException = null;

            try
            {
                oneHoursRow.Get(25);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}
