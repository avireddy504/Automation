using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;
using System;

namespace POMFramework.PageObjects
{
    public class PicsartBlogPageMap : BasePage
    {
        public PicsartBlogPageMap(IWebDriver driver) : base(driver)
        {
        }

        public By VerifyCategory => By.XPath("//div[text()= 'category']");
        public By CategoryDesignSchoolVerifyAfterClick => By.XPath("//h2[contains(text(),'Design School')]");

        public By CategoryTrendsVerifyAfterClick => By.XPath("//h2[contains(text(),'Trends')]");
        public By CategoryPicsartProVerifyAfterClick => By.XPath("//h2[contains(text(),'Picsart Pro')]");
        public By CategoryNewsVerifyAfterClick => By.XPath("//h2[contains(text(),'News')]");
        public By SearchedResultWait => By.XPath("//h2[contains(@class, 'top-bar-header')]");

        public By SearchTextboxWait => By.XPath("//input[contains(@class, 'search-form-searchInput')]");


        public IWebElement BlogVerify => Helper.LocateElement(Locators.Xpath, "//*[@href='https://picsart.com/blog']");
        
       
        public IWebElement DesignSchoolButton => Helper.LocateElement(Locators.Xpath, "//a[contains(text(),'Design School')][1]");

        public IWebElement TrendsButton => Helper.LocateElement(Locators.Xpath, "//a[contains(text(),'Trends')][1]");
        public IWebElement PicsArtProButton => Helper.LocateElement(Locators.Xpath, "//a[contains(text(),'Picsart Pro')][1]");
        public IWebElement NewsButton => Helper.LocateElement(Locators.Xpath, "//a[contains(text(),'News')][1]");

        public IWebElement SearchButton => Helper.LocateElement(Locators.Xpath, "//button[contains(@class, 'search-form-searchButton')]");

        public IWebElement SearchTextBox => Helper.LocateElement(Locators.Xpath, "//input[contains(@class, 'search-form-searchInput')]");

        public IWebElement SearchedResultText => Helper.LocateElement(Locators.Xpath, "//h2[contains(@class, 'top-bar-header')]");

        public IWebElement rightArrowButton => Helper.LocateElement(Locators.Xpath, "//button[@class='main-carousel-arrow-root-0-2-131 right arrow-button']");

        public IWebElement currentActiveFrame => Helper.LocateElement(Locators.Xpath, "//div[@class= 'main-carousel-item-root-0-2-33 active']");
        //*[@id="__next"]/div/div[2]/div/div[1]/div[1]/div/div[1]/div/div[1]/div/div[2]/h1



    }
}
