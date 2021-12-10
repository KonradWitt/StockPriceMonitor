using StockPriceMonitor.Commands;
using StockPriceMonitor.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace StockPriceMonitor.ViewModel
{
    internal class MainWindowContext : ViewModelBase
    {
        public ICommand AddNewTicker { get; private set; }
        public ICommand StartMonitoring { get; private set; }
        public ICommand StopMonitoring { get; private set; }
        public string SearchText { get; set; }
        public ObservableCollection<Stock> FavoriteStocks { get; private set; }

        private DispatcherTimer _dispatcherTimer;
        private TimeSpan _dispatcherTimerInterval = new TimeSpan(0, 0, 3);

        public MainWindowContext()
        {
            AddNewTicker = new Command(p => AddNewTicker_CanExecute(), p => AddNewTicker_Execute());
            StartMonitoring = new Command(p => StartMonitoring_CanExecute(), p => StartMonitoring_Execute());
            StopMonitoring = new Command(p => StopMonitoring_CanExecute(), p => StopMonitoring_Execute());
            FavoriteStocks = new() { new Stock("xD"), new Stock("AAPL") };
            ApiHelper.InitializeClient();
            _dispatcherTimer = new DispatcherTimer() { Interval = _dispatcherTimerInterval };
            _dispatcherTimer.Tick += DispatcherTimerTick;
        }

        private bool AddNewTicker_CanExecute()
        {
            return true;
        }

        private void AddNewTicker_Execute()
        {

        }

        private bool StartMonitoring_CanExecute()
        {
            return true;
        }

        private void StartMonitoring_Execute()
        {
            _dispatcherTimer.Start();
            UpdateStockData();
        }

        private bool StopMonitoring_CanExecute()
        {
            return true;
        }

        private void StopMonitoring_Execute()
        {
            _dispatcherTimer.Stop();
        }

        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            UpdateStockData();
        }
        private void UpdateStockData()
        {
            Task task = Task.Run(async () =>
            {
                var data = await YahooQuery.GetTickerData("AAPL");
                Stock testStock = new("AAPL");
                testStock.Price = data.optionChain.result[0].quote.regularMarketPrice;

                Application.Current.Dispatcher.Invoke(() =>
                { FavoriteStocks.Add(testStock); });
            });
        }
    }
}
