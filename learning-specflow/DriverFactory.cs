using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace learning_specflow
{
    class DriverFactory
    {

        public static IWebDriver GetBrownser()
        {
            string browserConfig = "Chrome";
            IWebDriver Browser;

            switch (browserConfig)
            {
                case "Chrome":
                    Browser = new ChromeDriver();
                    break;
                case "Firefox":
                    Browser = new FirefoxDriver();
                    break;
                case "IE":
                    //Browser = new InternetExplorerDriver();
                    //break;
                default:
                    throw new NotSupportedException("Browser Nao Suportado");
            }
            return Browser;
        }
    }
}
