using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ProjectAutomationTest01.PageObjects
{
    public class PGO_Home
    {
        public PGO_Home(IWebDriver drive)
        {
            PageFactory.InitElements(drive, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#gb > div > div:nth-child(1) > div > div:nth-child(2) > a")]
        private IWebElement link_GoogleImagens { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input")]
        private IWebElement BarraPesquisa { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#gb > div > div:nth-child(1) > div > div:nth-child(1) > a")]
        private IWebElement link_Gmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b")]
        private IWebElement btn_Buscar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body")]
        private IWebElement fundo { get; set; }



        public void ClicarFundo()
        {
            fundo.Click();
        }
        public void ClicarBuscar()
        {
            btn_Buscar.Click();
        }
        public void ClicarGoogleImagens()
        {
            link_GoogleImagens.Click();
        }
        public void ClicarGmail()
        {
            link_Gmail.Click();
        }
        public void InserirTextoBuscado(string busca)
        {
            BarraPesquisa.SendKeys(busca);
        }

    }
}
