namespace Application.Services.Models.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        //  public string Email { get; set; }
        public string? YearOfExperience { get; set; }
        public string PhoneNO { get; set; }
        public string? Aadhar { get; set; }
        public string? PAN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmployeeGender { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double? AnnualPackage { get; set; }
        public double? MonthlySalary { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Department Department { get; set; }
        public int DepartmentId {get; set; }
        public ICollection<Project> Projects { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
