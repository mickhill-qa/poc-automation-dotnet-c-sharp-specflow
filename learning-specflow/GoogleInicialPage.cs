using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace learning_specflow
{
    class GoogleInicialPage
    {
        private readonly IWebDriver browser;
        private const string url = "https://www.google.com.br/";
        //private By inputPesrquisar = By.xpath("//input[@name='q']");
        //private By btnPesquisar = By.xpath("(//input[@name='btnK'])[2]");
        //private By txtResultado = By.id("resultStats");

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
            // Aqui

        }

        public void Pesquisar()
        {
        }

        public string VerResultadoPesquisa()
        {
            return "";
        }

        public Boolean ConferirSeEstouNaPaginaInicial()
        {
            return true;
        }

        public void FecharPagina()
        {
            browser.Close();
            browser.Dispose();
        }
    }
}
