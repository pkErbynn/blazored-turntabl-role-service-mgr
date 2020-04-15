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
        [StringLength(50, ErrorMessage = "First Name can't be more than 50 characters.")]
        public string EmployeeFirstName { get; set; }

        [Required(ErrorMessage = "Please enter employee's last name")]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last name can't be more than 50 characters.")]
        public string EmployeeLastName { get; set; }

        [Required(ErrorMessage = "Please enter employee's email")]
        [EmailAddress(ErrorMessage ="Please provide a valid e-mail address. eg. you@turntabl.io")]
        [Display(Name = "Email")]
        [StringLength(60, ErrorMessage ="Email can't be more than 60 characters.")]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Please enter employee's address")]
        [Display(Name = "Address")]
        [StringLength(255, ErrorMessage = "Address can't be more than 255 characters.")]
        public string EmployeeAddress { get; set; }
        
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }

    }
}
 