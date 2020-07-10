using System;
using System.Collections.Generic;
using CategorizeTrades.Risk;
using CategorizeTrades.Trades;

namespace CategorizeTrades.Categories
{
    class Category
    {
        private List<ITrade> portfolio;

        public Category(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<TypeRisk> risks = new List<TypeRisk> { TypeRisk.LowRisk, TypeRisk.MediumRisk, TypeRisk.HighRisk };

            foreach (Trade trade in portfolio)
            {
                foreach (TypeRisk r in Enum.GetValues(typeof(TypeRisk)))
                {
                    risk = RiskFactory.Create(r);

                    if (trade.CalculateRisk(risk))
                    {
                        break;
                    }
                }

                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
