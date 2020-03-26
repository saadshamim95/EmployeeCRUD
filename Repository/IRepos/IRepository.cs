using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.IRepos
{
    public interface IRepository
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee, int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}