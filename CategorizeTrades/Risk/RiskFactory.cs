using System;

namespace CategorizeTrades.Risk
{
    static class RiskFactory
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "LowRisk":
                    return new LowRisk();
                case "MediumRisk":
                    return new MediumRisk();
                case "HighRisk":
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
