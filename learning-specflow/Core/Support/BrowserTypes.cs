using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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
            FIREFOX_HEADLESS,
            IE,
        }

        public static IWebDriver GetBrownser()
        {
            return GetBrownser(Browsers.FIREFOX_HEADLESS); // Browser Default
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
                    resultBrowser.Manage().Window.Maximize();
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
                    FirefoxOptions optionsFirefox = new FirefoxOptions();
                    optionsFirefox.AddAdditionalCapability("acceptInsecureCerts", true, true);
                    resultBrowser = new FirefoxDriver(optionsFirefox);
                    resultBrowser.Manage().Window.Maximize();
                    break;
                case Browsers.FIREFOX_HEADLESS:
                    FirefoxOptions optionsFirefoxHeadless = new FirefoxOptions();
                    optionsFirefoxHeadless.AddAdditionalCapability("acceptInsecureCerts", true, true);
                    optionsFirefoxHeadless.AddArguments("--headless");
                    resultBrowser = new FirefoxDriver(optionsFirefoxHeadless);
                    break;
                case Browsers.IE:
                    InternetExplorerOptions optionsIE = new InternetExplorerOptions();
                    optionsIE.IgnoreZoomLevel = true;
                    optionsIE.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    resultBrowser = new InternetExplorerDriver(optionsIE);
                    resultBrowser.Manage().Cookies.DeleteAllCookies();
                    resultBrowser.Manage().Window.Maximize();
                    break;
                default:
                    throw new NotSupportedException("Browser Nao Suportado");
            }
            return resultBrowser;
        }
    }
}
