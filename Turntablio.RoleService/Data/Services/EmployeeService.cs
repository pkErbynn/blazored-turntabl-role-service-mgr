using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.IServices;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext _dbContext;

        public EmployeeService(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
