using OpenQA.Selenium;
using QA.Automacao.Leilao.Fixtures;
using QA.Automacao.Leilao.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QA.Automacao.Leilao.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarRegistro
    {
        //Setup
        private IWebDriver driver;

        public AoEfetuarRegistro(TestFixture fixture) 
        {
            driver = fixture.Driver;
        }


        [Fact]
        public void DadoInformacoesValidasDevoIrParaPaginaDeAgradecimento() 
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados
            driver.Navigate().GoToUrl("http://localhost:5000");
            //nome
            var inputNome = driver.FindElement(By.Id("Nome"));
            //email
            var inputEmail = driver.FindElement(By.Id("Email"));
            //password
            var inputSenha = driver.FindElement(By.Id("Password"));
            //confirmpassword
            var inputConfirmeSenha = driver.FindElement(By.Id("ConfirmPassword"));

            //botão de registro
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));

            inputNome.SendKeys("Wenderson");
            inputEmail.SendKeys("wenderson17@gmail.com");
            inputSenha.SendKeys("123");
            inputConfirmeSenha.SendKeys("123");


            //act -efetuo o registro
            botaoRegistro.Click();



            //assert - devo ser direcionado para uma pagina de agradecimento
            Assert.Contains("Obrigado", driver.PageSource);        
        
        }



        // a Theory é quando o resultado esperado é o mesmo
        // mas no caso abaixo eu tenho várias condições invalidas
        // e o resultado experado é o mesmo
        [Theory]
        [InlineData("","wenderson@gmail.com", "123", "123")]
        [InlineData("Wenderson", "wenderson", "123", "123")]
        [InlineData("Wenderson", "wenderson@gmail.com", "123", "321")]
        [InlineData("Wenderson", "wenderson@gmail.com", "123", "")]
        public void DadoInformacoesInValidasNãoDeveCadastrar(
            string nome,
            string email,
            string senha, 
            string confirmSenha)
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados
            driver.Navigate().GoToUrl("http://localhost:5000");
            //nome
            var inputNome = driver.FindElement(By.Id("Nome"));
            //email
            var inputEmail = driver.FindElement(By.Id("Email"));
            //password
            var inputSenha = driver.FindElement(By.Id("Password"));
            //confirmpassword
            var inputConfirmeSenha = driver.FindElement(By.Id("ConfirmPassword"));

            //botão de registro
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));

            inputNome.SendKeys(nome);
            inputEmail.SendKeys(email);
            inputSenha.SendKeys(senha);
            inputConfirmeSenha.SendKeys(confirmSenha);


            //act -efetuo o registro
            botaoRegistro.Click();



            //assert - devo ser direcionado para uma pagina de agradecimento
            Assert.Contains("section-registro", driver.PageSource);

        }



        [Fact]
        public void DadoNomeEmBrancoMostrarMensagemDeErro()
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados
            driver.Navigate().GoToUrl("http://localhost:5000");          
            //botão de registro
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));


            //ACT
            botaoRegistro.Click();


            //ASSERT
            IWebElement elemento = driver.FindElement(By.CssSelector("span.msg-erro[data-valmsg-for=Nome]"));
            Assert.True(elemento.Displayed);
            //Assert.Contains("The Nome field is required.", driver.PageSource);

        }


        [Fact]
        public void DadoEmailInvalidoDeveMostrarMensagemDeErro()
        {
            //arrange - Dado chrome aberto, pagina inicial do sistema de leiloes
            //dados registros válidos informados

            var registroPO = new RegistroPO(driver);
            registroPO.Visitar();

            registroPO.PreencherFormulario(
                nome: "",
                email: "daniel",
                senha: "",
                confirmSenha: ""
                );

            //email
            //var inputEmail = driver.FindElement(By.Id("Email"));
            //inputEmail.SendKeys("wenderson");

            //botão de registro
            //var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));
            

            //ACT
            //botaoRegistro.Click();
            registroPO.SubmeteFormulario();


            //ASSERT
            Assert.Equal("Please enter a valid email address.", registroPO.EmailMensagemErro);
         
    
        }

    }
}
