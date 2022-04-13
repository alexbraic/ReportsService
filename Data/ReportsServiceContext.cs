#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportsService.Modules;

namespace ReportsService.Data
{
    public class ReportsServiceContext : DbContext
    {
        public ReportsServiceContext (DbContextOptions<ReportsServiceContext> options)
            : base(options)
        {
        }

        public DbSet<ReportsService.Modules.Report> Report { get; set; }
    }
}
