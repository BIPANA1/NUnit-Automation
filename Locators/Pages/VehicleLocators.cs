using OpenQA.Selenium;

namespace nUnitTestProject.Locators.Pages
{
    public static class VehicleLocators
    {
        public static By navChildMenu => By.XPath("/html/body/div[1]/aside/div/nav/ul/li[12]/ul/li[1]/a");
        public static By description => By.Id("Description");
        public static By make => By.Id("Make");
        public static By model => By.Id("Model");

        public static By color => By.Id("Color");

        public static By licensePlate => By.Id("LicensePlate");

        public static By mobileNumber => By.Id("MobileNumber");

        public static By imei => By.Id("Imei");


    }
}