using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;
using VogCodeChallenge.API.Exceptions;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeesController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        /// <summary>
        /// Returns all employees
        /// </summary>
        /// <returns>
        /// List of employees
        /// </returns>
        /// <response code="200">If list of employees is >= 0</response>
        /// <response code="404">If list of employees is null</response>
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> AllEmployees()
        {
            // To simulate an async method
            var employees = await Task.Run(() => _employeeServices.ListAll());

            return CreateResponse(employees);

        }

        /// <summary>
        /// Returns all employees in a specific department. Takes in the department Id from the url
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>List of employees with the matching department Id</returns>
        /// <response code="200">if list of employees is >= 0 </response>
        /// <response code="404">If list of employees is null</response>
        [HttpGet("/department/{departmentId}")]
        public async Task<ActionResult<List<Employee>>> DepartmentEmployees([FromRoute] Guid departmentId)
        {
            var employeesInDepartment = await Task.Run(() => _employeeServices.GetAllFromDepartment(departmentId));
            
            return CreateResponse(employeesInDepartment);
        }
    }
}
