namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

		/// <inheritdoc />
		public string Salutation(DayPeriod période)
		{
			if (période == DayPeriod.Matin)
			{
				return Expressions.English.BonjourMatin;

			}
			else if (période == DayPeriod.ApresMidi)
			{
				return Expressions.English.BonjourApresMidi;
			}
			else if (période == DayPeriod.Soir)
			{
				return Expressions.English.BonjourSoiree;
			}
			else if (période == DayPeriod.Nuit)
			{
				return Expressions.English.BonjourNuit;
			}
			else
			{
				return Expressions.English.Bonjour;
			}
		}

		/// <inheritdoc />
		public string AuRevoir(DayPeriod période)
		{
			if (période == DayPeriod.Matin)
			{
				return Expressions.English.AuRevoirMatin;

			}
			else if (période == DayPeriod.ApresMidi)
			{
				return Expressions.English.AuRevoirApresMidi;
			}
			else if (période == DayPeriod.Soir)
			{
				return Expressions.English.AuRevoirSoiree;
			}
			else if (période == DayPeriod.Nuit)
			{
				return Expressions.English.AuRevoirNuit;
			}
			else
			{
				return Expressions.English.AuRevoir;
			}
		}
	}
}
