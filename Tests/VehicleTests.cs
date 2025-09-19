using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;

namespace nUnitTestProject.Tests
{
    [TestFixture]
    public class Vehicle
    {
        [Test, TestCaseSource(typeof(VehicleDataReader), nameof(VehicleDataReader.GetVehicleData))]
        public void Vehicles(string name,string description, string make, string model, string color, string license, string mobile,string imei, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            try
            {
                var vehiclepage = new VehiclePages(driver);
                vehiclepage.Vehicle(name,description,make,model,color,imei);

                By messageLocator;

                switch (expectedResult)
                {
                    case "Success":
                        messageLocator = ValidationLocators.success("Vehicle Created.");
                        break;
                    case "Failure":
                        messageLocator = ValidationLocators.failed("Invalid attempt.");
                        break;
                    case "already_exist":
                        messageLocator = ValidationLocators.already_exist("Invalid attempt.");
                        break;
                    default:
                        Assert.Fail("Invalid expectedResult value.");
                        return;
                }

                wait.Until(driver => driver.FindElement(messageLocator).Displayed);
                Assert.That(driver.FindElement(messageLocator).Displayed, $"Expected message for '{expectedResult}' not displayed.");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}