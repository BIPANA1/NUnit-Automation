using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Shared
{
    public static class ValidationLocators
    {
        public static By success(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");

        public static By failed(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");

        public static By validation_error(string message) =>
        By.XPath($"//*[contains(@class,'text-danger') and contains(@class,'field-validation-valid') and contains(text(),'{message}')]");

        public static By already_exist(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");
        
    }
}