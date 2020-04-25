using learning_specflow.Core.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace learning_specflow.Steps
{
    class BaseSteps
    {
        protected IWebDriver browser = BrowserTypes.GetBrownser();

        /**
         * Hooks
         **/
        [BeforeScenario]
        public void Init()
        {
        }

        [AfterScenario]
        public void Finish()
        {
            browser.Close();
            browser.Dispose();
            browser.Quit();
        }

        /**
         * Destructor
         */
        ~BaseSteps()
        {
            browser.Close();
            browser.Dispose();
            browser.Quit();
        }
    }
}
