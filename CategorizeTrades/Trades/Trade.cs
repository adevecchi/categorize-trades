using CategorizeTrades.Risk;

namespace CategorizeTrades.Trades
{
    class Trade : ITrade
    {
        private static int tradeID = 1;

        private string name;

        public double Value { get; set; }
        public string ClientSector { get; set; }

        public Trade()
        {
            this.name = "Trade" + tradeID++;
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
