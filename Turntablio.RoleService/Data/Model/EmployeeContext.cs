using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Turntablio.RoleService.Data.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeRole>()
                .HasKey(er => new { er.EmployeeId, er.RoleId });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 1,
                   EmployeeFirstName = "John",
                   EmployeeLastName = "Erbynn",
                   EmployeeEmail = "john.erbynn@turntabl.io",
                   EmployeeAddress = "Norway, Taifa, Accra, Ghana"
               },

               new Employee
               {
                   EmployeeId = 2,
                   EmployeeFirstName = "Alex",
                   EmployeeLastName = "Owusu",
                   EmployeeEmail = "alex.owusu@turntabl.io",
                   EmployeeAddress = "Tantra, Accra, Ghana"
               },

                new Employee
                {
                    EmployeeId = 3,
                    EmployeeFirstName = "Dawud",
                    EmployeeLastName = "Ismail",
                    EmployeeEmail = "idawud@turntabl.io",
                    EmployeeAddress = "Madina, Accra, Ghana"
                }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Developer"
                },

                new Role
                {
                    RoleId = 2,
                    RoleName = "Project Manager"
                },

                new Role
                {
                    RoleId = 3,
                    RoleName = "Admin"
                }
            );

            modelBuilder.Entity<EmployeeRole>().HasData(
                new EmployeeRole
                {
                    EmployeeId = 1,
                    RoleId = 1
                },

                 new EmployeeRole
                 {
                     EmployeeId = 2,
                     RoleId = 1
                 },

                new EmployeeRole
                {
                    EmployeeId = 3,
                    RoleId = 2
                }
            );

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }

    }
}
