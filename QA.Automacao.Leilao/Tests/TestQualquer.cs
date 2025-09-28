using OpenQA.Selenium;
using QA.Automacao.Leilao.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Automacao.Leilao.Tests
{
    [Collection("Chrome Driver")]
    public class TestQualquer
    {
        //Setup
        private IWebDriver driver;

        public TestQualquer(TestFixture fixture)
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



    }
}
   // {
   // }
   //}
