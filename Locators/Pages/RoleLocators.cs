using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class RoleLocators
    {
        public static By role_menu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[4]/a/p");
        public static By create_role => By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");
        public static By name => By.Id("Name");
        public static By submit_role => By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/form/div[2]/button[1]");

        public static By role_name_validation => By.Id("rolename-validation");

        


    }
}