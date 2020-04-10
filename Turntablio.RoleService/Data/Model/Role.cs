using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data.Model
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        [StringLength(50)]
        public string RoleName { get; set; }
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }

    }
}
