using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class UserLocators
    {
        public static By user_menu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[3]/a/p");
        public static By user_create => By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");
        public static By first_name => By.Id("FirstName");
        public static By last_name => By.Id("LastName");
        public static By email => By.Id("Email");
        public static By phone_no => By.Id("PhoneNumber");
        public static By password => By.Id("Password");
        public static By confirm_password => By.Id("ConfirmPassword");
        public static By submit_button => By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/form/div[7]/button[1]");

    }
}