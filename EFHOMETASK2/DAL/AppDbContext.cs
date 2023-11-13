using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFHOMETASK2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFHOMETASK2.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=SHAMSZ\\SQLEXPRESS01;database=AB202EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }
        public DbSet<Student> Students { get; set; }

    }
}
