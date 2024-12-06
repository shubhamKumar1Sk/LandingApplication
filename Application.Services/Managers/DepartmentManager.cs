using Application.Services.Managers.Interfaces;
using Application.Services.Models.Entities;

namespace Application.Services.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        public async Task<IEnumerable<Department>> GetAllDepartmentAsync()
        {
            return new List<Department>();
        }
    }
}
