namespace School.Entities.Base
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolModel : DbContext
    {
        public SchoolModel()
            : base("name=SchoolModel")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Grado> Grado { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Seccion> Seccion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Matricula)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .Property(e => e.Nivel)
                .IsUnicode(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Matricula)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grado>()
                .HasMany(e => e.Seccion)
                .WithRequired(e => e.Grado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seccion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
