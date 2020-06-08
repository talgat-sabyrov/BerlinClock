using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BerlinClock.Abstract;
using BerlinClock.BusinessLogic;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private TimeConverterFactory factory = new TimeConverterFactory();
        private TimeConverterBase berlinClock;
        private String theTime;

        
        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            berlinClock = factory.Create();
            theTime = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(berlinClock.Convert(theTime), theExpectedBerlinClockOutput);
        }

    }
}
