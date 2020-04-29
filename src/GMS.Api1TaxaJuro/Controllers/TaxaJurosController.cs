using GMS.Api1TaxaJuros.Business.Interfaces;
using GMS.Api1TaxaJuros.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Api1TaxaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJuros;

        public TaxaJurosController(ITaxaJurosService taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }

        [HttpGet]
        public ActionResult<decimal> ObterTaxaJuros()
        {
            return (decimal)_taxaJuros.ObterTaxaJuros();
        }
    }
}