using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Labs2.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Evaluations> Evaluations { get; set; }
        public virtual DbSet<Specialties> Specialties { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialties>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Specialties)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Students>()
                .HasOptional(e => e.Evaluations)
                .WithRequired(e => e.Students)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Evaluations)
                .WithOptional(e => e.Subjects)
                .HasForeignKey(e => e.ID_Subjects1);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Evaluations1)
                .WithOptional(e => e.Subjects1)
                .HasForeignKey(e => e.ID_Subjects2)
                .WillCascadeOnDelete();
        }
    }
}
