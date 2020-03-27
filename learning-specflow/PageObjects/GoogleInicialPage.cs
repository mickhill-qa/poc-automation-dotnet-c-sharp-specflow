using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace learning_specflow.PageObjects
{
    class GoogleInicialPage
    {
        private readonly IWebDriver browser;
        private readonly Actions actions;

        private const string url = "https://www.google.com.br/";

        private readonly By inputPesrquisar = By.XPath("//input[@name='q']");
        private readonly By btnPesquisar = By.XPath("(//input[@name='btnK'])[2]");
        private readonly By txtResultado = By.Id("result-stats");

        public GoogleInicialPage()
        {
            browser = DriverFactory.GetBrownser();
            actions = new Actions(browser);
        }

        public void AbrirPagina()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void PreencherFormPesquisa(string pesquisa)
        {
            browser.FindElement(inputPesrquisar).SendKeys(pesquisa);
            actions.SendKeys(Keys.Escape).Perform();
        }

        public void Pesquisar()
        {
            browser.FindElement(btnPesquisar).Click();
        }

        public string VerResultadoPesquisa()
        {
            return browser.FindElement(txtResultado).Text.Substring(0, 15);
        }

        public void ConferirSeEstouNaPaginaInicial()
        {
            String paginaAtual = browser.Url.ToString();
            Assert.AreEqual(true, url.Equals(paginaAtual));
        }

        public void FecharPagina()
        {
            browser.Close();
            browser.Dispose();
        }
    }
}
