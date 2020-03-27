using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Context;
using Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class RepositoryImpl : IRepository
    {
        private readonly UserDbContext userDbContext;

        public RepositoryImpl(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }
        
        public Task<int> AddEmployee(Employee employee)
        {
            this.userDbContext.Employees.Add(employee);
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        public Task<int> DeleteEmployee(int id)
        {
            Employee item = this.userDbContext.Employees.Find(id);
            this.userDbContext.Remove(item);
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.userDbContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
            var result = this.userDbContext.Employees.Find(id);
            return result;
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = this.userDbContext.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }
    }
}