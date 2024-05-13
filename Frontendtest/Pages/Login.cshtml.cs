using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontendtest.Pages
{
    public class LoginModel : PageModel
    {
        public async Task OnGet(string redirectUri = "https://sportsapp-frontend.gentleocean-f1a5d1ad.westeurope.azurecontainerapps.io/callback")
        {
            var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
                .WithRedirectUri(redirectUri)
                .Build();

            await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
        }
    }
}

