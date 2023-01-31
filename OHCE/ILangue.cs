namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string Salutation(DayPeriod période);
        string AuRevoir(DayPeriod période);
	}
}
