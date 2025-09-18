using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace nUnitTestProject.Utils
{
    public static class WebDriverFactory
    {
        public const string BaseUrl = "https://nepalshuttle.infinite.com/";

        public static IWebDriver CreateDriver()
        {
            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BaseUrl);
            return driver;
        }
    }
}