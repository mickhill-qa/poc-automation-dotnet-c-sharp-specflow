using learning_specflow.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace learning_specflow.Steps
{
    [Binding]
    class GooglePesquisaSteps
    {
        GoogleInicialPage paginaInicial;



        /**
         * Paginas necessaria aos passos
         **/
        public GooglePesquisaSteps()
        {
            paginaInicial = new GoogleInicialPage(BaseSteps.browser);
        }



        /**
         * Contexto
         **/
        [Given(@"que eu esteja na pagina inicial do google")]
        public void DadoQueEuEstejaNaPaginaInicialDoGoogle()
        {
            paginaInicial.AbrirPagina();
            paginaInicial.ConferirSeEstouNaPaginaInicial();
        }



        /**
         * pesquisaSuccess
         **/
        [When(@"eu pesquisar por um assunto")]
        public void QuandoEuPesquisarPorUmAssunto()
        {
            paginaInicial.PreencherFormPesquisa("Teste Automatizado");
            paginaInicial.Pesquisar();
        }

        [Then(@"me retorna os resultados indexados")]
        public void EntaoMeRetornaOsResultadosIndexados()
        {
            String txtAssertPage = paginaInicial.VerResultadoPesquisa();
            Assert.AreEqual("Aproximadamente", txtAssertPage);
        }




        /**
         * pesquisaUndefined
         **/
        [When(@"eu pesquisar sem preencher o assunto")]
        public void QuandoEuPesquisarSemPreencherOAssunto()
        {
            paginaInicial.Pesquisar();
        }

        [Then(@"continuarei na mesma pagian aguardando um assunto")]
        public void EntaoContinuareiNaMesmaPagianAguardandoUmAssunto()
        {
            paginaInicial.ConferirSeEstouNaPaginaInicial();
        }
    }
}
