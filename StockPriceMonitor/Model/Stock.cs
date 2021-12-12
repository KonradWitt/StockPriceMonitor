using System;

namespace StockPriceMonitor.Model
{
    internal class Stock : PropertyChangedBase
    {
        private readonly string _ticker;
        private double _price;
        private PriceChange _priceChange;

        public Stock(string ticker, double price)
        {
            _ticker = ticker;
            _price = price;
        }

        public string Ticker { get { return _ticker; } }
        public double Price
        {
            get { return _price; }
            private set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged();
                }
            }
        }
        public PriceChange PriceChange
        {
            get
            { return _priceChange; }
            private set
            {
                if (_priceChange != value)
                {
                    _priceChange = value;
                    OnPropertyChanged();
                }
            }
        }

        public void UpdatePrice(double newPrice)
        {
            PriceChange = CheckPriceChange(newPrice);
            Price = newPrice;
        }

        private PriceChange CheckPriceChange(double newPrice)
        {
            double priceDifference = newPrice - _price;
            switch (priceDifference)
            {
                case > 0:
                    return PriceChange.Up;
                case < 0:
                    return PriceChange.Down;
                default:
                    return PriceChange.NoChange;
            }
        }

        public void ResetPriceChange()
        {
            PriceChange = PriceChange.Offline;
        }
    }
}
