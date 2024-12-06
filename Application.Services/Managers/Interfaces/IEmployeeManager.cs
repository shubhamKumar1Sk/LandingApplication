using Application.Services.Models.Entities;

namespace Application.Services.Managers.Interfaces
{
    public interface IEmployeeManager
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }
}
