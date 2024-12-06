using Application.Services.Models.Entities;

namespace Application.Services.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
        Task<int> AddEmployee(Employee request);
    }
}
