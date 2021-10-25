using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.PageObjects.Base;
using System;

namespace POMFramework.PageObjects
{
    // This class stores all of the methods available to the page class

    public class HomePage : BasePage
    {
        public readonly HomePageMap Map;
        public HomePage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new HomePageMap(driver);
        }

        // Test methods available that are available to the test cases.

        public void GoTo()
        {
            Helper.GoToUrl("https://picsart.com");
        }

        public void NavigateToBlog()
        {
            Helper.GoToUrl("https://picsart.com/blog/");
        }
        public string GetCurrentUri()
        {
            return Helper.GetCurrentUrl();
        }

        public void ClickOnLogin()
        {
            Helper.WaitForPageToLoad(Map.LoginButtonVerify);
            Map.LoginButton.Click();
            
        }

        public void EnterLoginCredentials()
        {
            Map.Username.SendKeys("avi.reddy504@gmail.com");
            Map.Password.SendKeys("Sachin@1234$");
            Map.SubmitButton.Click();   
            Helper.WaitForPageToLoad(Map.UserNameAvtar);
        }

        public void Logout()
        {
            Map.UserProfileAvtar.Click();
            Map.LogOutButton.Click();

        }

    }
}