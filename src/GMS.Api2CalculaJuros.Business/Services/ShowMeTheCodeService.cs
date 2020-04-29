using GMS.Api2CalculaJuros.Business.Interfaces;

namespace GMS.Api2CalculaJuros.Business.Services
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        private const string UrlGit = "https://github.com/gislainesalvatico/calcular-juros-compostos";

        public string ObterUrlGit()
        {
            return UrlGit;
        }
    }
}