namespace StockPriceMonitor.Model
{
    internal class Stock
    {
        private readonly string _ticker;
        private double _price = 100.0;

        public string Ticker { get { return _ticker; } }
        public double Price { get { return _price; } set { _price = value; } }

        public Stock(string ticker)
        {
            _ticker = ticker;
        }

    }
}
