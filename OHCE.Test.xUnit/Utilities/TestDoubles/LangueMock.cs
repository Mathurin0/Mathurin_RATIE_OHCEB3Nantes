namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;

        public string Salutation(DayPeriod période) => string.Empty; 

        public string AuRevoir(DayPeriod période) => string.Empty;
	}
}
