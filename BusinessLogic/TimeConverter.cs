using BerlinClock.Abstract;

namespace BerlinClock.BusinessLogic
{
    public class TimeConverter : TimeConverterBase
    {
        private readonly ISecondsRow _secondsRow;
        private readonly IFiveHoursRow _fiveHoursRow;
        private readonly IOneHoursRow _oneHoursRow;
        private readonly IFiveMinutesRow _fiveMinutesRow;
        private readonly IOneMinutesRow _oneMinutesRow;
        public TimeConverter(ISecondsRow secondsRow,
                            IFiveHoursRow fiveHoursRow,
                            IOneHoursRow oneHoursRow,
                            IFiveMinutesRow fiveMinutesRow,
                            IOneMinutesRow oneMinutesRow)
        {
            _secondsRow = secondsRow;
            _fiveHoursRow = fiveHoursRow;
            _oneHoursRow = oneHoursRow;
            _fiveMinutesRow = fiveMinutesRow;
            _oneMinutesRow = oneMinutesRow;
        }
        protected override string SecondsRow(int second)
        {
            return _secondsRow.Get(second);
        }
        protected override string FiveHoursRow(int hour)
        {
            return _fiveHoursRow.Get(hour);
        }

        protected override string OneHoursRow(int hour)
        {
            return _oneHoursRow.Get(hour);
        }

        protected override string FiveMinutesRow(int minute)
        {
            return _fiveMinutesRow.Get(minute);
        }

        protected override string OneMinutesRow(int minute)
        {
            return _oneMinutesRow.Get(minute);
        }
    }
}
