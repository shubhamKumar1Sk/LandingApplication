namespace Application.Services.Models.Entities
{
    public class Project
    {
        public int ProjectID { get; set; } // Primary Key
        public string ProjectName { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Budget { get; set; }
        public string? Description { get; set; } = string.Empty; // Detailed project description
        public string Status { get; set; } = "Not Started"; // Status: Not Started, In Progress, Completed, On Hold, etc.
        public int? Priority { get; set; } // Priority level: 1 = High, 2 = Medium, 3 = Low
        public string? ClientName { get; set; } = string.Empty; // Name of the client associated with the project
        public string? ClientContact { get; set; } = string.Empty; // Client contact details
        public string? Manager { get; set; } = string.Empty; // Name of the project manager
        public string? Department { get; set; } = string.Empty; // Department overseeing the project
        public string Location { get; set; } = string.Empty; // Location of the project

        // Navigation Property
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
