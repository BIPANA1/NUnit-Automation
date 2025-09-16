using OpenQA.Selenium;

namespace nUnitTestProject.Locators
{
    public static class UserFileLocators
    {
        public static By user_menu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[3]/a/p");
        public static By download_menu => By.Id("DownloadSampleFile");
        

    }
}