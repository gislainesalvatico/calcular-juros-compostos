using System.Threading.Tasks;

namespace GMS.Api2CalculaJuros.Business.Interfaces
{
    public interface IApi1TaxaJurosService
    {
        Task<double> ObterTaxaJurosAsync();
    }
}