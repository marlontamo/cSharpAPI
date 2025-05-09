namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string firstName {  get; set; }
        public required string lastName { get; set; }
        public required string email { get; set; }

        public required string phone { get; set; }

    }
}
