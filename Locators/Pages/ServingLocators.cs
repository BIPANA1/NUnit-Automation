using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class ServingLocators
    {
    public static By serving_menu =>By.XPath("/html/body/div[1]/aside/div/nav/ul/li[7]/a");
    public static By add_serving =>By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");
    public static By serving_name =>By.Id("Name");
    public static By serving_time => By.Id("ServingTime");
    public static By serving_type =>By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/form/div[1]/div/div[3]/div/div[1]/input");
    public static By serving_minute =>By.Id("PreOrderMinute");
    public static By serving_save => By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/form/div[2]/button[1]");

    }
}