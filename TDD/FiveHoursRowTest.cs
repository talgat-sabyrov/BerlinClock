using BerlinClock.BusinessLogic;
using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public class FiveHoursRowTest
    {
        private FiveHoursRow fiveHoursRow = new FiveHoursRow();

        [TestMethod]
        public void FiveHoursRowTestIn13OutRROO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursNone,
                                            Constants.FiveHoursNone);

            var actual = fiveHoursRow.Get(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveHoursRowTestIn23OutRRRR()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed);

            var actual = fiveHoursRow.Get(23);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveHoursRowTestIn0OutOOOO()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.FiveHoursNone,
                                            Constants.FiveHoursNone,
                                            Constants.FiveHoursNone,
                                            Constants.FiveHoursNone);

            var actual = fiveHoursRow.Get(0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveHoursRowTestIn24OutRRRR()
        {
            var expected = string.Format("{0}{1}{2}{3}",
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed,
                                            Constants.FiveHoursRed);

            var actual = fiveHoursRow.Get(24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveHoursRowTestIn25OutException()
        {
            Exception expectedExcetpion = null;

            try
            {
                fiveHoursRow.Get(25);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
