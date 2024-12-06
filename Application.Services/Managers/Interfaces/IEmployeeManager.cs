using Application.Services.Models.Entities;
using Application.Services.Models.RequestDTO;

namespace Application.Services.Managers.Interfaces
{
    public interface IEmployeeManager
    {
        Task<List<Employee>> GetAllEmployees();
        Task<int> AddEmployee(EmployeeRequestDto request);
    }
}
