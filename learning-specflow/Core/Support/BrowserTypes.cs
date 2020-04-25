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
            return GetBrownser(Browsers.FIREFOX); // Browser Default
        }

        public static IWebDriver GetBrownser(Browsers browserUser)
        {
            IWebDriver resultBrowser;

            switch (browserUser)
            {
                case Browsers.CHROME:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--ignore-certificate-errors");
                    resultBrowser = new ChromeDriver(chromeOptions);
                    break;
                case Browsers.CHROME_HEADLESS:
                    ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.HideCommandPromptWindow = true;
                    ChromeOptions chromeOptionsHeadles = new ChromeOptions();
                    chromeOptionsHeadles.AddArguments(
                        new List<string>()
                        {
                            "--ignore-certificate-errors",
                            "--silent-launch",
                            "--no-startup-window",
                            "no-sandbox",
                            "headless",
                        }
                    );
                    resultBrowser = new ChromeDriver(chromeDriverService, chromeOptionsHeadles);
                    break;
                case Browsers.FIREFOX:
                    FirefoxOptions options = new FirefoxOptions();
                    options.AddAdditionalCapability("acceptInsecureCerts", true, true);
                    resultBrowser = new FirefoxDriver(options);
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
