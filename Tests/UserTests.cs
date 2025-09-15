using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators;
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
                        messageLocator = UserLocators.user_success;
                        break;
                    case "Failure":
                        messageLocator = UserLocators.user_failed;
                        break;
                    case "validation_fail":
                        messageLocator = UserLocators.validation_failed;
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