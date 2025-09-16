using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using nUnitTestProject.Locators.Pages;

namespace nUnitTestProject.Pages
{
    public class UserPages
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait wait;


        public UserPages(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        }

        public void User(string firstname, string lastname, string email, string phonenumber, string password, string confirmpassword)
        {
            wait.Until(d => d.FindElement(UserLocators.user_menu)).Click();
            wait.Until(d => d.FindElement(UserLocators.user_create)).Click();

            wait.Until(d => d.FindElement(UserLocators.first_name)).SendKeys(firstname);
            _driver.FindElement(UserLocators.last_name).SendKeys(lastname);
            _driver.FindElement(UserLocators.email).SendKeys(email);
            _driver.FindElement(UserLocators.phone_no).SendKeys(phonenumber);
            _driver.FindElement(UserLocators.password).SendKeys(password);
            _driver.FindElement(UserLocators.confirm_password).SendKeys(confirmpassword);

            wait.Until(d => d.FindElement(UserLocators.submit_button)).Click();
        }
    }
}