using Application.Services.Managers.Interfaces;
using Application.Services.Models.RequestDTO;
using Application.Services.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Managers
{
    public class AuthenticationManager : IAuthenticationManager
    {
        public IAuthenticationRepository authenticationrepository;

        public AuthenticationManager(IAuthenticationRepository authenticationRepository)
        {
            authenticationrepository = authenticationRepository;
        }
        public async Task<bool> ValidateCredentials(LoginDetailsDTO request)
        {
            var response = await authenticationrepository.ValidateCredentials(request);
            return response;
        }
    }
}
