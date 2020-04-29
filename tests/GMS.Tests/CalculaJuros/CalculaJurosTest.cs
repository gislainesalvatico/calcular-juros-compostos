using GMS.Api2CalculaJuros.Services;
using NUnit.Framework;

namespace GMS.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly CalculaJurosService _service = new CalculaJurosService();

        [TestCase(120, 2, 0.01, 122.41)]
        [TestCase(0, 2, 0.01, 0)]
        [TestCase(120, 0, 0.01, 120.00)]
        public void Calcula_Juros_Composto_Com_Sucesso(decimal valorInicial, int meses, double taxaJuros, decimal resultado)
        {
            var valorJuros = _service.CalcularJurosComposto(valorInicial, meses, taxaJuros);
            Assert.AreEqual(valorJuros, resultado);
        }
    }
}