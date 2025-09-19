using OpenQA.Selenium;
using nUnitTestProject.Locators.Pages;
using OpenQA.Selenium.Support.UI;
using nUnitTestProject.Locators.Shared;

namespace nUnitTestProject.Pages
{
    public class ServingPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ServingPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        
        public void Serve(string name,string serve_time, string order_minute)
        {
            wait.Until(d => d.FindElement(ServingLocators.serving_menu)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CommonLocators.CreateButton("serving"))).Click();
            wait.Until(d => d.FindElement(ServingLocators.serving_name)).SendKeys(name);
            wait.Until(d => d.FindElement(ServingLocators.serving_time)).SendKeys(serve_time);
            wait.Until(d => d.FindElement(ServingLocators.serving_type)).Click();
            var minuteInput = wait.Until(d => d.FindElement(ServingLocators.serving_minute));
            minuteInput.Clear();
            minuteInput.SendKeys(order_minute); 
            wait.Until(d => d.FindElement(ServingLocators.serving_save)).Click();
        }

    }
}