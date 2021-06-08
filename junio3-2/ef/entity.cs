using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace junio3_2.ef
{
    public partial class entity : DbContext
    {
        public entity()
            : base("name=entity")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
