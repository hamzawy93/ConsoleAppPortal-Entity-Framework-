using ConsoleAppPortal.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPortal.DAL.DB
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=InStockDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        DbSet<Employee> Employees {  get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<Project> Projects { get; set; }
    }

    }

