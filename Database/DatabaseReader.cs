using FunctionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Database
{
    public class DatabaseReader : IDatabase
    {
        public Dictionary<string, double> CurrencyDictionary { get; set; }

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("DatabaseReader.cs");
        public void LoadData()
        {
            //string yesterdaysDate = DateTime.Now.AddDays(-1).Date.ToString("yyyy-MM-dd");
            CurrencyDictionary = new Dictionary<string, double>();

            XmlDocument doc = new XmlDocument();

            doc.Load(@"https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml");


            foreach (XmlNode child in doc.DocumentElement["Cube"].ChildNodes[0])
            {
                string countryCode = child.Attributes[0].InnerText;
                double rate = double.Parse(child.Attributes[1].InnerText);
                CurrencyDictionary.Add(countryCode, rate);
            }

            CurrencyDictionary.Add("EUR", 1);
        }

            //foreach (XmlNode node in doc.DocumentElement["Cube"].ChildNodes)
            //{
            //    string date = node.Attributes[0].Value;
            //    if (date == yesterdaysDate)
            //    {
            //        foreach (XmlNode child in node)
            //        {
            //            string countryCode = child.Attributes[0].InnerText;
            //            double rate = double.Parse(child.Attributes[1].InnerText);
            //            CurrencyDictionary.Add(countryCode, rate);
            //        }
            //        CurrencyDictionary.Add("EUR", 1);
            //        break;
            //    }
            //}
        //}

        public string ValidateCurrencyCode(string currencyCode)
        {
            if (currencyCode == "")
            {
                throw new NoInputFoundException("Please Enter An Input For The Currency Code");
            }

            bool validCode = CurrencyDictionary.ContainsKey(currencyCode.ToUpper());
            if (!validCode)
            {
                throw new CurrencyNotFoundException(currencyCode.ToUpper() + " Is Not A Valid Currency Code");
            }
            return currencyCode.ToUpper();
        }

        public double ValidAmount(string amount)
        {
            if (amount == "")
            {
                throw new NoInputFoundException("Please Enter An Input For The Amount");
            }

            double validatedAmount;
            bool isNum = double.TryParse(amount, out validatedAmount);
            if (!isNum)
            {
                throw new InvalidCastException(amount + " Is Not A Valid Amount Of Money");
            }

            if (validatedAmount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount", validatedAmount + " Is Not A Valid Amount Of Money, Please Insert A Positive Number");
            }

            return validatedAmount;
        }

        public int ValidDays(string days)
        {
            if (days == "")
            {
                throw new NoInputFoundException("Please Enter An Input For The Amount Of Days");
            }

            int validatedDays;
            bool isNum = int.TryParse(days, out validatedDays);
            if (!isNum)
            {
                throw new InvalidCastException(days + " Is Not A Valid Amount Of Days");
            }

            if (validatedDays <= 0)
            {
                throw new ArgumentOutOfRangeException("Number Of Days", validatedDays + " Is Not A Valid Amount Of Days, Please Insert A Positive Integer");
            }

            return validatedDays;
        }


        public double GetRate(string currencyCode)
        {
            double rate = CurrencyDictionary[currencyCode];
            return rate;
        }

        public double AverageRate(string originalCurrency, string finalCurrency, int amountOfDays)
        {
            double averageRate;
            List<double> dailyRates = GetDailyRates(originalCurrency,finalCurrency,amountOfDays);
            averageRate = dailyRates.Average();
            return ExtraFunctions.SetSigFigs(averageRate, 5);
        }

        public double[] MinMaxRate(string originalCurrency, string finalCurrency, int amountOfDays)
        {
            List<double> dailyRates = GetDailyRates(originalCurrency, finalCurrency, amountOfDays);
            double minRate = ExtraFunctions.SetSigFigs(dailyRates.Min(),5);
            double maxRate = ExtraFunctions.SetSigFigs(dailyRates.Max(),5);
            double[] minMaxRates = new double[2] { minRate, maxRate };
            return minMaxRates;
        }

        

        public List<double> GetDailyRates(string originalCurrency, string finalCurrency, int amountOfDays)
        {
            List<double> rates = new List<double>();

            XmlDocument doc = new XmlDocument();
            if (amountOfDays <= 90)
            {
                doc.Load(@"https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml");
            }
            else
            {
                doc.Load(@"https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml");
            }

            int dayCounter = 0;

            foreach (XmlNode node in doc.DocumentElement["Cube"].ChildNodes)
            {
                if (dayCounter < amountOfDays)
                {
                    dayCounter++;
                    double originalRate = 1;
                    double finalRate = 1;

                    foreach (XmlNode child in node)
                    {
                        string countryCode = child.Attributes[0].InnerText;
                        if (countryCode == originalCurrency)
                        {
                            originalRate = double.Parse(child.Attributes[1].InnerText);
                        }
                        if (countryCode == finalCurrency)
                        {
                            finalRate = double.Parse(child.Attributes[1].InnerText);
                        }
                    }
                    double rate = finalRate / originalRate;
                    rates.Add(rate);
                }

                if (dayCounter >= amountOfDays)
                    break;
            }
            if(dayCounter < amountOfDays)
            {
                throw new ArgumentOutOfRangeException("Number Of Days", "We Only Have Records For The Last " + dayCounter + " Days");
            }

            return rates;
        }
    }
}
