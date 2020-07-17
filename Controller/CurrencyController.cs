using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using FunctionLibrary;

namespace Controller
{
    public class CurrencyController
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("CurrencyController.cs");
        IDatabase databaseReader;

        private string validatedOriginalCode = "";
        private string validatedFinalCode = "";
        private int validatedAmountOfDays = 0;
        private double validatedAmountOfMoney = 0;

        public CurrencyController(IDatabase database)
        {
            databaseReader = database;
            databaseReader.LoadData();
        }

        public CurrencyController():this(new DatabaseReader())
        {
        }

        public List<string> GetAllCurrencyCodes()
        {
            var codes = databaseReader.CurrencyDictionary.Keys.OrderBy(c=>c).ToList();
            return codes;
        }

        public string ViewAllCurrencyCodes()
        {
            var codes = string.Join(", ", GetAllCurrencyCodes());
            return "A List Of Country Codes:" + Environment.NewLine + codes;
        }

        public void ValidateAllValues(string originalCode, string finalCode, string amount, bool usesAmountOfMoney)
        {
            validatedOriginalCode = databaseReader.ValidateCurrencyCode(originalCode);
            validatedFinalCode = databaseReader.ValidateCurrencyCode(finalCode);
            if (usesAmountOfMoney)
                validatedAmountOfMoney = databaseReader.ValidAmount(amount);
            else
                validatedAmountOfDays = databaseReader.ValidDays(amount);
        }

        public double ConvertMoney(double amount, double originalRate, double finalRate)
        {
            double finalAmount = (amount * finalRate) / originalRate;
            return Math.Round(finalAmount, 2);
        }

        public string GetConvertedCurrency(string originalCode, string finalCode, string amount)
        {
            ValidateAllValues(originalCode, finalCode, amount, true);

            double originalRate = databaseReader.GetRate(validatedOriginalCode);
            double finalRate = databaseReader.GetRate(validatedFinalCode);

            double convertedMoney = ConvertMoney(validatedAmountOfMoney, originalRate, finalRate);
            return validatedOriginalCode + " " + validatedAmountOfMoney + " = " + validatedFinalCode + " " + convertedMoney;
        }

        public string GetAverageRates(string originalCode, string finalCode, string amountOfDays)
        {
            ValidateAllValues(originalCode, finalCode, amountOfDays, false);

            double average = databaseReader.AverageRate(validatedOriginalCode, validatedFinalCode, validatedAmountOfDays);
            return "Average Rate For " + validatedOriginalCode + " Against " + validatedFinalCode + " Over The Last " + validatedAmountOfDays + " Days Is " + average;
        }

        public string GetMinMaxRates(string originalCode, string finalCode, string amountOfDays)
        {
            ValidateAllValues(originalCode, finalCode, amountOfDays, false);

            double[] minMaxRates = databaseReader.MinMaxRate(validatedOriginalCode, validatedFinalCode, validatedAmountOfDays);

            return "For " + validatedOriginalCode + " Against " + validatedFinalCode + " Over The Last " + validatedAmountOfDays + " Days," + Environment.NewLine + "Minimum Rate: " + minMaxRates[0] + Environment.NewLine + "Maximum Rate: " + minMaxRates[1];
        }

        public void CreateChart(string originalCode, string finalCode, string amountOfDays, string typeOfChart)
        {
            ValidateAllValues(originalCode, finalCode, amountOfDays, false);

            GetChart chart = new GetChart(databaseReader, validatedOriginalCode, validatedFinalCode, validatedAmountOfDays);

            chart.ShowChart(typeOfChart);
        }

    }
}
