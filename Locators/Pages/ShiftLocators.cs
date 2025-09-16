using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class ShiftLocators
    {
      
        public static By MenuItem(string menuText) =>
        By.XPath($"//a[contains(@class,'nav-link') and contains(.,'{menuText}')]");

        public static By ButtonByText(string buttonText) =>
        By.XPath($"//a[contains(text(),'{buttonText}')]");

        public static By create_shift =>By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");

        public static By name => By.Id("Name");
        
        public static By SubmitButton(string buttonText) =>
        By.XPath($"//button[contains(text(),'{buttonText}')]");

    }

}