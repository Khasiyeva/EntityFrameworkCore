using EntityFrameworkCore1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = EntityFrameworkCore1.Models.Group;

namespace EntityFrameworkCore1.DAL
{
    internal class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=LAPTOP-8548TISO;database=EntityFrameworkCore;Trusted_connection=true;Integrated security=true;Encrypt=false");

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
