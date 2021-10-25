using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using POMFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POMFramework
{
    [TestFixture]
    public class PicsArtBlogPage : BaseTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [Test]
        [RetryAttribute(3)]
        [Description("Navigating to Various options in PicsArt")]
        public void PicsartBlogOption()
        {

            Pages.Home.NavigateToBlog();
            Assert.IsTrue(Pages.PicsArtBlog.PicsArtMap.BlogVerify.Displayed);
            Pages.PicsArtBlog.PicsArtMap.DesignSchoolButton.Click();
            Pages.PicsArtBlog.VerifyDesignSchoolCategory();
            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/category/design-school");

            Pages.PicsArtBlog.PicsArtMap.TrendsButton.Click();
            Pages.PicsArtBlog.VerifyTrendCategory();
            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/category/trends");

            Pages.PicsArtBlog.PicsArtMap.PicsArtProButton.Click();
            Pages.PicsArtBlog.VerifyicsartProCategory();
            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/category/picsart-pro");

            Pages.PicsArtBlog.PicsArtMap.NewsButton.Click();
            Pages.PicsArtBlog.VerifyNewsCategory();
            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/category/news");

            Pages.PicsArtBlog.PicsArtMap.SearchButton.Click();
            Pages.PicsArtBlog.WaitTillSearchTextBoxisDisplayed();
            Pages.PicsArtBlog.PicsArtMap.SearchTextBox.SendKeys("Hello");
            Pages.PicsArtBlog.PicsArtMap.SearchButton.Click();
            Pages.PicsArtBlog.WaitTillSearchedResultDisplay();
            var Searchedtext = Pages.PicsArtBlog.PicsArtMap.SearchedResultText.Text;

            if(Searchedtext == "Hello")
            {
                log.Info("Searched Text is displayed correctly");
                
            }
            else
            {
                log.Info("Searched Text is NOT displayed correctly");
            }

            Pages.Home.NavigateToBlog();
            Assert.IsTrue(Pages.PicsArtBlog.PicsArtMap.BlogVerify.Displayed);
            var CurrentFrameText = Pages.PicsArtBlog.PicsArtMap.currentActiveFrame.Text;

            Pages.PicsArtBlog.PicsArtMap.currentActiveFrame.Click();
            //INSPIRATIONAL\r\nA Beginners Guide to Fashion Photography\r\nBY ALLEY BECKER
            

            if (CurrentFrameText.Contains("A Beginners Guide to Fashion Photography"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/fashion-photography-beginners-guide");
            }
            else if (CurrentFrameText.Contains("What Does HDR Mean? When and How To Use HDR Correctly"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/what-is-hdr-photography");
            }
            else if (CurrentFrameText.Contains("What Color is Burgundy? Meaning, How To Compliment It and Different Shades"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/what-color-is-burgundy");
            }
            else if (CurrentFrameText.Contains("How to Increase the Resolution of an Image"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/increase-resolution-image");
            }
            else if (CurrentFrameText.Contains("Designer Guidelines for Brochure Making and Printing"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/brochure-making-and-printing-guide");
            }
            else if (CurrentFrameText.Contains("How To Remove Objects, Text and People From a Picture"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/everything-you-need-to-know-to-remove-clutter-from-photos");
            }
            else if (CurrentFrameText.Contains("12 Best Selfie Poses: Ideas And Tips"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/selfie-poses-ideas");
            }
            else if (CurrentFrameText.Contains("How To Make Pixel Art: A Beginner’s Guide"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/how-to-make-pixel-art");
            }
            else if (CurrentFrameText.Contains("15 Female Poses Ideas For The Perfect Portrait"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/15-female-poses-ideas");
            }
            else if (CurrentFrameText.Contains("What Does HDR Mean? When and How To Use HDR Correctly"))
            {
                Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/blog/post/what-is-hdr-photography");
            }




        }


    }
}
