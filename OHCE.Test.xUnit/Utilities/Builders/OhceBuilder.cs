using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private DayPeriod _périodeJournée = DayPeriod.Defaut;
        private ILangue _langue = new LangueMock();

        public static Ohce Default => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue, _périodeJournée);
        
        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }

        public OhceBuilder AyantPourPériodeDeLaJournée(DayPeriod période)
        {
            _périodeJournée = période;
            return this;
        }
    }
}
