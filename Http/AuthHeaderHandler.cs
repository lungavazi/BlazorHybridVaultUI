using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using VaultUI.Services;

namespace VaultUI.Http
{
    public class AuthHeaderHandler : DelegatingHandler
    {
        private readonly AuthService _authService;

        public AuthHeaderHandler(AuthService authService)
        {
            _authService = authService;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _authService.Token;
            if (!string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}