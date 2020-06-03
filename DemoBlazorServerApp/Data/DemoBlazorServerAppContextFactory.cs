using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Data
{
    public class DemoBlazorServerAppContextFactory : IDesignTimeDbContextFactory<DemoBlazorServerAppContext>
    {
        public DemoBlazorServerAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DemoBlazorServerAppContext>();
            var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
            optionsBuilder.UseNpgsql(connStr);
            return new DemoBlazorServerAppContext(optionsBuilder.Options);
        }
    }
}
