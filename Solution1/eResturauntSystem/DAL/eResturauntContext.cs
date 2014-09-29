using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eResturauntSystem.Entites;
using System.Data.Entity;
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
        //public DbSet<Table> Tables { get; set; }
    }
}
