using System;
using GMS.Api2CalculaJuros.Business.Interfaces;

namespace GMS.Api2CalculaJuros.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        public decimal CalcularJurosComposto(decimal valorInicial, int meses, double taxaJuros)
        {
            return Math.Round(valorInicial * Convert.ToDecimal(Math.Pow(1 + taxaJuros, meses)), 2);
        }
    }
}