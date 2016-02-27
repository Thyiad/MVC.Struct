namespace MVCStruct.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MVCStruct.Model.Admin;

    public partial class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
