
namespace CategorizeTrades.Trades
{
    interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
