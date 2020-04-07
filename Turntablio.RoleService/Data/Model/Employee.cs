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
        public string employeefname { get; set; }
        public string employeelname { get; set; }
        public string employeeemail { get; set; }
        public string employeeaddress { get; set; }
        public string employeerole { get; set; }
    }
}
