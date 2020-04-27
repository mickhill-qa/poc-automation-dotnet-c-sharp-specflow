using learning_specflow.Core.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace learning_specflow.Steps
{
    public class BaseSteps
    {
        public static IWebDriver browser { get; set; }

        public static void OpenBrowser()
        {
            if(browser != null) return;

            browser = BrowserTypes.GetBrownser();
        }

        public static void CloseBrowser()
        {
            browser.Close();
            browser.Dispose();
            browser.Quit();
            browser = null;
        }
    }
}
