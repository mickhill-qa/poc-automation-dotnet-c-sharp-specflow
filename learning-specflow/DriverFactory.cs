using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

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

                case "ChromeHeadless":
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
                    Browser = new ChromeDriver(chromeDriverService, chromeOptions);
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
