using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators;

namespace nUnitTestProject.Tests
{
    [TestFixture]
    public class ServeFood
    {
         [Test, TestCaseSource(typeof(ServeFoodReader), nameof(ServeFoodReader.GetServeFoodData))]
        public void ServeFoods(string servingdate, string enddate, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://nepalshuttle.infinite.com/");
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
                        messageLocator = FoodLocators.food_success;
                        break;
                    case "Failure":
                        messageLocator = FoodLocators.food_failed;
                        break;
                    case "validation_error":
                        messageLocator = FoodLocators.validation_error;
                        break;

                    case "already_exist":
                        messageLocator = FoodLocators.already_exist;
                        break;   
                    default:
                        Assert.Fail("Invalid expectedResult value.");
                        return;
                }

                Console.WriteLine($"Locator selected for: {expectedResult}");
            }
            finally
            {
                driver.Quit();
            }
        }

    }

}