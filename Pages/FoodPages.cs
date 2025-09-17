using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;


namespace nUnitTestProject.Pages
{
    public class FoodPages
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public FoodPages(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void Food(string name, string description, string price)
        {
            wait.Until(d => d.FindElement(CommonLocators.navMenu("Food Item"))).Click();
            // wait.Until(d => d.FindElement(CommonLocators.CreateButton("fooditem"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CommonLocators.CreateButton("fooditem"))).Click();

            wait.Until(d => d.FindElement(FoodLocators.food_name)).SendKeys(name);
            wait.Until(d => d.FindElement(FoodLocators.food_description)).SendKeys(description);
            var minuteInput = wait.Until(d => d.FindElement(FoodLocators.food_price));
            minuteInput.Clear();
            minuteInput.SendKeys(price); 

           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CommonLocators.Submit("Save"))).Click();

        }

    }
}