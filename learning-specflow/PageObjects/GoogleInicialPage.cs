using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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

        public Boolean ConferirSeEstouNaPaginaInicial()
        {
            String paginaAtual = browser.Url.ToString();
            return url.Equals(paginaAtual);
        }

        public void FecharPagina()
        {
            browser.Close();
            browser.Dispose();
        }
    }
}
