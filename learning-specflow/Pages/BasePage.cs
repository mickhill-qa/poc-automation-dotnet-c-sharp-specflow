using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace learning_specflow.Pages
{
    class BasePage
    {
        protected IWebDriver browser;
        protected WebDriverWait wait;
        protected Actions actions;

        public BasePage(IWebDriver _browser)
        {
            browser = _browser;
            actions = new Actions(browser);
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
        }

        public void IE_IgnoreCertificateErrors()
        {
            String browserUsed = browser.ToString();

            if (
                browserUsed.Contains("IE") ||
                browserUsed.Contains("IExplorer") ||
                browserUsed.Contains("InternetExplorer")
            )
            {
                try
                {
                    int tempoEspera = 10; // segundos
                    tempoEspera *= 5;

                    for (int i = 0; i <= tempoEspera; i++)
                    {
                        if (browser.FindElement(By.Id("moreInfoContainer")).Displayed == true)
                        {
                            browser.ExecuteJavaScript("javascript:document.getElementById('overridelink').click()");
                            break;
                        }
                        else Thread.Sleep(200);
                    }
                }
                catch { }
            }
        }
    }
}
