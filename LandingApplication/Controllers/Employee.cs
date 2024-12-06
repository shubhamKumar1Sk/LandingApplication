using Application.Services.Managers.Interfaces;
using Application.Services.Models.RequestDTO;
using Microsoft.AspNetCore.Mvc;

namespace LandingApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        [HttpGet("all-employees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var emps = await employeeManager.GetAllEmployees();
            return Ok(emps);
        }

        [HttpPost("add-employee")]
        public async Task<IActionResult> AddEmployee(EmployeeRequestDto request)
        {
            var emps = await employeeManager.AddEmployee(request);
            return Ok(emps);
        }
    }
}
