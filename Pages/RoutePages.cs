using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;

namespace nUnitTestProject.Pages
{
    public class RoutePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public RoutePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Route(string name, string description)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(CommonLocators.navMenu("Shuttle"))).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(RouteLocators.NavigationLink)).Click();

            _wait.Until(ExpectedConditions.ElementToBeClickable(CommonLocators.CreateButton("route"))).Click();

            _wait.Until(ExpectedConditions.ElementIsVisible(CommonLocators.name)).SendKeys(name);
            _wait.Until(ExpectedConditions.ElementIsVisible(CommonLocators.description)).SendKeys(description);

            _wait.Until(ExpectedConditions.ElementToBeClickable(CommonLocators.Submit("Save"))).Click();
        }
    }
}