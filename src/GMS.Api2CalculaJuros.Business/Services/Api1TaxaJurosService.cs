using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GMS.Api2CalculaJuros.Business.Interfaces;

namespace GMS.Api2CalculaJuros.Business.Services
{
    public class Api1TaxaJurosService : IApi1TaxaJurosService
    {
        public async Task<double> ObterTaxaJurosAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344/");

                var responseMessage = await client.GetAsync("api/taxaJuros");
                var response = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.IsSuccessStatusCode)
                {
                    return double.Parse(response.Replace('.', ','));
                }

                throw new ArgumentException(response);
            }
        }
    }
}