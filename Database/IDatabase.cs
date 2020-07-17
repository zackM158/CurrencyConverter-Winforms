using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDatabase
    {
        Dictionary<string, double> CurrencyDictionary { get; set; }
        void LoadData();
        double GetRate(string currencyCode);
        double AverageRate(string originalCurrency, string finalCurrency, int amountOfDays);
        double[] MinMaxRate(string originalCurrency, string finalCurrency, int amountOfDays);
        List<double> GetDailyRates(string originalCurrency, string finalCurrency, int amountOfDays);
        string ValidateCurrencyCode(string currencyCode);
        double ValidAmount(string amount);
        int ValidDays(string days);

    }
}
