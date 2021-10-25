using NUnit.Framework;
using POMFramework.PageObjects;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class Homepage : BaseTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [Test]
        [RetryAttribute(3)]
        [Description("Login Test")]
        
        
        public void LoginToPicsArt()
        {
            log.Info("This is Logger: PicsArt Login Page");
            Pages.Home.GoTo();
            Pages.Home.ClickOnLogin();
            Assert.IsTrue(Pages.Home.Map.LoginModalDialog.Displayed);
            Pages.Home.EnterLoginCredentials();

            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/create");
            Pages.Home.Logout();
            Assert.AreEqual(Pages.Home.GetCurrentUri(), "https://picsart.com/explore");                
        }     


        //[Test]
        //[RetryAttribute(3)]
        //public void Fail_Testcase()
        //{
        //    bool val = false;
        //    Assert.IsTrue(val);
        //}

       
    }
}
