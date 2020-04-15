using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.IServices;
using Turntablio.RoleService.Data.Model;
using Turntablio.RoleService.Pages.ViewModel;

namespace Turntablio.RoleService.Data.Services
{
    public class EmployeeService : IEmployeeService

    {
        private readonly EmployeeContext _dbContext;

        public EmployeeService(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get All Employees and their corresponding role(s)
        public List<EmployeeRoleViewModel> GetEmployees()
        {         
            List<EmployeeRoleViewModel> empList = new List<EmployeeRoleViewModel>();
            List<RoleViewModel> roleList = new List<RoleViewModel>();

            var employees = _dbContext.Employees.ToList();

            foreach (Employee emp in employees)
            {
                var roles = (from e in _dbContext.Employees
                             join er in _dbContext.EmployeeRoles on e.EmployeeId equals er.EmployeeId
                             join r in _dbContext.Roles on er.RoleId equals r.RoleId
                             where e.EmployeeId == emp.EmployeeId
                             select r).ToList();

                foreach(var r in roles)
                {
                    roleList.Add(roleMapper(r.RoleId, r.RoleName));
                }

                empList.Add(employeeRoleMapper(emp, roleList));
            };
       
            return empList;
        }


        public RoleViewModel roleMapper(int id, string name)
        {
            RoleViewModel roleViewModel = new RoleViewModel()
            {
                RoleId = id,
                RoleName = name
            };
            return roleViewModel;
        }


        public EmployeeRoleViewModel  employeeRoleMapper(Employee employee, List<RoleViewModel> roles)
        {
            EmployeeRoleViewModel empViewModel = new EmployeeRoleViewModel()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeFirstName = employee.EmployeeFirstName,
                EmployeeLastName = employee.EmployeeLastName,
                EmployeeAddress = employee.EmployeeAddress,
                EmployeeEmail = employee.EmployeeEmail,
                RolesViewModel = roles
            };
            return empViewModel;
        }


        // Fetch employee detail
        public EmployeeRoleViewModel GetEmployeeDetailById(int id)
        {
            var soloEmp = this.GetEmployeeById(id);
            List<RoleViewModel> soloEmpRoles = new List<RoleViewModel>();

            var roles = (from e in _dbContext.Employees
                         join er in _dbContext.EmployeeRoles on e.EmployeeId equals er.EmployeeId
                         join r in _dbContext.Roles on er.RoleId equals r.RoleId
                         where e.EmployeeId == soloEmp.EmployeeId
                         select r).ToList();

            foreach (var r in roles)
            {
                soloEmpRoles.Add(roleMapper(r.RoleId, r.RoleName));
            }

            EmployeeRoleViewModel  empDetail= this.employeeRoleMapper(soloEmp, soloEmpRoles);
            return empDetail;
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
