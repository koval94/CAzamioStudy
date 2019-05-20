using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRESTSharp.Models;

namespace TestRESTSharp
{
    public static class Helper
    {
        public static string GetToken(UserViewModel user)
        {
            RestClient client = new RestClient("https://cazamio.azurewebsites.net");
            RestRequest request = new RestRequest("/api/identity/login", Method.POST);
                request
                .AddHeader("api-version", "1")
                .AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(user));
            IRestResponse<LoginResponse> response = client.Execute<LoginResponse>(request);
            return response.Data.authData.token;
        }
    }
}
