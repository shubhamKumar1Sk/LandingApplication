using Application.Services.Models.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<bool> ValidateCredentials(LoginDetailsDTO request);
    }
}
