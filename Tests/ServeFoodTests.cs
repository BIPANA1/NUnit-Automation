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
    public class ServeFood
    {
         [Test, TestCaseSource(typeof(ServeFoodReader), nameof(ServeFoodReader.GetServeFoodData))]
        public void ServeFoods(string servingdate, string enddate, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            try
            {
                var serveFood = new ServeFoodPages(driver);
                serveFood.ServeFood(servingdate, enddate);

                By messageLocator;

                switch (expectedResult)
                {
                    case "Success":
                        messageLocator = ValidationLocators.success("Serving food item created for the date range");
                        break;
                    case "Failure":
                        messageLocator = ValidationLocators.failed("Invalid attempt");
                        break;
                    case "validation_error":
                        messageLocator = ValidationLocators.validation_error("Name is required");
                        break;
                    case "already_exist":
                        messageLocator = ValidationLocators.already_exist("Serving food item already exists for");
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