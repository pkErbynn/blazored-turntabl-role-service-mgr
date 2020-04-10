using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Data.IServices
{
    interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public void AddEmployee(Employee employee);
        public void EditEmployee(int id);
        public void DeleteEmployee(int id);
    }
}
