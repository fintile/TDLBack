using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDLBack.Models;

namespace TDLBack
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Lista> Lista { get; set; }
        public DbSet<Login> Login { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
    }
}
