using BerlinClock.Abstract;
using BerlinClock.Helpers;
using System;
using System.Text;

namespace BerlinClock.BusinessLogic
{
    public class FiveHoursRow : IFiveHoursRow
    {
        public string Get(int hours)
        {
            if (hours < 0 || hours > 24)
                throw new Exception();

            int div = hours / 5;
            StringBuilder res = new StringBuilder();
            for (int i=1;i<=div;i++)
                res.Append(Constants.FiveHoursRed);

            for (int i=div+1;i<=4;i++)
                res.Append(Constants.FiveHoursNone);

            return res.ToString();
        }
    }
}
