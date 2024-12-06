using Application.Services.Managers.Interfaces;
using Application.Services.Models.Entities;
using Application.Services.Models.RequestDTO;
using Application.Services.Repositories.Interfaces;
namespace Application.Services.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        public readonly IEmployeeRepository employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await employeeRepository.GetAllEmployees();
        }

        public async Task<int> AddEmployee(EmployeeRequestDto request)
        {
            Employee newEmployee = new Employee
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNO = request.PhoneNO,
                // Email = request.Email,
                DateOfBirth = request.DateOfBirth,
                EmployeeGender = request.EmployeeGender,
                DateOfJoining = request.DateOfJoining,
                Aadhar = request.Aadhar,
                Department = null,
                DepartmentId = 1,
                IsActive = true,  // Set default values for additional fields
                IsDeleted = false
            };

            return await employeeRepository.AddEmployee(newEmployee);
        }
    }
}
