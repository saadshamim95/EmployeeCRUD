using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IManager
    {
        Task<int> AddEmployee(Employee employee);
        Task<int> DeleteEmployee(int id);
        Task<int> UpdateEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}