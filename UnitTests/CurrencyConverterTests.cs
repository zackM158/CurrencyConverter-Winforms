using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using NUnit.Framework;
using Moq;
using Database;
using FunctionLibrary;

namespace UnitTests
{
    [TestFixture]
    public class CurrencyConverterTests
    {
        Mock<IDatabase> mockDatabase;
        CurrencyController currencyController;


        [SetUp]
        public void SetUp()
        {
            //Arrange
            mockDatabase = new Mock<IDatabase>();
            currencyController = new CurrencyController(mockDatabase.Object);
            mockDatabase.Setup(m => m.CurrencyDictionary).Returns(new Dictionary<string, double>() { { "USD", 1.0871 }, { "GBP", 0.87948 } });

            mockDatabase.Setup(m => m.GetRate("USD")).Returns(1.0871);
            mockDatabase.Setup(m => m.GetRate("GBP")).Returns(0.87948);
            mockDatabase.Setup(m => m.ValidateCurrencyCode("usd")).Returns("USD");
            mockDatabase.Setup(m => m.ValidateCurrencyCode("gbp")).Returns("GBP");
            mockDatabase.Setup(m => m.ValidAmount("100.59")).Returns(100.59);
            mockDatabase.Setup(m => m.ValidDays("50")).Returns(50);
            mockDatabase.Setup(m => m.AverageRate("GBP","USD",50)).Returns(1.2401);
            mockDatabase.Setup(m => m.MinMaxRate("GBP","USD",50)).Returns(new double[2] {1.2398, 1.2403 });
            
        }

        [Test]
        public void CurrencyController_ValidateAllValues_CallsAllValidateFunctionsWhenValidatingToConvertCurrency()
        {
            //Act
            currencyController.ValidateAllValues(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), true);

            //Assert
            mockDatabase.Verify(m => m.ValidateCurrencyCode(It.IsAny<string>()), Times.Exactly(2));
            mockDatabase.Verify(m => m.ValidAmount(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void CurrencyController_ValidateAllValues_CallsAllValidateFunctionsWhenValidatingWithAmountOfDays()
        {
            //Act
            currencyController.ValidateAllValues(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), false);

            //Assert
            mockDatabase.Verify(m => m.ValidateCurrencyCode(It.IsAny<string>()), Times.Exactly(2));
            mockDatabase.Verify(m => m.ValidDays(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void CurrencyController_ConvertMoney_CalculatesTheRightAmountTo2DecimalPlaces()
        {
            //Act
            double expectedValue = 124.34;

            //Assert
            Assert.AreEqual(expectedValue, currencyController.ConvertMoney(100.59, 0.87948, 1.0871));

        }

        [Test]
        public void CurrencyContoller_GetAllCurrencyCodes_ReturnsAListOfAllCurrencyCodes()
        {
            //Act
            List<string> expectedValue = new List<string>() { "GBP", "USD" };

            //Assert
            Assert.AreEqual(expectedValue, currencyController.GetAllCurrencyCodes());
        }

        [Test]
        public void CurrencyController_GetConvertedCurrency_GivesTheRightMessageAndCallsGetRateMethodFromIDatabaseTwice()
        {
            //Act
            string expectedValue = "GBP 100.59 = USD 124.34";
            string actualValue = currencyController.GetConvertedCurrency("gbp", "usd", "100.59");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            mockDatabase.Verify(m => m.GetRate(It.IsAny<string>()), Times.Exactly(2));
        } 
        
        [Test]
        public void CurrencyController_GetAverageRates_GivesTheRightMessageAndCallsAverageRatesFromIDatabaseOnce()
        {
            //Act
            string expectedValue = "Average Rate For GBP Against USD Over The Last 50 Days Is 1.2401";
            string actualValue = currencyController.GetAverageRates("gbp", "usd", "50");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            mockDatabase.Verify(m => m.AverageRate(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void CurrencyController_GetMinMaxRates_GivesTheRightMessageAndCallsMinMaxRateFromIDatabaseOnce()
        {
            //Act
            string expectedValue = "For GBP Against USD Over The Last 50 Days," + Environment.NewLine + "Minimum Rate: 1.2398" + Environment.NewLine + "Maximum Rate: 1.2403";
            string actualValue = currencyController.GetMinMaxRates("gbp", "usd", "50");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            mockDatabase.Verify(m => m.MinMaxRate(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        //[Test]
        //public void CurrencyController_ThrowsException_WhenCantFindXML()
        //{
        //    mockDatabase.Setup(m => m.LoadData()).Throws<System.Net.WebException>();
        //    Assert.Throws<System.Net.WebException>(() => new CurrencyController(mockDatabase.Object));
        //}
    }
}
