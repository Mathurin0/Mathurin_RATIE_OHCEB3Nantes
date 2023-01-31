namespace OHCE.Console.Adapters
{
	internal static class SystemTimeDayPeriodAdapter
	{
		public static DayPeriod ActualPeriod => DateTime.Now.Hour switch
				{
					< 6  => DayPeriod.Nuit,
					< 12 => DayPeriod.Matin,
					< 18 => DayPeriod.ApresMidi,
					< 21 => DayPeriod.Soir,
					_    => DayPeriod.Nuit
				};
	}
}