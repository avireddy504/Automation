using POMFramework.PageObjects.Base;
using OpenQA.Selenium;

namespace POMFramework.PageObjects
{
    public class PicsartBlogPage : BasePage
    {
        public readonly PicsartBlogPageMap PicsArtMap;
        public PicsartBlogPage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            PicsArtMap = new PicsartBlogPageMap(driver);
        }
            

        //WebDriverWait wait = new WebDriverWait(Helpers.d, TimeSpan.FromSeconds(5));
        //wait.Until(ExpectedConditions.UrlContains("/url-fragment"));

        public void VerifyCategory()
        {
            Helper.WaitForPageToLoad(PicsArtMap.VerifyCategory);
        }
        
        public void VerifyDesignSchoolCategory()
        {
            Helper.WaitForPageToLoad(PicsArtMap.CategoryDesignSchoolVerifyAfterClick);
        }

        public void VerifyTrendCategory()
        {
            Helper.WaitForPageToLoad(PicsArtMap.CategoryTrendsVerifyAfterClick);
        }

        public void VerifyicsartProCategory()
        {
            Helper.WaitForPageToLoad(PicsArtMap.CategoryPicsartProVerifyAfterClick);
        }

        public void VerifyNewsCategory()
        {
            Helper.WaitForPageToLoad(PicsArtMap.CategoryNewsVerifyAfterClick);
        }

        public void WaitTillSearchedResultDisplay()
        {
            Helper.WaitForPageToLoad(PicsArtMap.SearchedResultWait);
        }

        public void WaitTillSearchTextBoxisDisplayed()
        {
            Helper.WaitForPageToLoad(PicsArtMap.SearchTextboxWait);
        }

    }
}
