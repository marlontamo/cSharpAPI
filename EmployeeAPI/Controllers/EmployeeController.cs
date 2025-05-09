using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/EmployeeAPI")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult GetEmployee()
        {
            var employee = _context.Employees.OrderByDescending(e => e.Id).ToList();
            return Ok(employee);
        }
        [HttpGet("{Id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDto employeeDto) {
            var emp = new Employee
            {
                firstName = employeeDto.firstName,
                lastName = employeeDto.lastName,
                email = employeeDto.email,
                phone = employeeDto.phone,
            };
              _context.Employees.Add(emp);
            _context.SaveChanges();
             
            return Ok(emp);
        }
        [HttpPut("{id}")]
        public IActionResult EditEmployee(int id, EmployeeDto employeeDto)
        {
            var emp = _context.Employees.Find(id);

            if (emp == null)
            {
                return NotFound();

            }
            emp.firstName = employeeDto.firstName;  
            emp.lastName = employeeDto.lastName;
            emp.email = employeeDto.email;
            emp.phone = employeeDto.phone;
            _context.SaveChanges();

            return Ok(emp);

           
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return Ok();
        }
    }
}
