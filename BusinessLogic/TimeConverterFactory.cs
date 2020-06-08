namespace BerlinClock.BusinessLogic
{
    public class TimeConverterFactory
    {
        public TimeConverter Create()
        {
            return new TimeConverter(new SecondsRow(),
                                     new FiveHoursRow(),
                                     new OneHoursRow(),
                                     new FiveMinutesRow(),
                                     new OneMinutesRow());
        }
    }
}
