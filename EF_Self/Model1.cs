namespace EF_Self
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

        public virtual DbSet<Self> Selves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Self>()
                .Property(e => e.MName)
                .IsUnicode(false);

            modelBuilder.Entity<Self>()
                .Property(e => e.Lname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Self>()
                .HasOptional(e => e.Self1)
                .WithRequired(e => e.Self2);
        }
    }
}
