using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Employeesdb
    {
    }
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions options) : base(options)
        {

        }

        public EmployeesContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Customerprofile;Trusted_Connection=True;");
            }
        }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeesDetails> EmployeesDetails { get; set; }


    }
}

