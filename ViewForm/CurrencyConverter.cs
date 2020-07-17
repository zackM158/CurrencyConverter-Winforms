using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionLibrary;

namespace ViewForm
{
    public partial class CurrencyConverter : Form
    {
        CurrencyController controller;

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("CurrencyConverter.cs");
        public CurrencyConverter()
        {
            InitializeComponent();
            try
            {
                controller = new CurrencyController();
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show("Please Connect To The Internet And Try Again");
                logger.Error(ex.Message);
                Environment.Exit(1);
            }

            logger.Info("Start.");
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ConvertButton.Height;
            SidePanel.Top = ConvertButton.Top;
            NumberOfDaysPanel.Hide();
            ConvertNowButton.Show();
            AverageNowButton.Hide();
            MinMaxNowButton.Hide();
            ChartPanel.Hide();
            AmountPanel.Show();
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AverageButton.Height;
            SidePanel.Top = AverageButton.Top;
            NumberOfDaysPanel.Show();
            ConvertNowButton.Hide();
            AverageNowButton.Show();
            MinMaxNowButton.Hide();
            ChartPanel.Hide();
            AmountPanel.Hide();
        }

        private void MinMaxButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MinMaxButton.Height;
            SidePanel.Top = MinMaxButton.Top;
            NumberOfDaysPanel.Show();
            ConvertNowButton.Hide();
            AverageNowButton.Hide();
            MinMaxNowButton.Show();
            ChartPanel.Hide();
            AmountPanel.Hide();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ChartButton.Height;
            SidePanel.Top = ChartButton.Top;
            NumberOfDaysPanel.Show();
            ConvertNowButton.Hide();
            AverageNowButton.Hide();
            MinMaxNowButton.Hide();
            ChartPanel.Show();
            AmountPanel.Hide();
        }

        private void CurrenciesButton_Click(object sender, EventArgs e)
        {
            OutputMessage.Text = controller.ViewAllCurrencyCodes();
        }

        private void ConvertNowButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.GetConvertedCurrency, true);            
        }

        private void ChartNowButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.CreateChart, false, "b");
        }

        private void MinMaxNowButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.GetMinMaxRates, false);
        }

        private void AverageNowButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.GetAverageRates, false);
        }

        private void LineChartButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.CreateChart, false, "l");
        }

        private void SlineChartButton_Click(object sender, EventArgs e)
        {
            CheckMethod(controller.CreateChart, false, "s");
        }

        void CheckMethod(Func<string, string, string, string> myMethod, bool takesAmount)
        {
            try
            {
                if (takesAmount)
                {
                    OutputMessage.Text = myMethod(originalCurrencyCode.Text, finalCurrencyCode.Text, Amount.Text);
                }
                else
                {
                    OutputMessage.Text = myMethod(originalCurrencyCode.Text, finalCurrencyCode.Text, numberOfDays.Text);
                }
            }
            catch (NoInputFoundException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (CurrencyNotFoundException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (InvalidCastException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (System.Net.WebException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
        }
        void CheckMethod(Action<string, string, string, string> myMethod, bool takesAmount, string chartType = "")
        {
            try
            {
                myMethod(originalCurrencyCode.Text, finalCurrencyCode.Text, numberOfDays.Text, chartType);

            }
            catch (NoInputFoundException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (CurrencyNotFoundException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (InvalidCastException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
            catch (System.Net.WebException ex)
            {
                logger.Error(ex.Message);
                OutputMessage.Text = ex.Message;
            }
        }


        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            logger.Info("Exited Program.");
            Environment.Exit(0);
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            string tempOriginalCode = originalCurrencyCode.Text;
            originalCurrencyCode.Text = finalCurrencyCode.Text;
            finalCurrencyCode.Text = tempOriginalCode;
        }
    }
}


