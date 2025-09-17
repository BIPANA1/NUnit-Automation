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
    public class ServiceTests
    {
         [Test, TestCaseSource(typeof(ServingDataReader), nameof(ServingDataReader.GetServingData))]
        public void ServiceTest(string name, string serve_time, string order_minute, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://nepalshuttle.infinite.com/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            try
            {
                var userPage = new ServingPage(driver);
                userPage.Serve(name, serve_time, order_minute);

                By messageLocator;

                switch (expectedResult)
                {
                    case "Success":
                        messageLocator = ValidationLocators.success("Serving created.");
                        break;
                    case "Failure":
                        messageLocator = ValidationLocators.failed("Invalid attempt.");
                        break;
                    case "validation_error":
                        messageLocator = ValidationLocators.validation_error("Name is required.");
                        break;
                    case "already_exist":
                        messageLocator = ValidationLocators.already_exist("Serving already exist");
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