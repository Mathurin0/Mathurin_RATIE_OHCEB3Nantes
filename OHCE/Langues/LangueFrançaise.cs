namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string Bonjour(DayPeriod période)
        {
            return période == DayPeriod.Evening 
                ? Expressions.Français.Bonsoir 
                : Expressions.Français.Bonjour;
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}
