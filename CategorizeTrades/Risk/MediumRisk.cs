using CategorizeTrades.Trades;

namespace CategorizeTrades.Risk
{
    class MediumRisk : IRisk
    {
        public string Type { get; private set; }

        public MediumRisk()
        {
            this.Type = NoneRisk.NONERISK.ToString();
        }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Public.ToString()))
            {
                this.Type = TypeRisk.MediumRisk.ToString().ToUpper();

                return true;
            }

            return false;
        }
    }
}
