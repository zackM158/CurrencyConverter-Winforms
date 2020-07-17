using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace View
{
    public class Menu
    {
        CurrencyController controler;

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Program.cs");

        public Menu()
        {
            controler = new CurrencyController();
            logger.Info("Start.");
        }

        public void SetUp()
        {
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Enter 1 To Convert Money");
            //Console.WriteLine("Enter 2 To Calculate The Average Exchange Rate For Two Currencies, Over The Last (n) Days");
            //Console.WriteLine("Enter 3 To Find The Highest And Lowest Exchange Rates For Two Currencies, Over The Last (n) Days");
            //Console.WriteLine("Enter 4 To See A Chart Of The History Of The Exchange Rate Between Two Currencies, Over The Last (n) Days");
            //Console.WriteLine("Enter x To Exit");
            //Console.WriteLine("---------------------------------");

            //string choice = Console.ReadLine();

            //switch (choice)
            //{
            //    case "1":
            //        Console.WriteLine(controler.ConvertCurrency());
            //        break;
            //    case "2":
            //        Console.WriteLine(controler.AverageRates());
            //        break;
            //    case "3":
            //        Console.WriteLine(controler.MinMaxRates());
            //        break;
            //    case "4":
            //        controler.CreateChart();
            //        break;
            //    case "x":
            //        logger.Info("Exited Program.");
            //        Environment.Exit(0);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operation");
            //        break;
            //}

            //Console.WriteLine("\n");
            //SetUp();

        }
    }
}
