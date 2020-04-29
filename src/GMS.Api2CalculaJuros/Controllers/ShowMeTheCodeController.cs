using GMS.Api2CalculaJuros.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Api2CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeController(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        /// <summary>
        /// Retorna a url de onde encontra-se o fonte desse projeto no github.
        /// </summary>
        /// <returns>Url de acesso ao código fonte desse projeto.</returns>
        [HttpGet]
        public string ShowMeTheCode()
        {
            return _showMeTheCodeService.ObterUrlGit();
        }
    }
}