using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

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
    }
}
