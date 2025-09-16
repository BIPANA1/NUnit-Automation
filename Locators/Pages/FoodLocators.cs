using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class FoodLocators
    {
        public static By food_menu => By.XPath("//nav//li[.//p[text()='Food']]");
        public static By add_food => By.XPath("//div[contains(@class,'add-food')]/a[1]");
        public static By food_name => By.Id("Name");
        public static By food_description => By.Id("Description");
        public static By food_price => By.Id("Price");
        public static By food_submit => By.XPath("//form//button[contains(text(),'Submit')]");

     
}

}