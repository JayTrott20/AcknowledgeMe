//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QueensBeyondV._3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalonManagementSystemEntities1 : DbContext
    {
        public SalonManagementSystemEntities1()
            : base("name=SalonManagementSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SalonAppointmentTable> SalonAppointmentTables { get; set; }
        public virtual DbSet<LogonTable2> LogonTable2 { get; set; }
    }
}
