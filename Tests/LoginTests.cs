using NUnit.Framework;
using OpenQA.Selenium;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators;

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

                string actualMessage;

                if (expectedResult == "Success")
                {
                    actualMessage = driver.FindElement(LoginLocators.login_success).Text;
                    Console.WriteLine( actualMessage, "Pass");
                    // Assert.Equals("Logged in as infinite.admin@infinite.com.", actualMessage);
                }
                else
                {
                    actualMessage = driver.FindElement(LoginLocators.login_failed).Text;
                    Console.WriteLine( actualMessage, "Failure");
                }
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}