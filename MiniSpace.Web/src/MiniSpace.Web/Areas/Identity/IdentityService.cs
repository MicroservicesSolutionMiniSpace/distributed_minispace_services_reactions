using System.Collections.Generic;
using System.Threading.Tasks;
using MiniSpace.Web.DTO;
using MiniSpace.Web.HttpClients;

namespace MiniSpace.Web.Areas.Identity
{
    class IdentityService : IIdentityService
    {
        private readonly IHttpClient _httpClient;

        public IdentityService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public Task<UserDto> GetAccountAsync(string jwt)
        {
            _httpClient.SetAccessToken(jwt);
            return _httpClient.GetAsync<UserDto>("identity/me");
        }

        public Task SignUpAsync(string firstName, string lastName, string email, string password, string role = "user", IEnumerable<string> permissions = null)
            => _httpClient.PostAsync("identity/sign-up", new {firstName, lastName, email, password, role, permissions});

        public Task<JwtDto> SignInAsync(string email, string password)
            => _httpClient.PostAsync<object, JwtDto>("identity/sign-in", new {email, password});
    }
}