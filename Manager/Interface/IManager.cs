//-----------------------------------------------------------------------
// <copyright file="IManager.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Manager.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    
    /// <summary>
    /// Manger Interface
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns if execution is successful or not</returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It returns if execution is successful or not</returns>
        Task<int> DeleteEmployee(int id);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns if execution is successful or not</returns>
        Task<int> UpdateEmployee(Employee employee);

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns all the Employees.</returns>
        IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It return Employee with given Id.</returns>
        Employee GetEmployee(int id);
    }
}