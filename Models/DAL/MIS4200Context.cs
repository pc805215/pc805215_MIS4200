using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using pc805215_MIS4200.Models;

namespace pc805215_MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, pc805215_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Patient> Patient { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}