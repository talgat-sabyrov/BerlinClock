using BerlinClock.BusinessLogic;
using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public class FiveMinutesRowTest
    {
        private FiveMinutesRow fiveMinutesRow = new FiveMinutesRow();

        [TestMethod]
        public void FiveMinutesRowIn0OutOOOOOOOOOOO()
        {
            var expected = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone);

            var actual = fiveMinutesRow.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveMinutesRowIn17OutYYROOOOOOOO()
        {
            var expected = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesRed,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone,
                                           Constants.FiveMinutesNone);

            var actual = fiveMinutesRow.Get(17);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveMinutesRowIn59OutYYRYYRYYRYY()
        {
            var expected = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesRed,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesRed,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesRed,
                                           Constants.FiveMinutesYellow,
                                           Constants.FiveMinutesYellow);

            var actual = fiveMinutesRow.Get(59);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveMinutesRowIn60OutException()
        {
            Exception expectedExcetpion = null;

            try
            {
                fiveMinutesRow.Get(60);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
