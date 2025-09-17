using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;
using nUnitTestProject.FileReaders;

namespace nUnitTestProject.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test, TestCaseSource(typeof(UserDataReader), nameof(UserDataReader.GetUserData))]
        public void UserTest(string firstname, string lastname, string email, string phonenumber, string password, string confirmpassword, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://nepalshuttle.infinite.com/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            try
            {
                var userPage = new UserPages(driver);
                userPage.User(firstname, lastname, email, phonenumber, password, confirmpassword);

                By messageLocator;

               switch (expectedResult)
                {
                    case "Success":
                        messageLocator = ValidationLocators.success("Account for");
                        break;
                    case "Failure":
                        messageLocator = ValidationLocators.failed("Invalid attempt.");
                        break;
                    case "validation_error":
                        messageLocator = ValidationLocators.validation_error("Name is required.");
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