using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AlphaVantage
{
    public class Import
    {
        public static void Program()
        {
            const string function = "TIME_SERIES_DAILY_ADJUSTED";
            const string symbol = "BTC"; //"AMZN";//"MSFT";
            const string apiKey = "11EJMYL88Q4DW5BT";

            string json;

            using (var web = new WebClient())
            {
                var url = $"https://www.alphavantage.co/query?function={function}&symbol={symbol}&outputsize=full&apikey={apiKey}";
                json = web.DownloadString(url);
                /* TEST */string result = json;
            }
        }
    }
}
