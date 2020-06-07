using System;

namespace BerlinClock.Abstract
{
    public abstract class TimeConverterBase
    {
        private const int HoursIndex = 0;
        private const int MinutesIndex = 1;
        private const int SecondsIndex = 2;
        public string Convert(string aTime)
        {
            var parts = aTime.Split(':');
            var res = SecondsRow(int.Parse(parts[SecondsIndex])) + Environment.NewLine +
                      FiveHoursRow(int.Parse(parts[HoursIndex])) + Environment.NewLine +
                      OneHoursRow(int.Parse(parts[HoursIndex])) + Environment.NewLine +
                      FiveMinutesRow(int.Parse(parts[MinutesIndex])) + Environment.NewLine +
                      OneMinutesRow(int.Parse(parts[MinutesIndex]));

            return res;
        }

        protected abstract string SecondsRow(int second);
        protected abstract string FiveHoursRow(int hour);
        protected abstract string OneHoursRow(int hour);
        protected abstract string FiveMinutesRow(int minute);
        protected abstract string OneMinutesRow(int minute);
    }
}
