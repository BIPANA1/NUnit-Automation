using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators;

namespace nUnitTestProject.Pages
{
    public class UserFilePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait wait;


        public UserFilePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        }

        public void UserDownload()
        {
            wait.Until(d => d.FindElement(UserFileLocators.user_menu)).Click();
            wait.Until(d => d.FindElement(UserFileLocators.download_menu)).Click();
        }
    }
}