using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Data
{
    public class DemoBlazorServerAppContext : DbContext
    {
        public virtual DbSet<Meal> Meals { get; set; }

        public DemoBlazorServerAppContext(DbContextOptions<DemoBlazorServerAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}