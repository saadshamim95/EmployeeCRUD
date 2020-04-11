//-----------------------------------------------------------------------
// <copyright file="RepositoryImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Repository.RepositoryImpl
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Model;
    using Repository.Context;
    using Repository.IRepos;

    /// <summary>
    /// Class implementing interface IRepository
    /// </summary>
    /// <seealso cref="Repository.IRepos.IRepository" />
    public class RepositoryImpl : IRepository
    {
        /// <summary>
        /// The user database context
        /// </summary>
        private readonly UserDbContext userDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryImpl"/> class.
        /// </summary>
        /// <param name="userDbContext">The user database context.</param>
        public RepositoryImpl(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> AddEmployee(Employee employee)
        {
            this.userDbContext.Employees.Add(employee);
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> DeleteEmployee(int id)
        {
            Employee item = this.userDbContext.Employees.Find(id);
            this.userDbContext.Remove(item);
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>It returns all the Employees.</returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.userDbContext.Employees;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>It return Employee with given Id.</returns>
        public Employee GetEmployee(int id)
        {
            var result = this.userDbContext.Employees.Find(id);
            return result;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>It returns if execution is successful or not</returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = this.userDbContext.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>It returns true if login successful</returns>
        public bool LoginEmployee(string email, string password)
        {
            var result = userDbContext.Employees.Where(id => id.Email == email && id.Password == password);

            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}