using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dropdownlist.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<City> cityTbl { get; set; }
        public DbSet<Province> provinceTbl { get; set; }
        public DbSet<userInfo> userinfiTbl { get; set; }
    }
}
