using StockPriceMonitor.Model;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace StockPriceMonitor.Converters
{
    internal class PriceChangeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is PriceChange priceChange))
            {
                throw new ArgumentException($"Value must be {typeof(PriceChange)}");
            }

            switch(priceChange)
            {
                case PriceChange.Up: return new SolidColorBrush(Color.FromRgb(0, 255, 0));
                case PriceChange.Down: return new SolidColorBrush(Color.FromRgb(255, 0, 0));
                case PriceChange.NoChange: return new SolidColorBrush(Color.FromRgb(255,255,255));
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
