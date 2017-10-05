using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApiTester
{

    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //GoogleFinance.Stocks.Program();
            AlphaVantage.Import.Program();
        }
    }
}
