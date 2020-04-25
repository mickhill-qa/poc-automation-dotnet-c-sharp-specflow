using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace learning_specflow.Pages
{
    class GoogleInicialPage : BasePage
    {
        public GoogleInicialPage(IWebDriver _browser) : base(_browser) { }

        private string url = "https://www.google.com.br/";

        private By inputPesrquisar = By.XPath("//input[@name='q']");
        private By optionsPesrquisa = By.CssSelector("#tsf > div:nth-child(2) > div > div > div > ul > li");
        private By btnPesquisar = By.XPath("(//input[@name='btnK'])[2]");
        private By txtResultado = By.Id("result-stats");

        public void AbrirPagina()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void PreencherFormPesquisa(string pesquisa)
        {
            wait.Until(e => e.FindElement(inputPesrquisar));
            browser.FindElement(inputPesrquisar).SendKeys(pesquisa);

            wait.Until(e => e.FindElement(optionsPesrquisa));
            actions.SendKeys(Keys.Escape).Perform();
        }

        public void Pesquisar()
        {
            wait.Until(e => e.FindElement(btnPesquisar));
            browser.FindElement(btnPesquisar).Click();
        }

        public string VerResultadoPesquisa()
        {
            wait.Until(e => e.FindElement(txtResultado));
            return browser.FindElement(txtResultado).Text.Substring(0, 15);
        }

        public void ConferirSeEstouNaPaginaInicial()
        {
            String paginaAtual = browser.Url.ToString();
            Assert.AreEqual(true, paginaAtual.Contains(url));
        }
    }
}
