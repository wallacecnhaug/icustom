using System;
using TechTalk.SpecFlow;

namespace icustom.teste.BDD.specflow.Steps
{
    [Binding]
    public class UsuarioSteps
    {
        [Given(@"que foi informado os dados de usuário com login '(.*)'")]
        public void GivenQueFoiInformadoOsDadosDeUsuarioComLogin(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"com nome '(.*)'")]
        public void GivenComNome(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"com senha '(.*)'")]
        public void GivenComSenha(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"faço uma conferência dos dados na tela")]
        public void DadoFacoUmaConferenciaDosDadosNaTela()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"clico no botão '(.*)'")]
        public void WhenClicoNoBotao(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"O sistema me retorna uma mensagem de sucesso: '(.*)'")]
        public void ThenOSistemaMeRetornaUmaMensagemDeSucesso(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
