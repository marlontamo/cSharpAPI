using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class EmployeeDto
    {
        [Required]
        public required string firstName { get; set; }
        [Required]
        public required string lastName { get; set; }
        [Required]
        public required string email { get; set; }
        [Required]
        public required string phone { get; set; }
    }
}
