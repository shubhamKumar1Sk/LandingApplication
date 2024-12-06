using Application.Services.Models.Entities;

namespace Application.Services.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllDepartments();
    }
}
