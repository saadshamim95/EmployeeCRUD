//-----------------------------------------------------------------------
// <copyright file="ManagerImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Manager.ManagerImpl
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Manager.Interface;
    using Model;
    using Repository.IRepos;

    /// <summary>
    /// Class implementing IManager interface
    /// </summary>
    /// <seealso cref="Manager.Interface.IManager" />
    public class ManagerImpl : IManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerImpl"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ManagerImpl(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repository.AddEmployee(employee);
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns all the Employees.</returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It return Employee with given Id.</returns>
        public Employee GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> UpdateEmployee(Employee employee)
        {
            return this.repository.UpdateEmployee(employee);
        }
    }
}