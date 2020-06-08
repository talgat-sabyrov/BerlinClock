using BerlinClock.Abstract;
using BerlinClock.Helpers;
using System;
using System.Text;

namespace BerlinClock.BusinessLogic
{
    public class OneMinutesRow : IOneMinutesRow
    {
        public string Get(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new Exception();

            int n = minute % 5;
            StringBuilder res = new StringBuilder();
            for (int i = 1; i <= n; i++)
                res.Append(Constants.OneMinutesYellow);

            for (int i = n + 1; i <= 4; i++)
                res.Append(Constants.OneMinutesNone);

            return res.ToString();
        }
    }
}
