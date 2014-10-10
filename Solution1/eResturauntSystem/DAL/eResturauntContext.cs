using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eResturauntSystem.Entites;
using eResturauntSystem.POCOs;
using System.Data.Entity;
using eRestaurantSystem.Entities;
#endregion

namespace eResturauntSystem.DAL
{
    //hookup to Entity Framework via the DbContext base class
    internal class eResturauntContext:DbContext
    {
        //constructor pass to the base class the name value for the 
        //connetion string to the database found in WebConnectionStrings.config
        public eResturauntContext() : base("name=EatIn") { }

        //One DbSet is to be created for each entity to be referenced by your 
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        //public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                   .Entity<Reservation>().HasMany(r => r.Tables)
                   .WithMany(t => t.Reservations)
                   .Map(mapping =>
                   {
                       mapping.ToTable("ReservationTables");
                       mapping.MapLeftKey("TableID");
                       mapping.MapRightKey("ReservationID");
                   });
            base.OnModelCreating(modelBuilder);
        }
    }
}
