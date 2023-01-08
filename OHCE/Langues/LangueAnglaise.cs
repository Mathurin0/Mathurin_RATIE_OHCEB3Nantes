﻿namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;
        
        /// <inheritdoc />
        public string Bonjour(DayPeriod période) => Expressions.English.Bonjour;

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.AuRevoir;
    }
}
