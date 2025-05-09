namespace EmployeeAPI.Models
{
    public class Employee
    {
        public required string firstName {  get; set; }
        public required string lastName { get; set; }
        public required string email { get; set; }

        public required long phone { get; set; }

    }
}
