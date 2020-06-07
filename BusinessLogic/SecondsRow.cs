using BerlinClock.Abstract;
using BerlinClock.Helpers;
using System;

namespace BerlinClock.BusinessLogic
{
    public class SecondsRow : ISecondsRow
    {
        public string Get(int second)
        {
            if (second < 0 || second > 59)
                throw new Exception();

            return second % 2 == 0 ? Constants.SecondsYellow : Constants.SecondsNone;
        }
    }
}
