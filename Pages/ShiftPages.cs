using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators.Pages;

namespace nUnitTestProject.Pages
{
    public class ShiftPages
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ShiftPages(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void shift(string name)
        {
            wait.Until(d => d.FindElement(ShiftLocators.MenuItem("Office"))).Click();
            wait.Until(d => d.FindElement(ShiftLocators.MenuItem("Shift"))).Click();
            wait.Until(d =>d.FindElement(ShiftLocators.create_shift)).Click();

            wait.Until(d => d.FindElement(ShiftLocators.name)).SendKeys(name);
            wait.Until(d => d.FindElement(ShiftLocators.SubmitButton("Save"))).Click();

        }

    }
}