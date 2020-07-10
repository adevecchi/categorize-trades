Context
=======

A bank has a portfolio of thousands of trades and they need to be categorized.
A trade is a commercial negotiation between a bank and a client.
Each trade has a value that indicates the transaction amount in dollars and a
text indicating if the client´s sector is &quot;Public&quot; or &quot;Private&quot;. They implement the
following interface:

```csharp
interface ITrade
{
    double Value { get; }
    string ClientSector { get; }
}
```

**Currently, there are three categories:**

 - **LOWRISK**: Trades with value less than 1,000,000 and client from Public Sector

 - **MEDIUMRISK**: Trades with value greater than 1,000,000 and client from Public Sector

 - **HIGHRISK**: Trades with value greater than 1,000,000 and client from Private Sector

**Imagine you receive a list of trades and you need to return a list of categories as below:**

input: ``` List<ITrade> portfolio ```

output: ``` List<string> tradeCategories ```

**Example:**

Input:
```csharp
Trade1 { Value = 2000000; ClientSector = "Private" }
Trade2 { Value = 400000; ClientSector = "Public" }
Trade3 { Value = 500000; ClientSector = "Public" }
Trade4 { Value = 3000000; ClientSector = "Public" }

portfolio = { Trade1, Trade2, Trade3, Trade4 }
```
 
Output:
```csharp
tradeCategories = { "HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK" }
```

Keep in mind that category rules may be added/removed/modified
in the future and be highly complex.

Project file structure
----------------------

![Project file structure](https://github.com/adevecchi/categorize-trades/blob/master/images/structure.png)

Output
------

![Project file structure](https://github.com/adevecchi/categorize-trades/blob/master/images/output.png)
