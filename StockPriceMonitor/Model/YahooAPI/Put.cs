public class Put
{
    public string contractSymbol { get; set; }
    public double strike { get; set; }
    public string currency { get; set; }
    public double lastPrice { get; set; }
    public double change { get; set; }
    public double percentChange { get; set; }
    public int volume { get; set; }
    public int openInterest { get; set; }
    public double bid { get; set; }
    public double ask { get; set; }
    public string contractSize { get; set; }
    public int expiration { get; set; }
    public int lastTradeDate { get; set; }
    public double impliedVolatility { get; set; }
    public bool inTheMoney { get; set; }
}
