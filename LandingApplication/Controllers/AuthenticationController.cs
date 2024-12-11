using Application.Services.Managers.Interfaces;
using Application.Services.Models.RequestDTO;
using Microsoft.AspNetCore.Mvc;

namespace LandingApplication.Controllers
{
    public class AuthenticationController : Controller
    {
        public readonly IAuthenticationManager authenticationmanager;

        public AuthenticationController(IAuthenticationManager authenticationManager)
        {
            this.authenticationmanager = authenticationManager;
        }

        [HttpPost("/validate")]
        public async Task<bool> ValidateCredentials([FromBody] LoginDetailsDTO request)
        {
            return await authenticationmanager.ValidateCredentials(request);  
        }
    }
}
