using API;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace UPC.E31A.APIBusiness.API.Security
{
    /// <summary>
    /// 
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<string> GenerateToken(string numeroDocumento, string codigoUsuario)
        {
            var client = new HttpClient();

            var disco = await client
                .GetDiscoveryDocumentAsync(
                 new DiscoveryDocumentRequest
                 {
                     Address = AppSettingsProvider.config.UrlBaseIdentityServer,
                     Policy = {
                        ValidateIssuerName = false,
                        ValidateEndpoints = false,
                        RequireHttps = false   // Remover en Certificacion / Produccion
                     }
                 }
                );


            if (!disco.IsError)
            {
                var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,
                    GrantType = "client_credentials",
                    ClientId = "71BB7236-C97F-46F8-A0CB-395AA0FCADDF",
                    ClientSecret = "AF5D9F51-276D-4D24-9E82-31A90A88C4FF",
                    Scope = "email",
                    Parameters =
                    {
                        { "client_numero_documento", $"{numeroDocumento}"},
                        { "client_codigo_usuario", $"{codigoUsuario}" }
                    }
                });

                if (tokenResponse.IsError)
                {
                    return tokenResponse.Error;
                }

                return tokenResponse.Json.ToString();
            }

            return "";
        }

    }
}
