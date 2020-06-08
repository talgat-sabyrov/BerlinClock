using BerlinClock.Abstract;
using BerlinClock.Helpers;
using System;
using System.Text;

namespace BerlinClock.BusinessLogic
{
    public class FiveMinutesRow : IFiveMinutesRow
    {
        public string Get(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new Exception();

            int n = minute / 5;
            StringBuilder res = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (i%3 == 0)
                    res.Append(Constants.FiveMinutesRed);
                else
                    res.Append(Constants.FiveMinutesYellow);
            }                

            for (int i = n + 1; i <= 11; i++)
                res.Append(Constants.FiveMinutesNone);

            return res.ToString();
        }
    }
}
