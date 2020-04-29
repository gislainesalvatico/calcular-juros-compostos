using System;
using GMS.Api1TaxaJuros.Business.Interfaces;

namespace GMS.Api1TaxaJuros.Business.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private const double TaxaJuros = 0.01;

        public double ObterTaxaJuros()
        {
            return TaxaJuros;
        }
    }
}