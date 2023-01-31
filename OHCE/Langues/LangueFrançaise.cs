namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string Salutation(DayPeriod période)
        {
            if (période == DayPeriod.Matin)
            {
                return Expressions.Français.BonjourMatin;

            }
            else if (période == DayPeriod.ApresMidi)
            {
                return Expressions.Français.BonjourApresMidi;
            }
            else if (période == DayPeriod.Soir)
            {
                return Expressions.Français.BonjourSoiree;
            }
            else if (période == DayPeriod.Nuit)
            {
                return Expressions.Français.BonjourNuit;
            }
            else
            {
                return Expressions.Français.Bonjour;
            }
        }

        /// <inheritdoc />
        public string AuRevoir(DayPeriod période)
        {
			if (période == DayPeriod.Matin)
			{
				return Expressions.Français.AuRevoirMatin;

			}
			else if (période == DayPeriod.ApresMidi)
			{
				return Expressions.Français.AuRevoirApresMidi;
			}
			else if (période == DayPeriod.Soir)
			{
				return Expressions.Français.AuRevoirSoiree;
			}
			else if (période == DayPeriod.Nuit)
			{
				return Expressions.Français.AuRevoirNuit;
			}
			else
			{
				return Expressions.Français.AuRevoir;
			}
		}
    }
}
