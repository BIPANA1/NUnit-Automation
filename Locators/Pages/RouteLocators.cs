using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class RouteLocators
    {
        // public static By NavigationLink(string linkText) =>
        // By.XPath($"//a[contains(@class, 'nav-link') and contains(normalize-space(.), '{linkText}')]");


        public static By NavigationLink => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[12]/ul/li[2]/a");


    }
}