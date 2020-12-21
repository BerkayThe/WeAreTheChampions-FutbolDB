using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolDb
{
    public class FutbolDbContext : DbContext
    {
        public FutbolDbContext() : base("name=Ftbl")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mac>()
                .HasRequired(m => m.Takim1)
                .WithMany(t => t.Takim1Maclari)
                .HasForeignKey(m => m.Takim1Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mac>()
                .HasRequired(m => m.Takim2)
                .WithMany(t => t.Takim2Maclari)
                .HasForeignKey(m => m.Takim2Id)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Takim> Takimlar { get; set; }
        public DbSet<Renk> Renkler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Mac> Maclar { get; set; }
        
    }
}
