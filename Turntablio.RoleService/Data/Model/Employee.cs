using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data.Model
{
    public class Employee
    {
        [Key]
        public int employeeid { get; set; }

        [Required]
        public string employeefname { get; set; }

        [Required]
        public string employeelname { get; set; }

        [Required]
        public string employeeemail { get; set; }

        [Required]
        public string employeeaddress { get; set; }

        [Required]
        public string employeerole { get; set; }
    }
}
