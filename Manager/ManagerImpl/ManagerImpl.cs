using Manager.Interface;
using Model;
using Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImpl
{
    public class ManagerImpl : IManager
    {
        private readonly IRepository repository;

        public ManagerImpl(IRepository repository)
        {
            this.repository = repository;
        }

        public Task<int> AddEmployee(Employee employee)
        {
            return this.repository.AddEmployee(employee);
        }

        public Task<int> DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(Employee employee)
        {
            return this.repository.UpdateEmployee(employee);
        }
    }
}