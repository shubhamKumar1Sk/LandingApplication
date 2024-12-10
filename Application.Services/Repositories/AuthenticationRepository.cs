using Application.Services.Models.RequestDTO;
using Application.Services.Repositories.DBContext;
using Application.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public readonly ApplicationDBContext _context;

        public AuthenticationRepository(ApplicationDBContext context) { 
        _context = context;
        }

        public async Task<bool> ValidateCredentials(LoginDetailsDTO request)
        {
            var user = await _context.Employees.FirstOrDefaultAsync(e => e.Email == request.Email && e.Password == request.Password);
            return user != null;
        }
    }
}
