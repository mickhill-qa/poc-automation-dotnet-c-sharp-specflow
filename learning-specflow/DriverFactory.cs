using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning_specflow
{
    class DriverFactory
    {
        public DriverFactory()
        {
        }

        public static IWebDriver GetBrownser()
        {
            return new ChromeDriver();
            //return new FirefoxDriver();
        }
    }
}
