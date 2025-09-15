using OpenQA.Selenium;
using nUnitTestProject.Locators;
using OpenQA.Selenium.Support.UI;

namespace nUnitTestProject.Pages
{
    public class RolePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait wait;
        

        public RolePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        }

        public void Role(string name)
        {
            wait.Until(d => d.FindElement(RoleLocators.role_menu)).Click();
            wait.Until(d => d.FindElement(RoleLocators.create_role)).Click();

            wait.Until(d => d.FindElement(RoleLocators.name)).SendKeys(name);
            wait.Until(d => d.FindElement(RoleLocators.submit_role)).Click();
         
            Thread.Sleep(3000);
        }
    }
}