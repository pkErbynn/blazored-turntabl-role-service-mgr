using System.Collections.Generic;
using Turntablio.RoleService.Data.Model;
using Turntablio.RoleService.Pages.ViewModel;

namespace Turntablio.RoleService.Data.IServices
{
    interface IEmployeeService
    {
        public List<EmployeeRoleViewModel> GetEmployees();
        public Employee GetEmployeeById(int id);
        public string AddEmployee(Employee employee);
        public string UpdateEmployee(Employee employee);
        public string DeleteEmployee(Employee employee);
    }
}
