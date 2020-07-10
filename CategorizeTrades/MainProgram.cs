using System;
using System.Collections.Generic;
using CategorizeTrades.Trades;
using CategorizeTrades.Categories;

namespace CategorizeTrades
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<ITrade> portfolio;
            List<string> tradeCategories;

            Trade trade1 = new Trade { Value = 2000000, ClientSector = "Private" };
            Trade trade2 = new Trade { Value = 400000, ClientSector = "Public" };
            Trade trade3 = new Trade { Value = 500000, ClientSector = "Public" };
            Trade trade4 = new Trade { Value = 3000000, ClientSector = "Public" };

            portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };

            tradeCategories = new Category(portfolio).GetCategories();

            // Output console
            Console.Title = "Categories of Trades";
            Console.WriteLine("Input:\n");
            foreach (ITrade trade in portfolio)
            {
                Console.WriteLine("{0} = {{ Value = {1}, ClientSector = \"{2}\" }}", (Trade)trade, trade.Value, trade.ClientSector);
            }
            Console.WriteLine("\nportfolio = {{ {0}, {1}, {2}, {3} }}", trade1, trade2, trade3, trade4);
            Console.WriteLine("\nOutput:\n");
            Console.WriteLine("tradeCategories = {{ \"{0}\", \"{1}\", \"{2}\", \"{3}\" }}", tradeCategories[0], tradeCategories[1], tradeCategories[2], tradeCategories[3]);
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
