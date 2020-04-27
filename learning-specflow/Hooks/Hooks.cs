using learning_specflow.Core.Support;
using learning_specflow.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace learning_specflow.Hooks
{
    [Binding]
    public class Hooks
    {
        /**
         * Hooks
         **/
        [BeforeScenario]
        public void Init()
        {
            BaseSteps.OpenBrowser();
        }

        [AfterScenario]
        public void Finish()
        {
            BaseSteps.CloseBrowser();
        }
    }
}
