
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockPriceMonitor.Model
{
    internal class YahooQuery
    {
        public static async Task<Root> GetTickerData(string ticker)
        {
            string url = ticker;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Root root = await response.Content.ReadAsAsync<Root>();

                    return root;
                }
                else 
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}