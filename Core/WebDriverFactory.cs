using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace POMFramework.Driver
{
    // This class creates the webdriver object for the pages

    internal class Factory
    {
        internal IWebDriver CreateBrowser(Network type, BrowserType name)
        {

            return name switch { 
                    BrowserType.Chrome => GetChromeDriver(),
                    BrowserType.Edge => new EdgeDriver(),
                    BrowserType.Firefox => GetFirefoxDriver(),
                    _ => throw new ArgumentOutOfRangeException(name.ToString(), $"No such browser {name.ToString()}")
            };
        }

        private IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");
            
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(options);
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(options);
        }
    }
}
