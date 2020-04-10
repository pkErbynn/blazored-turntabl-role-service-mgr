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

        // Get All Employees
        public List<Employee> GetEmployees()
        {
            var employees = _dbContext.Employees.ToList();
            return employees;
        }

        // Get Employee By Id
        public Employee GetEmployee(int id)
        {
            Employee employee = _dbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            return employee;
        }

        // Creat New Employee
        public string AddEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
            
            return "New Employee Added Successfully";
        }

        // Get Employee By Id
        public string DeleteEmployee(Employee employee)
        {
            //var employee = _dbContext.Employees.Find(id);
            //_dbContext.Remove(employee);
            //_dbContext.SaveChanges();

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
