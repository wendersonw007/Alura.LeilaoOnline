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
            Assert.Contains("Leil�es", driver.Title);
            //Valida se realmente est� Leil�es Online
            Assert.Equal("Leil�es Online", driver.Title);

        }



        [Fact]
        public void DadoChromeAbertoDeveMostrarProximosLeiloes()
        {

            //arrange
            

            //act
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //assert
            Assert.Contains("Pr�ximos Leil�es", driver.PageSource);


            

        }


    }
}