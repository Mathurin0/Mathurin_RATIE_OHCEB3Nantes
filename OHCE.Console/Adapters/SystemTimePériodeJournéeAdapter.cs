namespace OHCE.Console.Adapters
{
	internal static class SystemTimeDayPeriodAdapter
	{
		public static DayPeriod ActualPeriod => DateTime.Now.Hour switch
				{
					< 6  => DayPeriod.Night,
					< 12 => DayPeriod.Morning,
					< 18 => DayPeriod.Afternoon,
					< 21 => DayPeriod.Evening,
					_    => DayPeriod.Night
				};
	}
}