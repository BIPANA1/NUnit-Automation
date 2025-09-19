using OpenQA.Selenium;
using System.Threading; 
using nUnitTestProject.Locators.Pages;

namespace nUnitTestProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login(string username, string password)
        {
            _driver.FindElement(LoginLocators.Username).SendKeys(username);
            _driver.FindElement(LoginLocators.password).SendKeys(password);
            _driver.FindElement(LoginLocators.submit_button).Click();

            Thread.Sleep(3000);
        }
    }
}