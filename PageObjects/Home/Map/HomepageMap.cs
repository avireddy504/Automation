using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interacted with on the page


    public class HomePageMap : BasePage
    {
        public HomePageMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation


        public By LoginButtonVerify => By.XPath("//*[@data-test='login-button']");
        public By UserNameAvtar => By.XPath("//*[@title='User avatar']");

        //Page elements for interaction

        public IWebElement LoginButton => Helper.LocateElement(Locators.Xpath, "//*[@data-test='login-button']");

        public IWebElement LoginModalDialog => Helper.LocateElement(Locators.Xpath, "//div[contains(@class, 'x-modal-content')]");

        public IWebElement Username => Helper.LocateElement(Locators.Xpath, "//input[@name='username']");
        
        public IWebElement Password => Helper.LocateElement(Locators.Xpath, "//input[@name='password']");

        public IWebElement SubmitButton => Helper.LocateElement(Locators.Xpath, "//button[@type='submit']");

        public IWebElement UserProfileAvtar => Helper.LocateElement(Locators.Xpath, "//*[@title='User avatar']");

        public IWebElement LogOutButton => Helper.LocateElement(Locators.Xpath, "//*[@data-test='logout-button']");

        
        






    }
}
