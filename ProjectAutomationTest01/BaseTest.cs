using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectAutomationTest01
{
    public class BaseTest
    {
        public IWebDriver driver { get; set; }

        //URL do portal que irá utilizar
        public const string urlPortal = "http://www.google.com/";

        [SetUp]
        public void abrir()
        {
            driver = new ChromeDriver();
            driver.Url = urlPortal;
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void fechar()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }



        public void EsperaImplicita(int tempo)
        {
            Thread.Sleep(tempo);
        }
        public void EsperaExplicita(int tempo, string elemento)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(tempo));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(elemento)));
        }

    }
}
