using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace learning_specflow.Core.Support
{
    class BrowserTypes
    {
        public enum Browsers
        {
            CHROME,
            CHROME_HEADLESS,
            FIREFOX,
            IE,
        }

        public static IWebDriver GetBrownser()
        {
            return GetBrownser(Browsers.CHROME); // Browser Default
        }

        public static IWebDriver GetBrownser(Browsers browserUser)
        {
            IWebDriver resultBrowser;

            switch (browserUser)
            {
                case Browsers.CHROME:
                    resultBrowser = new ChromeDriver();
                    break;
                case Browsers.CHROME_HEADLESS:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments(
                        new List<string>()
                        {
                            "--silent-launch",
                            "--no-startup-window",
                            "no-sandbox",
                            "headless",
                        }
                    );
                    ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.HideCommandPromptWindow = true;
                    resultBrowser = new ChromeDriver(chromeDriverService, chromeOptions);
                    break;
                case Browsers.FIREFOX:
                    resultBrowser = new FirefoxDriver();
                    break;
                case Browsers.IE:
                //Browser = new InternetExplorerDriver();
                //break;
                default:
                    throw new NotSupportedException("Browser Nao Suportado");
            }
            return resultBrowser;
        }
    }
}
