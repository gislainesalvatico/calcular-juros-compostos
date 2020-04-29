using System;
namespace GMS.Api2CalculaJuros.Business.Interfaces
{
    public interface ICalculaJurosService
    {
        decimal CalcularJurosComposto(decimal valorInicial, int meses, double taxaJuros);
    }
}