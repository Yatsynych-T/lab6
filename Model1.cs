namespace Lab6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Network> Network { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Cities)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Restaurants)
                .WithOptional(e => e.City)
                .HasForeignKey(e => e.Cities_id);

            modelBuilder.Entity<Country>()
                .Property(e => e.Countries)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.City)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.Country_id);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Personal)
                .WithOptional(e => e.Equipment)
                .HasForeignKey(e => e.Equipment_id);

            modelBuilder.Entity<Network>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Network>()
                .HasMany(e => e.Country)
                .WithOptional(e => e.Network)
                .HasForeignKey(e => e.Network_id);

            modelBuilder.Entity<Network>()
                .HasMany(e => e.Restaurants)
                .WithOptional(e => e.Network)
                .HasForeignKey(e => e.Network_id);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Personal)
                .WithOptional(e => e.Products)
                .HasForeignKey(e => e.Product_id);

            modelBuilder.Entity<Restaurants>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurants>()
                .HasMany(e => e.Personal)
                .WithOptional(e => e.Restaurants)
                .HasForeignKey(e => e.Restaurant_id);
        }
    }
}
