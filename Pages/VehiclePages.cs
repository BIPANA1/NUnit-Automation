using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators.Pages;
using nUnitTestProject.Locators.Shared;


namespace nUnitTestProject.Pages
{
    public class VehiclePages
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public VehiclePages(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void Vehicle(string name, string description, string make, string model, string color,string imei)
        {
          
            wait.Until(d => d.FindElement(CommonLocators.navMenu("Shuttle"))).Click();
            wait.Until(d => d.FindElement(CommonLocators.MenuItem("Vehicles"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CommonLocators.CreateButton("vehicle"))).Click();

            wait.Until(d => d.FindElement(CommonLocators.name)).SendKeys(name);
            wait.Until(d => d.FindElement(VehicleLocators.description)).SendKeys(description);
            wait.Until(d => d.FindElement(VehicleLocators.make)).SendKeys(make);
            wait.Until(d => d.FindElement(VehicleLocators.model)).SendKeys(model);
            wait.Until(d => d.FindElement(VehicleLocators.color)).SendKeys(color);
            wait.Until(d => d.FindElement(VehicleLocators.imei)).SendKeys(imei);

            wait.Until(d => d.FindElement(ShiftLocators.SubmitButton("Save"))).Click();

        }

    }
}