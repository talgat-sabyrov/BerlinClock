using BerlinClock.BusinessLogic;
using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public class OneMinutesRowTest
    {
        private OneMinutesRow oneMinutesRow = new OneMinutesRow();

        [TestMethod]
        public void OneMinuterRowTestIn0OutOOOO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneMinutesNone,
                                            Constants.OneMinutesNone,
                                            Constants.OneMinutesNone,
                                            Constants.OneMinutesNone);

            var actual = oneMinutesRow.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinuterRowTestIn17OutYYOO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneMinutesYellow,
                                            Constants.OneMinutesYellow,
                                            Constants.OneMinutesNone,
                                            Constants.OneMinutesNone);

            var actual = oneMinutesRow.Get(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinuterRowTestIn59OutYYYY()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.OneMinutesYellow,
                                            Constants.OneMinutesYellow,
                                            Constants.OneMinutesYellow,
                                            Constants.OneMinutesYellow);

            var actual = oneMinutesRow.Get(59);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinuterRowTestIn60OutException()
        {
            Exception expectedException = null;

            try
            {
                oneMinutesRow.Get(60);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}
