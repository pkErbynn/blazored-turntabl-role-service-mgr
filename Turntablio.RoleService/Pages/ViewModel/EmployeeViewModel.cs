using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Pages.ViewModel
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Email")]
        [StringLength(60)]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Address")]
        [StringLength(255)]
        public string EmployeeAddress { get; set; }

        //public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
