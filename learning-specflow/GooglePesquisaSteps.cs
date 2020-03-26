using System;
using TechTalk.SpecFlow;

namespace learning_specflow
{
    [Binding]
    public class GooglePesquisaSteps
    {
        [Given(@"que eu esteja na pagina inicial do google")]
        public void DadoQueEuEstejaNaPaginaInicialDoGoogle()
        {
        }
        
        [When(@"eu pesquisar por um assunto")]
        public void QuandoEuPesquisarPorUmAssunto()
        {
        }
        
        [When(@"eu pesquisar sem preencher o assunto")]
        public void QuandoEuPesquisarSemPreencherOAssunto()
        {
        }
        
        [Then(@"me retorna os resultados indexados")]
        public void EntaoMeRetornaOsResultadosIndexados()
        {
        }
        
        [Then(@"continuarei na mesma pagian aguardando um assunto")]
        public void EntaoContinuareiNaMesmaPagianAguardandoUmAssunto()
        {
        }
    }
}
