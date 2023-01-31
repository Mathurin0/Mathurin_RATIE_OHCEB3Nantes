using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(DayPeriod.Soir, Expressions.Français.BonjourSoiree)]
        [InlineData(DayPeriod.Matin, Expressions.Français.BonjourMatin)]
        public void BonjourTest(DayPeriod période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis bonjour
            var salutation = langue.Salutation(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }
	}
}
