using Newtonsoft.Json;
using RestSharp;
using NUnit.Framework;
using TestRESTSharp.Models;
using TestRESTSharp.Models.ResponseModels;
using RestSharp.Authenticators;
using System;
using System.Net;

namespace TestRESTSharp
{
    [TestFixture]
    public class LoginTests
    {
        private RestClient _client;
        private readonly Uri _baseUrl = new Uri("https://cazamio.azurewebsites.net");

        [SetUp]
        public void SetupServer()
        {
            _client = new RestClient(_baseUrl);
        }

        public static UserViewModel userData = new UserViewModel()
        {
            Email = "btest3@key-mail.net",
            Password = "Qwerty123!"
        };
        public static UserViewModel userDataNotVerified = new UserViewModel()
        {
            Email = "btest@key-mail.net",
            Password = "Qwerty123!"
        };
        public string token = "Bearer " + Helper.GetToken(userData);

        [Test]
        public void SuccessLogin()
        {
            var data = new UserViewModel()
            {
                Email = "btest3@key-mail.net",
                Password = "Qwerty123!"
            };
            RestRequest request = new RestRequest("/api/identity/login", Method.POST);
            request
                .AddHeader("api-version", "1")
                .AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(data));
            IRestResponse response = _client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.IsSuccessful);
        }
        [Test]
        public void CheckIdentityLogin()
        {
            var data = new UserViewModel()
            {
                Email = "btest3@key-mail.net",
                Password = "Qwerty123!"
            };
            RestRequest request = new RestRequest("/api/identity/login", Method.POST);
                request
                .AddHeader("api-version", "1")
                .AddHeader("Content-Type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(data));

            IRestResponse<LoginResponse> response = _client.Execute<LoginResponse>(request);
            var content = response.Data.authData.token;

            IdentityChecks identityChecks = response.Data.identityChecks;
            IdentityChecks identity = SuccessIdentityChecks.getSuccessfulIdentityChecks();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(identityChecks==identity);
        }


        [Test]
        public void UpdateUserProfile()
        {
            var UserDetails = new UserProfileViewModel()
            {
                firstName = "TestName",
                lastName = "TestLastName",
                email = userData.Email,
                address = "userAddressValue",
                phoneNumber = "+3 (333) 333-3333",
                profilePhoto = "TestProfile"

            };
            RestRequest request = new RestRequest("/api/profile/updateAccount", Method.POST);
            request
                .AddHeader("api-version", "1")
                .AddHeader("Content-Type", "application/json")
                .AddHeader("Authorization", token)
            .AddJsonBody(JsonConvert.SerializeObject(UserDetails));
            IRestResponse response = _client.Execute(request);

            var all = response.Request;
            Assert.IsTrue(response.IsSuccessful);
        }
    }
}



