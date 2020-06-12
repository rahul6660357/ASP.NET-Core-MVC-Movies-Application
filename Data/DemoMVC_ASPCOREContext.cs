using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC_ASPCORE.Models;

namespace DemoMVC_ASPCORE.Data
{
    public class DemoMVC_ASPCOREContext : DbContext
    {
        public DemoMVC_ASPCOREContext (DbContextOptions<DemoMVC_ASPCOREContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC_ASPCORE.Models.Movie> Movie { get; set; }
    }
}
