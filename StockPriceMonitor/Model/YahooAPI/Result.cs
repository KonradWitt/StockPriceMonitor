using System.Collections.Generic;

public class Result
{
    public string underlyingSymbol { get; set; }
    public List<int> expirationDates { get; set; }
    public List<double> strikes { get; set; }
    public bool hasMiniOptions { get; set; }
    public Quote quote { get; set; }
    public List<Option> options { get; set; }
}
