using Microsoft.AspNetCore.Mvc.Testing;
using School.Api;
using School.Common.Contracts.Identity;
using School.Contract;
using School.Contract.Requests.Access_Control.Identity;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace School.IntegrationTesting
{
    public class BaseIntegrationTest : IDisposable
    {
        protected readonly HttpClient _baseTestClient;
        public BaseIntegrationTest()
        {
            var _appFactory = new WebApplicationFactory<Startup>()
                                .WithWebHostBuilder(cfg =>
                              {
                                  cfg.ConfigureServices(services =>
                                  {
                                      // to use InMemory Data 
                                      //services.RemoveAll(typeof(SurveyContext));
                                      //services.AddDbContext<SurveyContext>(options => { options.UseInMemoryDatabase("SurveyDbInMemory"); });

                                      //services.RemoveAll(typeof(IUserData));
                                      //services.RemoveAll(typeof(IFeatureData));

                                      //services.AddTransient(typeof(IUserData), typeof(MockUserData));
                                      //services.AddTransient(typeof(IFeatureData), typeof(MockFeatureData));

                                  });
                              });

            _baseTestClient = _appFactory.CreateClient();
            _baseTestClient.BaseAddress = new Uri("http://localhost:26079/");
            _baseTestClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected async Task<string> Authenticate()
        {
            string token = await GetJwt();
            _baseTestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
            return token;
        }

        private async Task<string> GetJwt()
        {
            var loginrequest = new LoginRequest("testg", "test");
            var response = await _baseTestClient.PostAsJsonAsync(ApiRoutes.Identity.LogIn, loginrequest);

            var registrationResponse =await  response.Content.ReadAsAsync<UserLoginResponse>();
            return  registrationResponse.Token;

        }
        public void Dispose()
        {
            _baseTestClient.Dispose();
        }
    }
}
