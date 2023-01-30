using Blazored.LocalStorage;

namespace TSystems.GitlabReport.Web.Core.Startup.Interceptor
{
    public class AuthorizationInterceptor : DelegatingHandler
    {
        private ILocalStorageService _localStorage;

        public AuthorizationInterceptor(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var jwtToken = await _localStorage.GetItemAsStringAsync("JwtToken");
            request.Headers.Add("Authorization", $"Bearer {jwtToken}");
            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }
}
