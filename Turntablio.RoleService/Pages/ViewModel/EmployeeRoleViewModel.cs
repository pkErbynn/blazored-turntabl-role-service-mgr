using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Pages.ViewModel
{
    public class EmployeeRoleViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }

        public List<RoleViewModel> RolesViewModel { get; set; }
    }
}

