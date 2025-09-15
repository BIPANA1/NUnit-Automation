using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators;

namespace nUnitTestProject.Tests
{
    [TestFixture] 
    public class RoleTests
    {
        [Test, TestCaseSource(typeof(RoleDataReader), nameof(RoleDataReader.GetRoleData))]
        public void RoleTest(string name, string expectedResult)
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            driver.Navigate().GoToUrl("https://nepalshuttle.infinite.com/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            try
            {
                var rolePage = new RolePage(driver);
                rolePage.Role(name);

                By messageLocator;

                switch (expectedResult)
                {
                    case "Success":
                        messageLocator = RoleLocators.role_success;
                        break;
                    case "Failure":
                        messageLocator = RoleLocators.role_failed;
                        break;

                    case "already_exist":
                        messageLocator = RoleLocators.role_failed;
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