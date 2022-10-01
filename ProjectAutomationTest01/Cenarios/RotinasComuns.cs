using OpenQA.Selenium;
using ProjectAutomationTest01.PageObjects;

namespace ProjectAutomationTest01.Cenarios
{
    public class RotinasComuns
    {
        public void AbrirGoogle(IWebDriver driver)
        {
            PGO_Home home = new PGO_Home(driver);
        }
        public void InserirTexto(IWebDriver driver, string valorBuscado)
        {
            PGO_Home home = new PGO_Home(driver);
            home.InserirTextoBuscado(valorBuscado);
        }
        public void ClicarBuscar(IWebDriver driver)
        {
            PGO_Home home = new PGO_Home(driver);
            home.ClicarBuscar();
        }
    }
}
