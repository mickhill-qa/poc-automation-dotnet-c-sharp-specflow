using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning_specflow.PageObjects
{
    class GoogleInicialPage
    {
        private readonly IWebDriver browser;
        private const string url = "https://www.google.com.br/";
        private By inputPesrquisar = By.XPath("//input[@name='q']");
        private By btnPesquisar = By.XPath("(//input[@name='btnK'])[2]");
        private By txtResultado = By.Id("result-stats");

        public GoogleInicialPage()
        {
            browser = DriverFactory.GetBrownser();
        }

        public void AbrirPagina()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void PreencherFormPesquisa(string pesquisa)
        {
            browser.FindElement(inputPesrquisar).SendKeys(pesquisa);
            browser.FindElement(inputPesrquisar).SendKeys(Keys.Escape);
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
