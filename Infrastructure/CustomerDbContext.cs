using CompanyX.ClarioCRM.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.Infrastructure
{
    public class CustomerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=172.3.1.1;Database=AppY_DB;User ID=sa;Password=Password@1;");
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Contact> Contacts { get; set; }
    }
}
