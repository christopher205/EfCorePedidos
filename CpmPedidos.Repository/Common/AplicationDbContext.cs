using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Repository.Common
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public AplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
