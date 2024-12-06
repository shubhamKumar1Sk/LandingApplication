using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Models.RequestDTO
{
    public class EmployeeRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNO { get; set; }
        // public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmployeeGender { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Aadhar { get; set; }
    }
}
