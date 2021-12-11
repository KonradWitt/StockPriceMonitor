
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockPriceMonitor.Model
{
    internal class YahooQuery
    {
        public async Task<Root> GetTickerData(string ticker)
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

        public bool CheckIfResultsValid(OptionChain optionChain)
        {
            return optionChain.result?.Any() == true;
        }

    }
}