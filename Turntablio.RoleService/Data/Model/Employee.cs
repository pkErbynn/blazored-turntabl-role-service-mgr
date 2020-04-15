using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter employee's first name")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [Required(ErrorMessage = "Please enter employee's last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [Required(ErrorMessage = "Please enter employee's email")]
        [Display(Name = "Email")]
        [StringLength(60)]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Please enter employee's address")]
        [Display(Name = "Address")]
        [StringLength(255)]
        public string EmployeeAddress { get; set; }

        public ICollection<EmployeeRole> EmployeeRoles { get; set; }

    }
}
 