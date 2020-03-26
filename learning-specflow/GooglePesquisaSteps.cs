using System;
using TechTalk.SpecFlow;

namespace learning_specflow
{
    [Binding]
    public class GooglePesquisaSteps
    {
        GoogleInicialPage paginaInicial = new GoogleInicialPage();

        [BeforeScenario]
        public void Init()
        {
            paginaInicial.AbrirPagina();
        }

        [AfterScenario]
        public void Finish()
        {
            paginaInicial.FecharPagina();
        }



        [Given(@"que eu esteja na pagina inicial do google")]
        public void DadoQueEuEstejaNaPaginaInicialDoGoogle()
        {
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
            //assertEquals("Aproximadamente", txtAssertPage);
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
            Boolean mesmaPagina = paginaInicial.ConferirSeEstouNaPaginaInicial();
            //assertEquals(true, mesmaPagina);
        }
    }
}
