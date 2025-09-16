using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class ServeFoodLocators
    {
        
        public static By serving_menu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[7]/a");
        
        public static By serve_food_name => By.XPath("/html/body/div[1]/div[2]/div/div/div/div[2]/div/div[2]/div/table/tbody/tr[1]/td[5]/div/a[2]");

        public static By create_food => By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");

        public static By foodDropdownButton =>
        By.XPath("//button[@data-id='FoodItemId' and @title='Select Food']");
        public static By FoodOption(string foodName) =>
        By.XPath($"//ul[contains(@class,'dropdown-menu')]//span[normalize-space(text())='{foodName}']");

        public static By ServingDate => By.Id("ServingDate");
        public static By addMultipleServings => By.Id("addMultipleServings");
        public static By EndDate => By.Id("EndDate");

        public static By submit => By.Id("submit");
    

    }
}