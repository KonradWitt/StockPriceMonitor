using StockPriceMonitor.Commands;
using StockPriceMonitor.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Linq;

namespace StockPriceMonitor.ViewModel
{
    internal class MainWindowContext : PropertyChangedBase
    {
        private DispatcherTimer _dispatcherTimer;
        private TimeSpan _dispatcherTimerInterval = new TimeSpan(0, 0, 3);
        private string _searchText;
        private string _userMessage;
        private Action<object> _deleteTicker;

        public MainWindowContext()
        {
            InitializeCommands();

            ApiHelper.InitializeClient();

            FavoriteStocks = new();
            _dispatcherTimer = new DispatcherTimer() { Interval = _dispatcherTimerInterval };
            _dispatcherTimer.Tick += DispatcherTimerTick;
        }

        public ICommand AddTicker { get; private set; }
        public ICommand DeleteTicker { get; private set; }
        public ICommand StartMonitoring { get; private set; }
        public ICommand StopMonitoring { get; private set; }
        public ObservableCollection<Stock> FavoriteStocks { get; private set; }

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                if (_userMessage != value)
                {
                    _userMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        private void InitializeCommands()
        {
            _deleteTicker = DeleteTicker_Execute;

            AddTicker = new Command(p => AddTicker_CanExecute(), p => AddTicker_Execute());
            DeleteTicker = new Command(p => DeleteTicker_CanExecute(), _deleteTicker);
            StartMonitoring = new Command(p => StartMonitoring_CanExecute(), p => StartMonitoring_Execute());
            StopMonitoring = new Command(p => StopMonitoring_CanExecute(), p => StopMonitoring_Execute());
        }

        private bool AddTicker_CanExecute()
        {
            return !string.IsNullOrEmpty(_searchText);
        }

        private async void AddTicker_Execute()
        {
            UserMessage = string.Empty;

            if (!FavoriteStocks.Any(x => x.Ticker == _searchText.ToUpper()))
            {
                YahooQuery yahooQuery = new();
                var stockData = await yahooQuery.GetTickerData(_searchText);

                if (yahooQuery.CheckIfResultsValid(stockData.optionChain))
                {
                    Result result = stockData.optionChain.result.First();

                    string ticker = result.underlyingSymbol;
                    double price = result.quote.regularMarketPrice;

                    var newStock = new Stock(ticker, price);

                    FavoriteStocks.Add(newStock);
                    SearchText = string.Empty;
                }
                else
                {
                    UserMessage = "The requested ticker was not found.";
                }
            }
            else
            {
                UserMessage = "This ticker is already on the list.";
            }
        }

        private bool DeleteTicker_CanExecute()
        {
            return true;
        }

        private void DeleteTicker_Execute(object ticker)
        {
            var toBeRemoved = FavoriteStocks.FirstOrDefault(p => p.Ticker == ticker);

            if (toBeRemoved != null)
            {
                FavoriteStocks.Remove(toBeRemoved);
            }
        }

        private bool StartMonitoring_CanExecute()
        {
            return FavoriteStocks.Any();
        }

        private void StartMonitoring_Execute()
        {
            _dispatcherTimer.Start();
            UpdateStockData();
        }

        private bool StopMonitoring_CanExecute()
        {
            return _dispatcherTimer.IsEnabled;
        }

        private void StopMonitoring_Execute()
        {
            _dispatcherTimer.Stop();

            foreach (var stock in FavoriteStocks)
            {
                stock.ResetPriceChange();
            }
        }

        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateStockData();
        }

        private void UpdateStockData()
        {
            Task task = Task.Run(async () =>
            {
                YahooQuery yahooQuery = new();

                foreach (Stock stock in FavoriteStocks)
                {
                    var stockData = await yahooQuery.GetTickerData(stock.Ticker);

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        double marketPrice = stockData.optionChain.result.First().quote.regularMarketPrice;

                        stock.UpdatePrice(marketPrice);
                    });
                }
            });
        }
    }
}
