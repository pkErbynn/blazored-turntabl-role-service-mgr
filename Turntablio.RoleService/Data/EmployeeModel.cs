using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
