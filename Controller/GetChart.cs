using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Database;

namespace Controller
{
    public class GetChart
    {

        IDatabase databaseReader;
        private string OriginalCurrency { get; set; }
        private string FinalCurrency { get; set; }
        private int AmountOfDays { get; set; }

        public GetChart(IDatabase database, string originalCurrency, string finalCurrency, int amountOfDays)
        {
            databaseReader = database;
            OriginalCurrency = originalCurrency;
            FinalCurrency = finalCurrency;
            AmountOfDays = amountOfDays;
        }

        public void ShowChart(string chartType)
        {
            List<double> dailyRates = databaseReader.GetDailyRates(OriginalCurrency, FinalCurrency, AmountOfDays);
            string chartName = "DailyExchangeRate.png";

            Chart chart1 = new Chart();
            chart1.ApplyPaletteColors();

            chart1.Size = new System.Drawing.Size(1880, 640);
            chart1.ChartAreas.Add("ChartArea1");
            chart1.Legends.Add("legend1");
            chart1.ChartAreas[0].AxisY.Maximum = dailyRates.Max(); 
            chart1.ChartAreas[0].AxisY.Minimum = dailyRates.Min();
            chart1.Series.Add("Rate");
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Series["Rate"].BorderWidth = 4;
            if (chartType == "l")
                chart1.Series["Rate"].ChartType = SeriesChartType.Line;
            if (chartType == "s")
                chart1.Series["Rate"].ChartType = SeriesChartType.Spline;

            double counter = AmountOfDays;
            foreach (var itemX in dailyRates)
            {
                chart1.Series["Rate"].Points.AddXY(DateTime.Now.Date.AddDays(-counter).ToString("d"), itemX);
                counter--;
            }

            if (System.IO.File.Exists(chartName))
                System.IO.File.Delete(chartName);
            Title titleis = new Title();
            titleis.Font = new Font("", 34);
            titleis.Text = "Rate Of " + OriginalCurrency + " Against " + FinalCurrency + " Over " + AmountOfDays + " Days";
            chart1.Titles.Add(titleis);

            chart1.SaveImage(chartName, System.Drawing.Imaging.ImageFormat.Png);
            System.Diagnostics.Process.Start(chartName);
        }
    }
}
