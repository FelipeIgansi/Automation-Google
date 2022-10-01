using NUnit.Framework;
using ProjectAutomationTest01.PageObjects;

namespace ProjectAutomationTest01.Cenarios
{
    [TestFixture]
    public class RealizarBuscas : BaseTest
    {

        [Test]
        public void BuscarTextoValido()
        {
            RotinasComuns Rotina = new RotinasComuns();
            Rotina.AbrirGoogle(driver);
            Rotina.InserirTexto(driver, "Am i a robot?");
            Rotina.ClicarBuscar(driver);
            Assert.IsNotNull(ValidaListagemBusca());
        }

        private object ValidaListagemBusca()
        {
            PGO_ListagemResultadosBusca listResultados = new PGO_ListagemResultadosBusca(driver);
            return listResultados.ValidaSeEncontrouResultados();
        }






    }
}