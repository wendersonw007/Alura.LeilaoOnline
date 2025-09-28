using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Automacao.Leilao.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //setup
        public TestFixture()
        {
            Driver = new ChromeDriver();
        }


        //TearDown
        public void Dispose() 
        {
            Driver.Quit();
        }






    }



}
