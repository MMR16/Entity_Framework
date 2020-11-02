namespace EF_FromDataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Context")
        {
        }

        public virtual DbSet<Cource> Cources { get; set; }
        public virtual DbSet<MIX> MIXes { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cource>()
                .Property(e => e.Fname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cource>()
                .HasMany(e => e.MIXes)
                .WithRequired(e => e.Cource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MIX>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Lname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.MIXes)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
