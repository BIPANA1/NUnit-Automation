using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using nUnitTestProject.Locators.Pages;

namespace nUnitTestProject.Pages
{
    public class ServeFoodPages
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ServeFoodPages(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void ServeFood(string servingdate, string enddate)
        {
            // Navigate to food creation
            wait.Until(d => d.FindElement(ServeFoodLocators.serving_menu)).Click();
            wait.Until(d => d.FindElement(ServeFoodLocators.serve_food_name)).Click();
            wait.Until(d => d.FindElement(ServeFoodLocators.create_food)).Click();

            // Select food item from dropdown
            wait.Until(d => d.FindElement(ServeFoodLocators.foodDropdownButton)).Click();
            wait.Until(d => d.FindElement(ServeFoodLocators.FoodOption("Momo"))).Click();
            Thread.Sleep(5000);
            // Set Serving Date
            var servingDateInput = wait.Until(d => d.FindElement(ServeFoodLocators.ServingDate));
            SetDate(servingDateInput, servingdate);
            Thread.Sleep(5000);

            // Click checkbox safely
            ClickElementSafely(By.Id("addMultipleServings"));
            Thread.Sleep(5000);
            // Set End Date
            var endDateInput = wait.Until(d => d.FindElement(ServeFoodLocators.EndDate));
            SetDate(endDateInput, enddate);
            Thread.Sleep(5000);
            // Submit form
            wait.Until(d => d.FindElement(ServeFoodLocators.submit)).Click();
            Thread.Sleep(5000);

        }

        private void SetDate(IWebElement element, string date)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].removeAttribute('readonly');", element);
            js.ExecuteScript("arguments[0].value = arguments[1];", element, date);
            js.ExecuteScript("arguments[0].dispatchEvent(new Event('change'));", element);
        }

        private void ClickElementSafely(By locator)
        {
            try
            {
                var element = wait.Until(d => d.FindElement(locator));
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                var element = driver.FindElement(locator);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
            }
        }
    }
}