using Application.Services.Managers.Interfaces;
using Application.Services.Models.Entities;
namespace Application.Services.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        public Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
