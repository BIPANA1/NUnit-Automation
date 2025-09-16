using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class LoginLocators
    {
        public static By Username => By.Id("InputUsername");
        public static By password => By.Id("InputPassword");
        public static By submit_button => By.XPath("/html/body/div[1]/div/div/div/div/div/div/div[2]/div/form/button");
        public static By validation_error => By.ClassName("text-danger field-validation-valid");

    }
}