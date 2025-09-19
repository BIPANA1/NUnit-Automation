using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using nUnitTestProject.Pages;
using nUnitTestProject.Utils;
using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;

namespace nUnitTestProject.Tests
{
    [TestFixture]
    public class UserFileTests
    {
        [Test]
        public void UserFileTest()
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var loginPage = new LoginPage(driver);
            loginPage.Login("infinite.admin@infinite.com", "123Pa$$word!");

            var userPage = new UserFilePage(driver);
            userPage.UserDownload();

            driver.Quit();
        }
    }
}