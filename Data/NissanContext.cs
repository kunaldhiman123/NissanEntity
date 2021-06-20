using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nissan.Models;

namespace Nissan.Data
{
    public class NissanContext : DbContext
    {
        public NissanContext (DbContextOptions<NissanContext> options)
            : base(options)
        {
        }

        public DbSet<Nissan.Models.Cars> Cars { get; set; }

        public DbSet<Nissan.Models.Members> Members { get; set; }

        public DbSet<Nissan.Models.Sale> Sale { get; set; }

        public DbSet<Nissan.Models.Payment> Payment { get; set; }

        public DbSet<Nissan.Models.admin> admin { get; set; }
    }
}
