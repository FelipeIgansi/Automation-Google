using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ProjectAutomationTest01.PageObjects
{
    public class PGO_ListagemResultadosBusca : BaseTest
    {
        public PGO_ListagemResultadosBusca(IWebDriver drive)
        {
            PageFactory.InitElements(drive, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#search")]
        private IWebElement idListagemResultados { get; set; }


        public object ValidaSeEncontrouResultados()
        {
            return idListagemResultados != null;
        }
    }
}
