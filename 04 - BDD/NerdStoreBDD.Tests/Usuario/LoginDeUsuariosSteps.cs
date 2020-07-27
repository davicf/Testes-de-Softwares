using TechTalk.SpecFlow;

namespace NerdStoreBDD.Tests.Usuario
{
    [Binding]
    public class LoginDeUsuariosSteps
    {
        [Given(@"Que o visitante está acessando o site da loja")]
        public void DadoQueOVisitanteEstaAcessandoOSiteDaLoja()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ele clicar em login")]
        public void QuandoEleClicarEmLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Preencher os dados do formulario de login")]
        public void QuandoPreencherOsDadosDoFormularioDeLogin(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no botão login")]
        public void QuandoClicarNoBotaoLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Ele será redirecionado para a vitrine")]
        public void EntaoEleSeraRedirecionadoParaAVitrine()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Uma saudação com seu e-mail será exibida no menu superior")]
        public void EntaoUmaSaudacaoComSeuE_MailSeraExibidaNoMenuSuperior()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
