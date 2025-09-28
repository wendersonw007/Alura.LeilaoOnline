using OpenQA.Selenium;
using QA.Automacao.Leilao.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Automacao.Leilao.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarLogin
    {

        //Setup
        private IWebDriver driver;


        public AoEfetuarLogin(Fixtures.TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoLogineSenhaCorretoLogarComSucesso()
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados

            var loginPO = new LoginPO(driver);
            loginPO.Logar();
            loginPO.PreencherFormularioLogin(
                login: "fulano@example.org",
                senha: "123"
                );

            //ACT
            //botaoRegistro.Click();
            loginPO.SubmeteFormularioLogin();


            //assert
            Assert.Contains("Dashboard", driver.PageSource);
        }


        [Fact]
        public void DadoCredenciasInvalidasDeveContinuarLogin()
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados

            var loginPO = new LoginPO(driver);
            loginPO.Logar();
            loginPO.PreencherFormularioLogin(
                login: "fulano@example.org",
                senha: ""
                );

            //ACT
            //botaoRegistro.Click();
            loginPO.SubmeteFormularioLogin();


            //assert
            Assert.Contains("Login", driver.PageSource);
        }
    }
}
