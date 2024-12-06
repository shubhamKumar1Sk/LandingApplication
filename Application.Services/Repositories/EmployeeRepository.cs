using Application.Services.Models.Entities;
using Application.Services.Repositories.DBContext;
using Application.Services.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            try
            {
                var employees = _context.Employees.ToList();
                return employees;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> AddEmployee(Employee request)
        {
            await  _context.Employees.AddAsync(request);
            var response = await _context.SaveChangesAsync();
            return response;
        }
    }
}
