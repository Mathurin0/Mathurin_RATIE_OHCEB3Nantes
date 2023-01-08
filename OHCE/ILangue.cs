namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string Bonjour(DayPeriod période);
        string AuRevoir { get; }
    }
}
