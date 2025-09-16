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
    public class LoginTests
    {
        [Test, TestCaseSource(typeof(LoginDataReader), nameof(LoginDataReader.GetLoginData))]
        public void LoginTest(string username, string password, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://nepalshuttle.infinite.com/");

            try
            {
                var loginPage = new LoginPage(driver);
                loginPage.Login(username, password);

                By messageLocator;

            switch (expectedResult)
                {
                    case "Success":
                        messageLocator = ValidationLocators.success("Logged in as infinite.admin@infinite.com.");
                        break;
                    case "Failure":
                        messageLocator = ValidationLocators.failed("Invalid attempt.");
                        break;
                    case "validation_error":
                        messageLocator = ValidationLocators.validation_error("Invalid login attempt.");
                        break;
                    case "already_exist":
                        messageLocator = ValidationLocators.already_exist("Invalid attempt.");
                        break;
                    default:
                        Assert.Fail("Invalid expectedResult value.");
                        return;
                }

            }
            finally
            {
                driver.Quit();
            }
        }

        }
    }