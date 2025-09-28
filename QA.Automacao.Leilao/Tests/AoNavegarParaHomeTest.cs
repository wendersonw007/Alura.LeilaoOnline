using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA.Automacao.Leilao.Fixtures;
using System;
using Xunit;


namespace QA.Automacao.Leilao.Tests
{

    [Collection("Chrome Driver")]
    public class AoNavegarParaHomeTest 
    {
        //Setup
        private IWebDriver driver;

        public AoNavegarParaHomeTest(TestFixture fixture) 
        {
            driver = fixture.Driver;
        }


        [Fact]
        public void DadoChromeAbertoDeveMostrarLeioloesNoTitulo()
        {

            //arrange
            

            //act
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //assert
            Assert.Contains("Leilões", driver.Title);
            //Valida se realmente está Leilões Online
            Assert.Equal("Leilões Online", driver.Title);

        }



        [Fact]
        public void DadoChromeAbertoDeveMostrarProximosLeiloes()
        {

            //arrange
            

            //act
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //assert
            Assert.Contains("Próximos Leilões", driver.PageSource);


            

        }


    }
}