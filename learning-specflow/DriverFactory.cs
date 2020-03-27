using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace learning_specflow
{
    class DriverFactory
    {

        public static IWebDriver GetBrownser()
        {
            string browserConfig = "Firefox";
            IWebDriver Browser;

            switch (browserConfig)
            {
                case "IE":
                    Browser = new InternetExplorerDriver(new InternetExplorerOptions() { IgnoreZoomLevel = true });
                    break;
                case "Chrome":
                    Browser = new ChromeDriver();
                    break;
                case "Firefox":
                    Browser = new FirefoxDriver();
                    break;
                default:
                    throw new NotSupportedException("Browser Nao Suportado");
            }
            return Browser;
        }
    }
}
