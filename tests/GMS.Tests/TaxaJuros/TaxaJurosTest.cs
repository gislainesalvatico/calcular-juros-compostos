using GMS.Api1TaxaJuros.Business.Services;
using NUnit.Framework;

namespace GMS.Tests.TaxaJuros
{
    [TestFixture]
    public class TaxaJurosTest
    {
        private readonly TaxaJurosService _service = new TaxaJurosService();

        [Test]
        public void Taxa_Juros_Com_Valor_Correto()
        {
            var taxaJuros = _service.ObterTaxaJuros();

            Assert.AreEqual(0.01, taxaJuros);
        }
    }
}
