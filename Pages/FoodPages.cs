using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators.Pages;

namespace nUnitTestProject.Pages
{
    public class FoodPages
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public FoodPages(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Food(string name, string description, string price)
        {
            wait.Until(d => d.FindElement(FoodLocators.food_menu)).Click();
            wait.Until(d => d.FindElement(FoodLocators.add_food)).Click();

            wait.Until(d => d.FindElement(FoodLocators.food_name)).SendKeys(name);
            wait.Until(d => d.FindElement(FoodLocators.food_description)).SendKeys(description);
            var minuteInput = wait.Until(d => d.FindElement(FoodLocators.food_price));
            minuteInput.Clear();
            minuteInput.SendKeys(price); 

            wait.Until(d => d.FindElement(FoodLocators.food_submit)).Click();

        }

    }
}