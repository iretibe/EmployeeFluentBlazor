namespace EmployeeFluentBlazor.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
