using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuscadeCEPWF
{
    interface ICepApiServices
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponse>GetAddressAsync(string cep);
    }
}
