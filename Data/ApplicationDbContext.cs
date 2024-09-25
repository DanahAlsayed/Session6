using Microsoft.EntityFrameworkCore;
using Session6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6.Data
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; database = Asp9_EF ; Trusted_Connection = true;TrustServerCertificate = True") ;
        }
        public DbSet<Product> Products { get; set; }

    }
}
