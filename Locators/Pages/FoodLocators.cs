// using OpenQA.Selenium;

// namespace nUnitTestProject.Locators
// {
//     public static class FoodLocators
//     {
//         public static By food_menu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[6]/a/p");
//         public static By add_food => By.XPath("/html/body/div[1]/div[2]/div/div/div/div[1]/div/a[1]");
//         public static By food_name => By.Id("Name");
//         public static By food_description => By.Id("Description");
//         public static By food_price => By.Id("Price");
//         public static By food_submit => By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/form/div[2]/button[1]");
//         // public static By food_success => By.XPath("//*[contains(@class,'notyf__message')and text(),'{validMessage}']");

//         public static By success(string validMessage) =>
//         By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{validMessage}')]");

//         public static By failure(string failureMessage) =>
//         By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{failureMessage}')]");

//         public static By already_exist(string alreadyExistMessage) =>
//         By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{alreadyExistMessage}')]");

//         public static By ValidationError(string message) =>
//         By.XPath($"//*[contains(@class,'text-danger') and contains(@class,'field-validation-valid') and contains(text(),'{message}')]");

        
//         // public static By food_failed => By.XPath("//*[contains(@class,'notyf__message') and text()='Invalid attempt.']");

//         // public static By validation_error => By.CssSelector(".text-danger field-validation-valid");

//         // public static By already_exist => By.XPath("//div[contains(@class, 'notyf__message') and starts-with(text(), 'Food item')]");


//     }

// }


using OpenQA.Selenium;

namespace nUnitTestProject.Locators
{
    public static class FoodLocators
    {
        public static By food_menu => By.XPath("//nav//li[.//p[text()='Food']]");
        public static By add_food => By.XPath("//div[contains(@class,'add-food')]/a[1]");
        public static By food_name => By.Id("Name");
        public static By food_description => By.Id("Description");
        public static By food_price => By.Id("Price");
        public static By food_submit => By.XPath("//form//button[contains(text(),'Submit')]");

      public static By food_success(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");

    public static By food_failed(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");

    public static By validation_error(string message) =>
        By.XPath($"//*[contains(@class,'text-danger') and contains(@class,'field-validation-valid') and contains(text(),'{message}')]");

    public static By already_exist(string message) =>
        By.XPath($"//*[contains(@class,'notyf__message') and contains(text(),'{message}')]");
}

}