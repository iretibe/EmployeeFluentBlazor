namespace EmployeeFluentBlazor.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Guid DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public bool IsSupervisor { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
