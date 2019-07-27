namespace EntityFrameWorkOneToOneToManyExample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<outfit> outfits { get; set; }
        public virtual DbSet<outfit_to_shirt> outfit_to_shirt { get; set; }
        public virtual DbSet<shirt> shirts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<outfit>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<outfit>()
                .HasMany(e => e.outfit_to_shirt)
                .WithRequired(e => e.outfit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shirt>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<shirt>()
                .HasMany(e => e.outfit_to_shirt)
                .WithRequired(e => e.shirt)
                .WillCascadeOnDelete(false);
        }
    }
}
