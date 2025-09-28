﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Automacao.Leilao.PageObjects
{
    public class LoginPO
    {
        private IWebDriver driver;
        private By byInputLogin;
        private By byInputSenha;
        private By byBotaoLogin;

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputLogin = By.Id("Login");
            byInputSenha = By.Id("Password");
            byBotaoLogin = By.Id("btnLogin");
        }

        public void Logar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Autenticacao/Login");
        }

        public void PreencherFormularioLogin(
            string login,
            string senha)
            {
                driver.FindElement(byInputLogin).SendKeys(login);
                driver.FindElement(byInputSenha).SendKeys(senha);
            }


        public void SubmeteFormularioLogin()
        {
            driver.FindElement(byBotaoLogin).Click();

        }



    }

}
