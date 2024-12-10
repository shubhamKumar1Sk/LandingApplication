using Application.Services.Models.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Managers.Interfaces
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateCredentials(LoginDetailsDTO request);
    }
}
