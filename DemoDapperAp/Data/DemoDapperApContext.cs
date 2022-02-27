using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoDapperAp.Models;

namespace DemoDapperAp.Data
{
    public class DemoDapperApContext : DbContext
    {
        public DemoDapperApContext (DbContextOptions<DemoDapperApContext> options)
            : base(options)
        {
        }

        public DbSet<DemoDapperAp.Models.Cliente> Cliente { get; set; }
    }
}
