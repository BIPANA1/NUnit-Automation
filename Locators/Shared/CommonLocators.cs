using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Shared
{
    public static class CommonLocators
    {
        public static By navMenu(string text) =>
        By.XPath($"//li[contains(@class, 'nav-item')]//p[contains(text(), '{text}')]");
        public static By MenuItem(string menuText) =>
        By.XPath($"//a[contains(@class,'nav-link') and contains(.,'{menuText}')]");

        public static By CreateButton(string actionKeyword) =>
        By.XPath($"//a[contains(@onclick, '{actionKeyword}') and contains(normalize-space(.), 'Create')]");

        public static By Submit(string buttonText) =>
        By.XPath($"//button[@type='submit' and contains(normalize-space(.), '{buttonText}')]");
        public static By name => By.Id("Name");
        public static By description => By.Id("Description");



    }
}
