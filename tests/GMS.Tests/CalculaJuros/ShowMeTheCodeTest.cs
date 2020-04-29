using System;
using GMS.Api2CalculaJuros.Business.Services;
using NUnit.Framework;

namespace GMS.Tests.CalculaJuros
{
    [TestFixture]
    public class ShowMeTheCodeTest
    {
        private readonly ShowMeTheCodeService _service = new ShowMeTheCodeService();

        [Test]
        public void Url_Github_Validada_Com_Sucesso()
        {
            var urlGit = _service.ObterUrlGit();
            var resultado = Uri.TryCreate(urlGit, UriKind.Absolute, out Uri uri);

            Assert.IsTrue(resultado);
        }
    }
}