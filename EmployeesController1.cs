
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapplication3.Controllers
{
    [ApiController]
    public class EmployeesController1 : ControllerBase
    {
        private IEmployeeData  employeeData;
        public EmployeesController1(IEmployeeData employeeData)
        {
            this.employeeData = employeeData;
        }
        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetEmployees()
        {
            return Ok(this.employeeData.GetEmployees());

        }
    }
}
