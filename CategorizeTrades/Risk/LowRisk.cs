using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class LowRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value < 1000000 && trade.ClientSector.Equals(SectorRisk.Public.ToString()))
            {
                this.Type = TypeRisk.LowRisk.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
