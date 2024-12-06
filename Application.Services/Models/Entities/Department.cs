namespace Application.Services.Models.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; } // Primary Key
        public string DepartmentName { get; set; } = string.Empty;
        public string? Location { get; set; }
        public string? Description { get; set; } // A brief description of the department
        public string? Manager { get; set; } // Name or ID of the department manager
        public DateTime EstablishedDate { get; set; } // When the department was established
        public decimal? Budget { get; set; } // Annual budget allocated to the department
        public string? PhoneNumber { get; set; } // Contact number for the department
        public string? Email { get; set; } // Contact email for the department
        public bool IsActive { get; set; } = true; // Whether the department is currently active
        public string? ParentDepartment { get; set; } // Parent department name or ID, if applicable

        // Navigation Property
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
