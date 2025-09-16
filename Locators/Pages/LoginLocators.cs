using OpenQA.Selenium;

namespace nUnitTestProject.Locators
{
    public static class LoginLocators
    {
        public static By Username => By.Id("InputUsername");
        public static By password => By.Id("InputPassword");
        public static By submit_button => By.XPath("/html/body/div[1]/div/div/div/div/div/div/div[2]/div/form/button");

        // public static By account_created => By.XPath("//*[contains(@class,'notyf__message') and contains(text(),'Account for')]");

        public static By login_success => By.XPath("//*[contains(@class,'notyf__message') and text()='Logged in as infinite.admin@infinite.com.']");
        public static By login_failed => By.XPath("//*[contains(@class,'notyf__message') and text()='Invalid login attempt.']");

        public static By validation_error => By.ClassName("text-danger field-validation-valid");

    }
}