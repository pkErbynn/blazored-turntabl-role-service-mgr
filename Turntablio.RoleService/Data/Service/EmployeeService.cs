using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Data.Service
{
    public class EmployeeService
    {
        private readonly EmployeeContext _dbContext;

        public EmployeeService(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
