using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class HighRisk : IRisk
    {
        public string Type { get; private set; }

        public HighRisk()
        {
            this.Type = NoneRisk.NONERISK.ToString();
        }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Private.ToString()))
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }

            return false;
        }
    }
}
