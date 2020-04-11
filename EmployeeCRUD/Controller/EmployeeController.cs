//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace EmployeeCRUD.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Manager.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    /// <summary>
    /// EmployeeController Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        private readonly IManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns status of the request.</returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns status of the request.</returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            var result = await this.manager.UpdateEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It returns status of the request.</returns>
        [Route("DeleteEmployee")]
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await this.manager.DeleteEmployee(id);
            if (result == 1)
            {
                return this.Ok(id);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It returns Employee for the given id.</returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns all the Employees.</returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>It return</returns>
        [Route("Login")]
        [HttpPost]
        public IActionResult LoginEmployee(Employee employee)
        {
            var result = this.manager.LoginEmployee(employee.Email, employee.Password);
            if (result == true)
            {
                return this.Ok(employee.Email);
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}