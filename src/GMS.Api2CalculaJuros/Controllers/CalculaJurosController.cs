using System;
using System.Threading.Tasks;
using GMS.Api2CalculaJuros.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Api2CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJuros;
        private readonly IApi1TaxaJurosService _api1TaxaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJuros, IApi1TaxaJurosService api1TaxaJurosService)
        {
            _calculaJuros = calculaJuros;
            _api1TaxaJurosService = api1TaxaJurosService;
        }

        /// <summary>
        /// Método responsável por realizar o cálculo de juros.
        /// </summary>
        /// <param name="valorInicial">Valor Inicial.</param>
        /// <param name="meses">Meses.</param>
        /// <returns>Resultado do cálculo de juros.</returns>
        [HttpGet("{valorInicial}/{meses}")]
        public async Task<ActionResult<decimal>> CalculaJurosAsync(decimal valorInicial, int meses)
        {
            var taxaJuros = await _api1TaxaJurosService.ObterTaxaJurosAsync();
            var valorJuros = _calculaJuros.CalcularJurosComposto(valorInicial, meses, taxaJuros);

            return valorJuros; 
        }
    }
}