using BerlinClock.Abstract;
using BerlinClock.Helpers;
using System;
using System.Text;

namespace BerlinClock.BusinessLogic
{
    public class OneHoursRow : IOneHoursRow
    {
        public string Get(int hour)
        {
            if (hour < 0 || hour > 24)
                throw new Exception();

            int n = hour % 5;
            StringBuilder res = new StringBuilder();
            for (int i = 1; i <= n; i++)
                res.Append(Constants.OneHoursRed);

            for (int i = n + 1; i <= 4; i++)
                res.Append(Constants.OneHoursNone);

            return res.ToString();
        }
    }
}
