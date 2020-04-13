using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.IServices;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Data.Services
{
    public class EmployeeService

    {
        private readonly EmployeeContext _dbContext;

        public EmployeeService(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get All Employees
        public List<Employee> GetEmployees()
        {
            var emplyees = _dbContext.Employees.ToList();
            return emplyees;
        }
        
        // Get Employee By Id
        public Employee GetEmployeeById(int id)
        {
            var employee = _dbContext.Employees.SingleOrDefault(e => e.EmployeeId == id);

            return employee;
        }

        // Create New Employee
        public string AddEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
            
            return "New Employee Record Created Successfully";
        }

        // Delete Employee By Id
        public string DeleteEmployee(Employee employee)
        {
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();

            return "Employee Deleted Successfully";
        }

        // Update Employee
        public string UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
          
            return "Update Successfully";
         }  
    }
}
