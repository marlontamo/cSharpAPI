using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> GetEmployeeName()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    firstName = "Marlon",
                    lastName = "Tamo",
                    email = "marlontamo@gmail.com",
                    phone = 09950850882
                }

            };
        }
    }
}
