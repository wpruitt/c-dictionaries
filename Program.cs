using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, string> stocks = new Dictionary<string, string>();
        stocks.Add("GM", "General Motors");
        stocks.Add("CAT", "Caterpillar");
        stocks.Add("AMD", "Advanced Micro Devices Inc.");
        stocks.Add("SPWR", "SunPower");

        string GM = stocks["GM"];
        string CAT = stocks["CAT"];
        Console.WriteLine(CAT);

        List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
        purchases.Add((ticker: "GM", shares: 150, price: 23.21));
        purchases.Add((ticker: "GM", shares: 32, price: 17.87));
        purchases.Add((ticker: "GM", shares: 80, price: 19.02));
        purchases.Add((ticker: "CAT", shares: 20, price: 5.00));
        purchases.Add((ticker: "CAT", shares: 12, price: 8.22));
        purchases.Add((ticker: "CAT", shares: 8, price: 6.52));
        purchases.Add((ticker: "SPWR", shares: 44, price: 11.22));
        purchases.Add((ticker: "SPWR", shares: 20, price: 12.30));
        purchases.Add((ticker: "SPWR", shares: 32, price: 10.11));
        purchases.Add((ticker: "AMD", shares: 18, price: 13.80));
        purchases.Add((ticker: "AMD", shares: 14, price: 14.22));
        purchases.Add((ticker: "AMD", shares: 32, price: 15.00));

        Dictionary<string, double> allPurchases = new Dictionary<string, double>();

        foreach ((string ticker, int shares, double price) purchase in purchases)
        {
            if (!allPurchases.ContainsKey(stocks[purchase.ticker]))
            {
                allPurchases.Add(stocks[purchase.ticker], (purchase.shares*purchase.price));
                Console.WriteLine("creating key/value pair");
                Console.WriteLine(purchase.shares*purchase.price);
            }
            else
            {
                allPurchases[stocks[purchase.ticker]] += (purchase.shares*purchase.price);
                Console.WriteLine("key exists");                   
            }
        }
        foreach (KeyValuePair<string, double> purchase in allPurchases)
            Console.WriteLine(purchase);
        }
    }

}
